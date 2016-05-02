using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kundregister
{
    public partial class KundRegister : Form
    {
        public KundRegister()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnNew_Click(object sender, EventArgs e)
        {
            KundUppgifter dialog = new KundUppgifter();
            dialog.Show();    
        }

        public void btnSok_Click(object sender, EventArgs e)
        {
            SokUppgifter sokDialog = new SokUppgifter();
            sokDialog.Show();
        }        
    }
}