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
    public partial class KundUppgifter : Form
    {
        public KundUppgifter()
        {
            InitializeComponent();
        }
        public string PNummer
        {
            get { return tbxPNummer.Text; }
            set { }
        }
        public string Namn
        {
            get { return tbxNamn.Text; }
            set { }
        }
        public string Adress
        {
            get { return tbxAdress.Text; }
            set { }
        }
        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            long pn;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            bool ok1 = long.TryParse(tbxPNummer.Text, out pn);
            if (!ok1)
            {
                errorProvider1.SetError(tbxPNummer, "Ange nummer bara");
            }
            else if (tbxNamn.Text == "")
            {
                
                errorProvider2.SetError(tbxNamn, "Ange bokstavs bara");
            }
            else if (tbxAdress.Text == "")
            {
                errorProvider3.SetError(tbxAdress, "Ange bokstavs bara");
            }
            else
            {
                StreamWriter kundFil = new StreamWriter("kund.txt", true, Encoding.Default);
            
                kundFil.WriteLine(tbxPNummer.Text + ";" + tbxNamn.Text + ";" + tbxAdress.Text);
            
                kundFil.Close();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
