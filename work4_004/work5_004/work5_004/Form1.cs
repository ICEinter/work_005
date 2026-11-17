using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work5_004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Click += textBox1_Click;
            textBox3.Click += textBox3_Click;
            textBox4.Click += textBox4_Click;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            int SCORE = 0;
            DialogResult ms = new DialogResult();
            ms = MessageBox.Show("คุณต้องการส่งคำตอบใช่ไหม", "ถาม-ตอบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ms == DialogResult.Yes)
            {
                if (radioButton2.Checked == true)
                {
                    SCORE += 1;
                }
                if (radioButton6.Checked == true)
                {
                    SCORE += 1;
                }
                if (radioButton9.Checked == true)
                {
                    SCORE += 1;
                }
                if (radioButton15.Checked == true)
                {
                    SCORE += 1;
                }
                if (radioButton18.Checked == true)
                {
                    SCORE += 1;
                }
                if (radioButton23.Checked == true)
                {
                    SCORE += 1;
                }
                if (radioButton25.Checked == true)
                {
                    SCORE += 1;
                }
                if (radioButton31.Checked == true)
                {
                    SCORE += 1;
                }
                if (radioButton33.Checked == true)
                {
                    SCORE += 1;
                }
                if (radioButton38.Checked == true)
                {
                    SCORE += 1;
                }

                textBox2.Text = SCORE.ToString() + " คะแนน";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;
            radioButton25.Checked = false;
            radioButton26.Checked = false;
            radioButton27.Checked = false;
            radioButton28.Checked = false;
            radioButton29.Checked = false;
            radioButton30.Checked = false;
            radioButton31.Checked = false;
            radioButton32.Checked = false;
            radioButton33.Checked = false;
            radioButton34.Checked = false;
            radioButton35.Checked = false;
            radioButton36.Checked = false;
            radioButton37.Checked = false;
            radioButton38.Checked = false;
            radioButton39.Checked = false;
            radioButton40.Checked = false;
            textBox2.Text = "คะแนนที่ได้";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show(
                "คุณต้องการออกจากโปรแกรมใช่ไหม?",
                "ยืนยันการออก",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ms == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
