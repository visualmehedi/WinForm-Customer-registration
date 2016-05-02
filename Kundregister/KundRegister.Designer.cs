namespace Kundregister
{
    partial class KundRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundRegister));
            this.btnNew = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.btnSok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNew.Location = new System.Drawing.Point(84, 108);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 44);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Ny Kund";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(544, 108);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Avsluta";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(321, 108);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(151, 44);
            this.btnSok.TabIndex = 1;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.btnSok_Click);
            // 
            // KundRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 229);
            this.Controls.Add(this.btnSok);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.btnNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KundRegister";
            this.Text = "KundRegister";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button btnSok;
    }
}

