using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantUI
{
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            InitializeComponent();
        }
        public void AllPanelClose()
        {
            home_panel.Visible = false;
            menu_panel.Visible = false;
            contact_panel.Visible = false;
            login_panel.Visible = false;
           // signUp_panel.Visible = false;
            bengali_panel.Visible = false;
            indian_panel.Visible = false;
            continental_panel.Visible = false;
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            AllPanelClose();
            home_panel.Visible = true;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            AllPanelClose();
            menu_panel.Visible = true;

        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            AllPanelClose();
            contact_panel.Visible = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            AllPanelClose();
            login_panel.Visible = true;

        }

        private void BengaliButton_Click(object sender, EventArgs e)
        {
            AllPanelClose();
            menu_panel.Visible = true;
            bengali_panel.Visible = true;
        }

        private void IndianButton_Click(object sender, EventArgs e)
        {
            AllPanelClose();
            menu_panel.Visible = true;
            indian_panel.Visible = true;
        }

        private void ContinentalButton_Click(object sender, EventArgs e)
        {
            AllPanelClose();
            menu_panel.Visible = true;
            continental_panel.Visible = true;
        }

        private void SignUp2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" SIGN UP SUCCESSFUL");
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOG IN SUCCESSFUL");
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            AllPanelClose();
           // signUp_panel.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

     
    }
}
