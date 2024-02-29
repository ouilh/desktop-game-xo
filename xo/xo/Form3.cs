using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xo
{
    
    public partial class Form3 : Form
    {
       
        bool a = true;
        
        public Form3()
        {
            
            InitializeComponent();
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
                     
            panel1.Hide();
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            button13.BackColor = Color.FromArgb(0, 0, 0, 0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                

               
                if ((button4.Text == "X" && button5.Text == "X") || (button6.Text == "X" && button9.Text == "X") || (button7.Text == "X" && button11.Text == "X"))
                {
                    panel1.Show();
                    label2.Text = textBox1.Text + "  win";

                }
                else
                {


                    button3.Text = "X"; a = false; label1.Text = textBox2.Text+" turn";button3.Enabled = false;


                }
            }
            else
            {
                if ((button4.Text == "O" && button5.Text == "O") || (button6.Text == "O" && button9.Text == "O") || (button7.Text == "O" && button11.Text == "O"))
                {
                    panel1.Show();
                    label2.Text = textBox2.Text + "  win";
                }
                else
                {
                    button3.Text = "O"; a = true; label1.Text = textBox1.Text+" turn"; button3.Enabled = false;
                }

            }
            if (button11.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && button10.Text != "")
            {
                panel1.Show();
                label2.Text = "equality";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
            button10.Text = "";
            button10.Enabled = true;
            button11.Text = "";
            button11.Enabled = true;
            label1.Text = textBox1.Text + " turn";
            panel1.Hide();
            a = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if ((button7.Text == "X" && button10.Text == "X") || (button3.Text == "X" && button5.Text == "X") )
                {
                    panel1.Show();
                    label2.Text = textBox1.Text + "  win";

                }
                else
                {


                    button4.Text = "X"; a = false; label1.Text = textBox2.Text + " turn"; button4.Enabled = false;


                }
            }
            else
            {
                if ((button7.Text == "O" && button10.Text == "O") || (button3.Text == "O" && button5.Text == "O"))
                {
                    panel1.Show();
                    label2.Text = textBox2.Text + "  win";
                }
                else
                {
                    button4.Text = "O"; a = true; label1.Text = textBox1.Text + " turn"; button4.Enabled = false;
                }

            }
            if (button3.Text != "" && button11.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && button10.Text != "")
            {
                panel1.Show();
                label2.Text = "equality";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if ((button4.Text == "X" && button3.Text == "X") || (button8.Text == "X" && button11.Text == "X") || (button7.Text == "X" && button9.Text == "X"))
                {
                    panel1.Show();
                    label2.Text = textBox1.Text + "  win";

                }
                else
                {


                    button5.Text = "X"; a = false; label1.Text = textBox2.Text + " turn"; button5.Enabled = false;


                }
            }
            else
            {
                if ((button4.Text == "O" && button3.Text == "O") || (button8.Text == "O" && button11.Text == "O") || (button7.Text == "O" && button9.Text == "O"))
                {
                    panel1.Show();
                    label2.Text = textBox2.Text + "  win";
                }
                else
                {
                    button5.Text = "O"; a = true; label1.Text = textBox1.Text + " turn"; button5.Enabled = false;
                }

            }
            if (button3.Text != "" && button4.Text != "" && button11.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && button10.Text != "")
            {
                panel1.Show();
                label2.Text = "equality";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if ((button7.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button9.Text == "X"))
                {
                    panel1.Show();
                    label2.Text = textBox1.Text + "  win";

                }
                else
                {


                    button6.Text = "X"; a = false; label1.Text = textBox2.Text + " turn"; button6.Enabled = false;


                }
            }
            else
            {
                if ((button7.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button9.Text == "O"))
                {
                    panel1.Show();
                    label2.Text = textBox2.Text + "  win";
                }
                else
                {
                    button6.Text = "O"; a = true; label1.Text = textBox1.Text + " turn"; button6.Enabled = false;
                }

            }
            if (button3.Text != "" && button4.Text != "" && button5.Text != "" && button11.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && button10.Text != "")
            {
                panel1.Show();
                label2.Text = "equality";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if ((button4.Text == "X" && button11.Text == "X") || (button6.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button11.Text == "X")||(button5.Text == "X" && button9.Text == "X"))
                {
                    panel1.Show();
                    label2.Text = textBox1.Text + "  win";

                }
                else
                {


                    button7.Text = "X"; a = false; label1.Text = textBox2.Text + " turn"; button7.Enabled = false;


                }
            }
            else
            {
                if ((button4.Text == "O" && button11.Text == "O") || (button6.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button11.Text == "O") || (button5.Text == "O" && button9.Text == "O"))
                {
                    panel1.Show();
                    label2.Text = textBox2.Text + "  win";
                }
                else
                {
                    button7.Text = "O"; a = true; label1.Text = textBox1.Text + " turn"; button7.Enabled = false;
                }

            }
            if (button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button11.Text != "" && button8.Text != "" && button9.Text != "" && button10.Text != "")
            {
                panel1.Show();
                label2.Text = "equality";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if ((button7.Text == "X" && button6.Text == "X") || (button5.Text == "X" && button9.Text == "X"))
                {
                    panel1.Show();
                    label2.Text = textBox1.Text + "  win";

                }
                else
                {


                    button8.Text = "X"; a = false; label1.Text = textBox2.Text + " turn"; button8.Enabled = false;


                }
            }
            else
            {
                if ((button7.Text == "O" && button6.Text == "O") || (button5.Text == "O" && button9.Text == "O"))
                {
                    panel1.Show();
                    label2.Text = textBox2.Text + "  win";
                }
                else
                {
                    button8.Text = "O"; a = true; label1.Text = textBox1.Text + " turn"; button8.Enabled = false;
                }

            }
            if (button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button11.Text != "" && button9.Text != "" && button10.Text != "")
            {
                panel1.Show();
                label2.Text = "equality";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if ((button3.Text == "X" && button6.Text == "X") || (button10.Text == "X" && button11.Text == "X") || (button7.Text == "X" && button5.Text == "X"))
                {
                    panel1.Show();
                    label2.Text = textBox1.Text + "  win";

                }
                else
                {


                    button9.Text = "X"; a = false; label1.Text = textBox2.Text + " turn"; button9.Enabled = false;


                }
            }
            else
            {
                if ((button3.Text == "O" && button6.Text == "O") || (button10.Text == "O" && button11.Text == "O") || (button7.Text == "O" && button5.Text == "O"))
                {
                    panel1.Show();
                    label2.Text = textBox2.Text + "  win";
                }
                else
                {
                    button9.Text = "O"; a = true; label1.Text = textBox1.Text + " turn"; button9.Enabled = false;
                }

            }
            if (button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button11.Text != "" && button10.Text != "")
            {
                panel1.Show();
                label2.Text = "equality";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if ((button7.Text == "X" && button4.Text == "X") || (button11.Text == "X" && button9.Text == "X"))
                {
                    panel1.Show();
                    label2.Text = textBox1.Text + "  win";

                }
                else
                {


                    button10.Text = "X"; a = false; label1.Text = textBox2.Text + " turn"; button10.Enabled = false;


                }
            }
            else
            {
                if ((button7.Text == "O" && button4.Text == "O") || (button11.Text == "O" && button9.Text == "O"))
                {
                    panel1.Show();
                    label2.Text = textBox2.Text + "  win";
                }
                else
                {
                    button10.Text = "O"; a = true; label1.Text = textBox1.Text + " turn"; button10.Enabled = false;
                }

            }
            if (button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && button11.Text != "")
            {
                panel1.Show();
                label2.Text = "equality";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                if ((button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button7.Text == "X") || (button9.Text == "X" && button10.Text == "X"))
                {
                    panel1.Show();
                    label2.Text = textBox1.Text + "  win";

                }
                else
                {


                    button11.Text = "X"; a = false; label1.Text = textBox2.Text + " turn"; button11.Enabled = false;


                }
            }
            else
            {
                if ((button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button7.Text == "O") || (button9.Text == "O" && button10.Text == "O"))
                {
                    panel1.Show();
                    label2.Text = textBox2.Text+"  win";
                }
                else
                {
                    button11.Text = "O"; a = true; label1.Text = textBox1.Text + " turn"; button11.Enabled = false;
                }

            }
            if(button3.Text!="" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && button10.Text != "")
            {
                panel1.Show();
                label2.Text = "equality";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            
            
                label1.Text = textBox1.Text + " turn";
                panel2.Hide();
            
        }
    }
}
