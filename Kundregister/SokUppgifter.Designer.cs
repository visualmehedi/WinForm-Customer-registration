namespace Kundregister
{
    partial class SokUppgifter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SokUppgifter));
            this.btnSok = new System.Windows.Forms.Button();
            this.lblPNummer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.tbxPNummer = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(515, 89);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(105, 41);
            this.btnSok.TabIndex = 0;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.btnSok_Click);
            // 
            // lblPNummer
            // 
            this.lblPNummer.AutoSize = true;
            this.lblPNummer.Location = new System.Drawing.Point(100, 47);
            this.lblPNummer.Name = "lblPNummer";
            this.lblPNummer.Size = new System.Drawing.Size(211, 25);
            this.lblPNummer.TabIndex = 1;
            this.lblPNummer.Text = "Ange personnummer";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(100, 186);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Namn";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(100, 229);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(0, 25);
            this.lblNamn.TabIndex = 3;
            this.lblNamn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(100, 315);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(79, 25);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Adress";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(100, 359);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(0, 25);
            this.lblAdress.TabIndex = 5;
            // 
            // tbxPNummer
            // 
            this.tbxPNummer.Location = new System.Drawing.Point(105, 89);
            this.tbxPNummer.Name = "tbxPNummer";
            this.tbxPNummer.Size = new System.Drawing.Size(226, 31);
            this.tbxPNummer.TabIndex = 6;
            this.tbxPNummer.Text = " ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(515, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 41);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Stäng!";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SokUppgifter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 464);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxPNummer);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPNummer);
            this.Controls.Add(this.btnSok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SokUppgifter";
            this.Text = "Sök";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.Label lblPNummer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox tbxPNummer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
    }
}