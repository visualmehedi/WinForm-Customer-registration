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
    public partial class SokUppgifter : Form
    {

        public SokUppgifter()
        {
            InitializeComponent();
        }
        public string PNummer
        { 
            get { return tbxPNummer.Text.Trim(); }
        }
        public string Namn { get{ return lblNamn.Text.Trim(); } }
        public string Adress { get { return lblAdress.Text.Trim(); } }

        private void btnSok_Click(object sender, EventArgs e)
        {
            long pn;
            errorProvider1.Clear();
            bool ok1 = long.TryParse(tbxPNummer.Text, out pn);
            if (!ok1)
            {
                errorProvider1.SetError(tbxPNummer, "Ange nummer bara");
            }

            else
            {
                StreamReader kundFilOut = new StreamReader("kund.txt");

                string line;

                while ((line = kundFilOut.ReadLine()) != null)
                {
                    string[] words = line.Split(';');

                    if (words[0] == tbxPNummer.Text)
                    {
                        lblNamn.Text = words[1];
                        lblAdress.Text = words[2];
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
