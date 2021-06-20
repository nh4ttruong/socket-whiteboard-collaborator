﻿using System;
using System.Windows.Forms;

namespace Whiteboard
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();           
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

            string content, title;
            content = "Exit whiteboard?";
            title = "Message";
            MessageBoxButtons quitButton = MessageBoxButtons.YesNo;
            DialogResult quit = MessageBox.Show(content, title, quitButton, MessageBoxIcon.Question);
            if (quit == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Join joinForm = new Join();
            joinForm.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create createForm = new Create();
            createForm.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
