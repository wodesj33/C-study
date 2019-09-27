using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace caipiao
{
    public partial class FrmMain : Form
    {
        private Selector objSelector = new Selector();
        public FrmMain()
        {
            InitializeComponent();
            //禁用相关的按钮
            this.btnGroupSelect.Enabled = false;
            this.btnPrint.Enabled = false;
            this.btnClear.Enabled = false;
            this.btnDel.Enabled = false;
            this.btnSelect.Enabled = false;
        }


        #region  拖动窗体的实现

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                Location = mouseSet;
            }
        
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        //启动选号
        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.RandomTimer.Start();
            this.btnSelect.Enabled = true;
            this.btnStart.Enabled = false;
        }
        //定时生成随机号码
        private void RandomTimer_Tick(object sender, EventArgs e)
        {
            string[] numList = objSelector.CreateNum();//生成随机号
                                                       //显示随机号
            this.lblNum1.Text = numList[0];
            this.lblNum2.Text = numList[1];
            this.lblNum3.Text = numList[2];
            this.lblNum4.Text = numList[3];
            this.lblNum5.Text = numList[4];
            this.lblNum6.Text = numList[5];
            this.lblNum7.Text = numList[6];
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            this.RandomTimer.Stop();//定时器停止
            string[] selectedNum =
            {
                this.lblNum1.Text,
                this.lblNum2.Text,
                this.lblNum3.Text,
                this.lblNum4.Text,
                this.lblNum5.Text,
                this.lblNum6.Text,
                this.lblNum7.Text,
            };
            objSelector.SelectedNums.Add(selectedNum);//保存当前选中的号码
            ShowSeletedNums();//显示选中的号码
           
        }
        private void ShowSeletedNums()
        {
            this.lbNumberList.Items.Clear();
            this.lbNumberList.Items.AddRange(this.objSelector.GetPrintedNums().ToArray());
            //按钮启用
            this.btnStart.Enabled = true;
            this.btnPrint.Enabled = this.btnClear.Enabled = this.btnDel.Enabled = true;
        }

        private void BtnWriteSelf_Click(object sender, EventArgs e)
        {

        }

        private void BtnGroupSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
