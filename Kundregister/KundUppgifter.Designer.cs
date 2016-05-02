namespace Kundregister
{
    partial class KundUppgifter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundUppgifter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPNumber = new System.Windows.Forms.Label();
            this.tbxPNummer = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adress";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(417, 137);
            this.tbxNamn.Margin = new System.Windows.Forms.Padding(6);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(196, 31);
            this.tbxNamn.TabIndex = 3;
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(316, 206);
            this.tbxAdress.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(297, 31);
            this.tbxAdress.TabIndex = 5;
            // 
            // btnLoad
            // 
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLoad.Location = new System.Drawing.Point(109, 285);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 44);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Ok";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(393, 285);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 44);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPNumber
            // 
            this.lblPNumber.AutoSize = true;
            this.lblPNumber.Location = new System.Drawing.Point(104, 66);
            this.lblPNumber.Name = "lblPNumber";
            this.lblPNumber.Size = new System.Drawing.Size(157, 25);
            this.lblPNumber.TabIndex = 0;
            this.lblPNumber.Text = "Personnummer";
            // 
            // tbxPNummer
            // 
            this.tbxPNummer.Location = new System.Drawing.Point(417, 60);
            this.tbxPNummer.Name = "tbxPNummer";
            this.tbxPNummer.Size = new System.Drawing.Size(196, 31);
            this.tbxPNummer.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // KundUppgifter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 367);
            this.Controls.Add(this.tbxPNummer);
            this.Controls.Add(this.lblPNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KundUppgifter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KundUppgifter";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPNumber;
        private System.Windows.Forms.TextBox tbxPNummer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}