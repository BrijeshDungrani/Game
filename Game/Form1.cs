using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        public Boolean check()
        {
            if(p1s.Text == "X")
            {
                if(p2s.Text == "O")
                {
                    return true;
                }
            }
            else if(p1s.Text == "O")
            {
                if(p2s.Text == "X")
                {
                    return true;
                }
            }
           
                return false;
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void clearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(check() == true && ft.Text != "")
            {
                turn.Text = ft.Text;
                sb1.Text = p1s.Text;
                sb2.Text = p2s.Text;
                mode.Text = "Active";
                clearAll();
               if(turn.Text == "Player 1")
                {
                    nt.Text = "O";
                }
                if (turn.Text == "Player 2")
                {
                    nt.Text = "X";
                }
            }
            else
            {
                MessageBox.Show("Complete Full Details");
            }
        }

        public void changeTurn()
        {
            if(nt.Text == "X")
            {
                nt.Text = "O";
            }
           else 
            {
                nt.Text = "X";
            }
        }

        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox9.Text == "" && mode.Text == "Active")
            textBox9.Text = nt.Text;
            changeTurn();
            CheckWin();
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox6.Text == "" && mode.Text == "Active")
                textBox6.Text = nt.Text;
                 changeTurn();
                CheckWin();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "" && mode.Text == "Active")
                textBox1.Text = nt.Text;
            changeTurn();
            CheckWin();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "" && mode.Text == "Active")
                textBox2.Text = nt.Text;
            changeTurn();
            CheckWin();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "" && mode.Text == "Active")
                textBox3.Text = nt.Text;
            changeTurn();
            CheckWin();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox4.Text == "" && mode.Text == "Active")
                textBox4.Text = nt.Text;
            changeTurn();
            CheckWin();
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox5.Text == "" && mode.Text == "Active")
                textBox5.Text = nt.Text;
            changeTurn();
            CheckWin();
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox7.Text == "" && mode.Text == "Active")
                textBox7.Text = nt.Text;
            changeTurn();
            CheckWin();
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox8.Text == "" && mode.Text == "Active")
                textBox8.Text = nt.Text;
            changeTurn();
            CheckWin();
            CheckWin();
        }

        public string getPlayer(string a)
        {
            if(sb1.Text == a)
            {
                return "Player 1";
            }
            else
            {
                return "Player 2";
            }
        }

        public void CheckWin()
        {
            if(textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text && textBox1.Text != "")
            {
                MessageBox.Show( "Congaratulation"+ getPlayer(textBox1.Text) +  " is Win");
                mode.Text = "Disable";
            }

           else if (textBox4.Text == textBox5.Text && textBox5.Text == textBox6.Text && textBox4.Text != "")
            {
                MessageBox.Show("Congaratulation" + getPlayer(textBox4.Text) + " is Win");
                mode.Text = "Disable";
            }

           else if (textBox7.Text == textBox8.Text && textBox8.Text == textBox9.Text && textBox7.Text != "")
            {
                MessageBox.Show("Congaratulation" + getPlayer(textBox7.Text) + " is Win");
                mode.Text = "Disable";
            }

           else if (textBox1.Text == textBox4.Text && textBox4.Text == textBox7.Text && textBox1.Text != "")
            {
                MessageBox.Show("Congaratulation" + getPlayer(textBox1.Text) + " is Win");
                mode.Text = "Disable";
            }

          else  if (textBox2.Text == textBox5.Text && textBox5.Text == textBox8.Text && textBox2.Text != "")
            {
                MessageBox.Show("Congaratulation" + getPlayer(textBox2.Text) + " is Win");
                mode.Text = "Disable";
            }

           else if (textBox3.Text == textBox6.Text && textBox6.Text == textBox9.Text && textBox3.Text != "")
            {
                MessageBox.Show("Congaratulation" + getPlayer(textBox3.Text) + " is Win");
                mode.Text = "Disable";
            }

          else  if (textBox1.Text == textBox5.Text && textBox5.Text == textBox9.Text && textBox1.Text != "")
            {
                MessageBox.Show("Congaratulation" + getPlayer(textBox1.Text) + " is Win");
                mode.Text = "Disable";
            }

          else  if (textBox3.Text == textBox5.Text && textBox5.Text == textBox7.Text && textBox3.Text != "")
            {
                MessageBox.Show("Congaratulation" + getPlayer(textBox3.Text) + " is Win");
                mode.Text = "Disable";
            }
         else   if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" )
            {
                MessageBox.Show("Match is Draw");
            }

        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
            turn.Clear();
            sb1.Clear();
            sb2.Clear();
            nt.Clear();

        }
    }
}
