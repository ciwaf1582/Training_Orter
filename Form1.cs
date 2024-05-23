using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 연습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("버튼을 클릭했습니다.");
            string strOrder = "";
            lblOrder.Text = " ";
            if (ckbSoon.Checked == true)
            {
                strOrder += ckbSoon.Text + "\n";
            }
            if (ckbPasta.Checked == true)
            {
                strOrder += ckbPasta.Text + "\n";
            }
            if (ckbSteak.Checked == true)
            {
                strOrder += ckbSteak.Text + "\n";
            }
            if (ckbTang.Checked == true)
            {
                strOrder += ckbTang.Text + "\n";
            }
            lblOrder.Text = strOrder + "메뉴를 주문하셨습니다.";
           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked == true) 
            {
                MessageBox.Show("개인정보 동의 하셨습니다.");
            }
            else
            {
                MessageBox.Show("개인정보 동의하지 않으셨습니다.");
            }
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            string strText = textBox1.Text + "\n라고 요구 사항이 접수되었습니다.";
            MessageBox.Show(strText);
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbPay.SelectedIndex == 0)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월 할부");
                lbArea.Items.Add("6개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbArea.Items.Add("하루 은행");
                lbArea.Items.Add("신용 은행");
                lbArea.Items.Add("국물 은행");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbArea.Items.Add("N 포인트");
                lbArea.Items.Add("주유 포인트");
                lbArea.Items.Add("레이저 포인트");
            }
        }
        private void BtnPay_CIick(object sender, EventArgs e)
        {
            string strText = cbPay.Text + "(으)로 " + lbArea.Text + 
                " 결재 방법을" + "\n선택하셨습니다.";
            MessageBox.Show(strText);
            
        }

        
    }
}
