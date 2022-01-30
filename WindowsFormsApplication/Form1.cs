﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Most used Properties
            // BackColor
            // BackgroundImage
            // Font
            // FormBorderStyle
            // Text
            // Name
            // Size
            // StartPosition
            // Icon
            // MaximizeBox
            // MinimizeBox

            // Events
            // Load
            // Click

            // MessageBox
            // To display a message with given text and action buttons.
            string messageTitle = "Launch";
            string messageText = "Close";
            // Can have different buttons to display
            MessageBoxButtons messageButtons = MessageBoxButtons.YesNo;
            // Can have an icon
            MessageBoxIcon messageIcon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(messageText, messageTitle, messageButtons, messageIcon);
            if (result == DialogResult.Yes)
                this.Close();

            // Button
            // Enables users to communicate with an application.

            // Properties
            // Name
            // BackColor
            // ForeColor
            // Font
            // Image
            // ImageAlign
            // Text
            // TextAlign
            // Enabled
            // Visible
            // Anchor
            // Dock
            // Location
            // Size
            // MaximumSize
            // MinimumSize
            // TabIndex

            // Events
            // Click
            // KeyPress

            // Label
            // To display text and information
            // Similar properties like button.

            // Textbox
            // To get input from users.
            // For bigger paragraphs use RichTextBox.
            // Similar properties like button.
            // Multiline
            // PasswordChar
            // ReadOnly
            
            // Events
            // KeyPress

            // GroupBox
            // To categorize related controls
            // Similar properties like button.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
            this.label1.Text = "Changed";
            this.label1.BackColor = Color.Red;
            this.label1.Text = this.textBox1.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits and '.'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
