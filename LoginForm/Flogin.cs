using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //기본 비밀번호 1234
            //사용자가 입력한 id가 test 이고 암호가 1234 이면 성공,

            String 입력한ID = tbID.Text.Trim();
            String 입력한Password = tbPassword.Text;

            if(입력한ID == "")
            {
                MessageBox.Show("ID를 입력하세요.");
                tbID.Text="";
                tbID.Focus();
                return;
            }
            if (입력한Password == "")
            {
                MessageBox.Show("Password를 입력하세요.");
                tbPassword.Text = "";
                tbPassword.Focus();
                return;
            }


            if (입력한ID ==  "test" && 입력한Password == "1234")
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.No;
            }

            

        }
    }
}
