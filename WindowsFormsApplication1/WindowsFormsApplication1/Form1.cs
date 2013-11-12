using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {



            string op1,op2,op3,op4,op5;
            if (apt1.Checked == true)
            {
              op1=   "ฮอนด้า";
                


           }
            else   if (radioButton2.Checked == true)
            {
                op1= "โตโยต้า";

            }
            else   if (radioButton4.Checked == true)
            {
                op1= "เชฟโลเลต";

            }
            else   if (radioButton5.Checked == true)
            {
               op1= "มาสด้า";

            }
            else
            {
               op1= "ฟอร์ด";

            }
          //  str = str + "2.สีอะไร ===";
            if (bpt1.Checked == true)
            {
              op2=   "ขาว";
            }
            else    if (bpt2.Checked == true)
            {
                op2= "ดำ";
            }
            else    if (radioButton1.Checked == true)
            {
                op2= "แดง";

            }
            else   if (radioButton3.Checked == true)
            {
                op2= "น้ำเงิน";

            }
            else 
            {
                op2= "บรอนด์";

            }
           // str = str + "3.รถแบบไหน ===";
            if (cpt1.Checked == true)
            {
                op3= "รถครอบครัว";
            }
            else   if (cpt2.Checked == true)
            {
                op3= "รถปิคอัพ" ;
            }
            else   
            {
                op3= "รถเก๋ง";

            }
            
           // str = str + "4.แต่งหรือไม่ ===";
            if (dpt1.Checked == true)
            {
                op4= "แต่ง";
            }
            else 
            {
               op4= "ไม่แต่ง";
            }
           // str = str + "5.เบาะอะไร ===";
            if (radioButton9.Checked == true)
            {

                op5 = "หนัง";
            }


            else
            {
                op5 = "กำมะหยี่";
            }

            Form2 frm = new Form2(op1,op2,op3,op4,op5);
            frm.Show();
            
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

