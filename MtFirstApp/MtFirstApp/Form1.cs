using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtFirstApp
{
    public partial class Form1 : Form
    {

        public string UserName = "alan";
        public string Password = "123";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TxtUser.Text = "";
            //TxtPass.Clear();

            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGo_Click(object sender, EventArgs e)
        {

            // Check if the textboxes have input form from the user.
            if(TxtUser.TextLength > 0 && TxtPass.TextLength > 0)
            {
                string inputUser = TxtUser.Text.ToLower();
                string inputPass = TxtPass.Text;
                if (inputUser == UserName && inputPass == Password)
                {
                    //MessageBox.Show("Logged in successfuly!", "Success!", MessageBoxButtons.OK,
                                    //MessageBoxIcon.Information);
                    TxtPass.Clear();
                    TxtUser.Clear();
                    loginScreen();
                    
                }
                else if(inputUser == UserName && inputPass != Password)
                {
                    //MessageBox.Show("Password is incorrect, please check and try again!!!",
                    //"Warning",MessageBoxButtons.OK, //MessageBoxIcon.Exclamation);
                    LblResult.Text = "Password is incorrect, please check and try again!!!";
                    LblResult.ForeColor = Color.Red;
                    TxtPass.Clear();
                }
                else if (inputUser != UserName && inputPass == Password)
                {
                    //MessageBox.Show("Username is incorrect, please check and try again!!!",
                    //"Warning",MessageBoxButtons.OK, //MessageBoxIcon.Exclamation);
                    LblResult.Text = "Username is incorrect, please check and try again!!!";
                    LblResult.ForeColor = Color.Red;
                    TxtUser.Clear();
                }
                else
                {
                    //MessageBox.Show("Username or password is incorrect, please check and try again!!!",
                                    //"Warning",MessageBoxButtons.OK, //MessageBoxIcon.Exclamation);
                    LblResult.Text = "Username or password is incorrect, please check and try again!!!";
                    LblResult.ForeColor = Color.Red;
                    TxtPass.Clear();
                    TxtUser.Clear();
                }

            }
            else
            {
                LblResult.Text = "The Username and password match, Congrats!!!";
                LblResult.ForeColor = Color.Red;
                //MessageBox.Show("Username or password is missing, please check and try again!!!",
                //"Warning",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    
        public void loginScreen()
        {
            LblUser.Visible = false;
            LblPass.Visible = false;
            TxtUser.Visible = false;
            TxtPass.Visible = false;
            LblResult.Text = "Logged in successfuly!";
            LblResult.ForeColor = Color.Green;
            BtnGo.Visible = false;
        }

    }
}
