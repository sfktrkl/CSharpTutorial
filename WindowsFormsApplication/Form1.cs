using System;
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
        }
    }
}
