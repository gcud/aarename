using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    static class AA
    {
        public static List<byte> ImageBlock, ActorBlock, AfterActorBlock;
        //读取角色文件
        public static void ReadActorFile(string FilePath)
        {
            byte[] AllData = File.ReadAllBytes(FilePath);
            int Index = 0;
            byte[] search = Encoding.ASCII.GetBytes("IEND");
            bool check = false;
            for (; Index < AllData.Length; Index++)
            {
                if (AllData[Index] == search[0])
                {
                    check = true;
                    for (int j = 1; j < search.Length; j++)
                    {
                        if (AllData[Index + j] != search[j])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        Index += 8;
                        break;
                    }
                }
            }
            search = null;
            ImageBlock = AllData.Take(Index).ToList();
            //人物数据,固定的858字节
            ActorBlock = AllData.Skip(Index).Take(858).ToList();
            AfterActorBlock = AllData.Skip(Index + 858).ToList();
            ReadActorDataBlock();
        }
        //读取角色数据块
        static List<byte> FamilyNameBlock, SecondNameBlock;
        private static void ReadActorDataBlock()
        {
            //前面是编辑声明块,【エディット】编码shift-jis,14字节,加上7字节不明数据块
            //姓数据块,260字节
            FamilyNameBlock = ActorBlock.Skip(21).Take(260).ToList();
            //名数据块,260字节
            SecondNameBlock = ActorBlock.Skip(281).Take(260).ToList();
        }
        //读取名字
        static Encoding GB2312 = Encoding.GetEncoding("gb2312");
        public static string[] GetActorName()
        {
            List<byte> FirstNameLocal = new List<byte> { }, SecondNameLocal = new List<byte> { };
            foreach (int I in FamilyNameBlock)
            {
                if (I == 255)
                {
                    break;
                }
                else
                {
                    FirstNameLocal.Add((byte)(255 - I));
                }
            }
            foreach (int I in SecondNameBlock)
            {
                if (I == 255)
                {
                    break;
                }
                else
                {
                    SecondNameLocal.Add((byte)(255 - I));
                }
            }
            return new string[2] { GB2312.GetString(FirstNameLocal.ToArray()), GB2312.GetString(SecondNameLocal.ToArray()) };
        }
        //获取角色名字字节长度,用于更快的批量处理
        public static int[] GetActorNameByteLength()
        {
            int FirstNameByteLength=0,  SecondNameByteLength=0;
            foreach (int I in FamilyNameBlock)
            {
                if (I == 255)
                {
                    break;
                }
                else
                {
                    FirstNameByteLength++; ;
                }
            }
            foreach (int I in SecondNameBlock)
            {
                if (I == 255)
                {
                    break;
                }
                else
                {
                    SecondNameByteLength++;
                }
            }
            return new int[2] { FirstNameByteLength, SecondNameByteLength };
        }
        //生成新的姓
        static string[] ChineseFamilyName = File.ReadAllText("chinese_firstname.txt").Split(','),
            ChineseSecondName_Girl = File.ReadAllText("girl_secondname .txt").Split(',');
        private static string GenerateNewFamilyName(int Type)
        {
            Random random = new Random();
            //中文的姓
            if (Type == 0)
            {
                return ChineseFamilyName[random.Next(0,ChineseFamilyName.Length)];
            }
            else
            {
                return "";
            }
        }

        //获取新的名
        private static string GenerateNewSecondName(int Type, int Gender, int Length)
        {
            if (Type == 0)
            {
                //中文名
                if (Gender == 0)
                {
                    //妹子
                    Random random = new Random();
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < Length; i++)
                    {
                        sb.Append(ChineseSecondName_Girl[random.Next(0,ChineseSecondName_Girl.Length)]);
                    }
                    return sb.ToString();
                }
                else
                {
                    return "";
                }
            }
            else
            {

                return "";
            }
        }
        //获取新的名字
        public static string[] GetNewName(int Type, int Length, int Gender = 0)
        {
            if (Length < 1)
            {
                throw new ArgumentException("名字长度至少为2");
            }
            else
            {
                int FamilyNameLengthMax = Length - 1;
                string FamilyNameLocal = GenerateNewFamilyName(Type);
                while (FamilyNameLocal.Length > FamilyNameLengthMax)
                {
                    FamilyNameLocal = GenerateNewFamilyName(Type);
                }
                int SecondNameLength = Length-FamilyNameLocal.Length;
                string SecondNameLocal = GenerateNewSecondName(Type, Gender, SecondNameLength);
                return new string[2] { FamilyNameLocal, SecondNameLocal };
            }
        }

        //获取名字byte
        private static byte[] GetNameBytes(string Name, int OldNameBytesLength)
        {
            List<byte> Data = GB2312.GetBytes(Name).ToList();
            for (int i = 0; i < Data.Count; i++)
            {
                Data[i] = (byte)(255 - Data[i]);
            }
            //将空余部分用255填充
            while (Data.Count < OldNameBytesLength)
                Data.Add(255);
            return Data.ToArray();

        }
        //保存角色
        public static void SaveActor(bool SaveWithActorName, string OldFileName, string NewFamilyName, string NewSecondName, int OldFamilyNameByteLength, int OldSecondNameByteLength)
        {
            string SaveName = SaveWithActorName ? Path.GetDirectoryName(OldFileName) + Path.DirectorySeparatorChar + NewFamilyName + NewSecondName + ".png" : OldFileName;
            //组合数据块
            List<byte> Data = new List<byte> { };
            //图像
            Data.AddRange(ImageBlock);
            //角色
            //重写姓数据块
            byte[] Name = GetNameBytes(NewFamilyName, OldFamilyNameByteLength);
            //先要移除原名字块,不足的用255填充
            FamilyNameBlock.RemoveRange(0, OldFamilyNameByteLength);
            FamilyNameBlock.InsertRange(0, Name);
            //重写名数据块
            Name = GetNameBytes(NewSecondName, OldSecondNameByteLength);
            SecondNameBlock.RemoveRange(0, OldSecondNameByteLength);
            SecondNameBlock.InsertRange(0, Name);
            //移除原姓和名的数据块
            ActorBlock.RemoveRange(21, 520);
            ActorBlock.InsertRange(21, FamilyNameBlock);
            ActorBlock.InsertRange(281, SecondNameBlock);
            Data.AddRange(ActorBlock);
            //末尾
            Data.AddRange(AfterActorBlock);
            //写入数据
             File.WriteAllBytes(SaveName, Data.ToArray());
        }
    }
}
