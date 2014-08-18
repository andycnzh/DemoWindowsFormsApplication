using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoWindowsFormsApplication
{
    public partial class fmMain : Form
    {
        Test t = new Test();

        public fmMain()
        {
            InitializeComponent();

            t.UpdateMessageEvent += UpdateMessage;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            UpdateMessage("Click button");

            t.A();
        }

        private void UpdateMessage(string message)
        {
            txtMessage.Text += Environment.NewLine + message;
        }
    }
}
