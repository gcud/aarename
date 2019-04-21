using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Test
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void ShowStatus(string msg)
        {
            Status.Text = msg;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置宽度
            TabControl.ItemSize = new Size((TabControl.Width - TabControl.TabCount * 2) / TabControl.TabCount, 22);
            //初始化选择
            GenderCombobox.SelectedIndex = 0;
            GenderComboBoxMulti.SelectedIndex = 0;
            //初始化后台任务
            bw.WorkerReportsProgress = true;
            bw.DoWork += Bw_DoWork;
            bw.ProgressChanged += Bw_ProgressChanged;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
        }
        int OldFamilyNameByteLength, OldSecondNameByteLength;

        Encoding GB2312 = Encoding.GetEncoding("gb2312");
        private void button1_Click(object sender, EventArgs e)
        {

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveButton.Enabled = true;
                CreateNewNameButton.Enabled = true;
                string FilePath = OpenFileDialog.FileName;
                //显示路径
                Status.Text = "已打开" + FilePath;
                //读取数据wenjian
                AA.ReadActorFile(FilePath);
                //读取名字
                string[] Name = AA.GetActorName();
                OldFamilyNameByteLength = GB2312.GetBytes(Name[0]).Length;
                OldSecondNameByteLength = GB2312.GetBytes(Name[1]).Length;
                FirstNameTextbox.Text = Name[0];
                SecondNameTextbox.Text = Name[1];
                if (ShowImageCheckbox.Checked)
                {
                    //显示图片
                    ActorImage.Image = Image.FromStream(new MemoryStream(AA.ImageBlock.ToArray()));

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AA.SaveActor(SaveFileWithActorName.Checked, OpenFileDialog.FileName, FirstNameTextbox.Text, SecondNameTextbox.Text, OldFamilyNameByteLength, OldSecondNameByteLength);
            MessageBox.Show("保存成功");
        }
        //关于
        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }
        string[] Files;
        private void SplitContainer_Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Files = e.Data.GetData(DataFormats.FileDrop) as string[];
                foreach (string item in Files)
                {
                    //只接受png,没必要根据内容判断类型
                    if (Path.GetExtension(item) != ".png")
                    {
                        e.Effect = DragDropEffects.None;
                        return;
                    }
                }
                e.Effect = DragDropEffects.All;
            }
            else
                e.Effect = DragDropEffects.None;
        }



        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (JumpNotPng.Checked)
                {
                    Directory.GetFiles(FolderBrowserDialog.SelectedPath, "*.png");
                }
                else
                    Files = Directory.GetFiles(FolderBrowserDialog.SelectedPath);
                MutilTipLabel.Text = Files.Length.ToString() + "个文件";
            }
        }
        private BackgroundWorker bw = new BackgroundWorker();

        Schedule sche = new Schedule();
        int MultiGender;
        private void GenrateChineseNameMultiButton_Click(object sender, EventArgs e)
        {
            MultiGender = GenderComboBoxMulti.SelectedItem.ToString() == "女" ? 0 : 1;
            bw.RunWorkerAsync();
            sche.CloseButton.Visible = false;
            sche.ShowDialog();
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("完成");
            sche.CloseButton.Visible = true;
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ((string)e.UserState== "ReadSameName")
            {
                sche.StatusLabel.Text = "读取名字"+e.ProgressPercentage+"/"+ SameName.Count;
            }
            else if ((string)e.UserState == "SaveActor")
            {
                sche.StatusLabel.Text = "保存角色" + e.ProgressPercentage + "/" + Files.Length;
            }
        }

            List<string> SameName;
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] OldNameByteLength;
            string[] NewName;
            Random random = new Random();
            if (RenameAtSame.Checked)
            {
                SameName = Directory.GetFiles(Path.GetDirectoryName(Files[0])).ToList();
                bw.ReportProgress(SameName.Count);
                string[] s;
                //读取角色名字
                for (int i = 0; i <SameName.Count; i++)
                {
                    AA.ReadActorFile(SameName[i]);
                    s = AA.GetActorName();
                    SameName[i] =s[0]+s[1];
                    bw.ReportProgress(i+1,"ReadSameName");
                }
            }
            for (int i = 0; i < Files.Length; i++)
            {
                AA.ReadActorFile(Files[i]);
                OldNameByteLength = AA.GetActorNameByteLength();
                NewName = AA.GetNewName(0, random.Next(2, 5), MultiGender);
                if (RenameAtSame.Checked)
                {
                    while (SameName.Contains(NewName[0]+NewName[1]))
                    {
                        NewName = AA.GetNewName(0, random.Next(2, 5), MultiGender);
                    }
                    SameName.Add(NewName[0] + NewName[1]);
                }
                  AA.SaveActor(SaveFileWithActorNameMulti.Checked, Files[i], NewName[0], NewName[1], OldNameByteLength[0], OldNameByteLength[1]);
                bw.ReportProgress(i + 1, "SaveActor");

            }

        }

        private void SplitContainer_Panel1_DragDrop(object sender, DragEventArgs e)
        {

            MutilTipLabel.Text = Files.Length.ToString() + "个文件";
            GenrateChineseNameMultiButton.Enabled = true;
        }

        //生成新的角色名
        private void CreateNewNameButton_Click(object sender, EventArgs e)
        {
            string[] Name = AA.GetNewName(0, new Random().Next(2, 5),GenderCombobox.SelectedText=="女"?0:1);
            FirstNameTextbox.Text = Name[0];
            SecondNameTextbox.Text = Name[1];
        }
        
    }
}
