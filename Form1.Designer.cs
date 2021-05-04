namespace BeaufortCipher 
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kodi i gjeneruar nga Windows Forms Designer
            
        //Dizajni i jashtem i programmit
        private void KomponentaIncializuese_interfaceit()
        {
            this.hapesiraperplaintext = new System.Windows.Forms.TextBox();
            this.hapesirapercelestext = new System.Windows.Forms.TextBox();
            this.hapesiraperciphertext = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();  
            this.butonienkriptimit = new System.Windows.Forms.Button();
            this.butonidekriptimit = new System.Windows.Forms.Button();
            this.butonifshirjes = new System.Windows.Forms.Button();
            this.butoniinformatave = new System.Windows.Forms.Button();
            this.SuspendLayout();
          
            // Hapesira e tekstit per plaintext
            this.hapesiraperplaintext.Location = new System.Drawing.Point(12, 25);
            this.hapesiraperplaintext.Multiline = true;
            this.hapesiraperplaintext.Name = "hapesiraperplaintext";
            this.hapesiraperplaintext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hapesiraperplaintext.Size = new System.Drawing.Size(309, 40);
            this.hapesiraperplaintext.TabIndex = 2;
            this.hapesiraperplaintext.TextChanged += new System.EventHandler(this.hapesiraperplaintext_ngjyra);
         
            // Hapesira e tekstit per celes
            this.hapesirapercelestext.Location = new System.Drawing.Point(12, 104);
            this.hapesirapercelestext.Multiline = true;
            this.hapesirapercelestext.Name = "hapesirapercelestext";
            this.hapesirapercelestext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hapesirapercelestext.Size = new System.Drawing.Size(309, 40);
            this.hapesirapercelestext.TabIndex = 3;
            this.hapesirapercelestext.TextChanged += new System.EventHandler(this.hapesirapercelestext_ngjyra);
            
            // Hapesira e tekstit per ciphertext
            this.hapesiraperciphertext.Location = new System.Drawing.Point(12, 183);
            this.hapesiraperciphertext.Multiline = true;
            this.hapesiraperciphertext.Name = "hapesiraperciphertext";
            this.hapesiraperciphertext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hapesiraperciphertext.Size = new System.Drawing.Size(309, 40);
            this.hapesiraperciphertext.TabIndex = 6;
            this.hapesiraperciphertext.TextChanged += new System.EventHandler(this.hapesiraperciphertext_ngjyra);
           
            // Label e fontit te tekstit-Label0  
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label0.Location = new System.Drawing.Point(-117, 440);
            this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(17, 17);
            this.label0.TabIndex = 442;
            this.label0.Text = "S";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // Label e Plaintext-Label1  
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 13);
            this.label1.TabIndex = 443;
            this.label1.Text = "Plaintext:";
             
            // Label e Çelesi-Label2 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 444;
            this.label2.Text = "Çelesi:";

            // Label e Ciphertext-Label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 445;
            this.label3.Text = "Ciphertext:";
            
            // Butoni i enkriptimit
            this.butonienkriptimit.Location = new System.Drawing.Point(12, 250);
            this.butonienkriptimit.Name = "butonienkriptimit";
            this.butonienkriptimit.Size = new System.Drawing.Size(151, 38);
            this.butonienkriptimit.TabIndex = 5;
            this.butonienkriptimit.Text = "Enkriptimi";
            this.butonienkriptimit.UseVisualStyleBackColor = true;
            this.butonienkriptimit.Click += new System.EventHandler(this.butonienkriptimit_);

            // Buttoni i dekriptimit
            this.butonidekriptimit.Location = new System.Drawing.Point(170, 250);
            this.butonidekriptimit.Name = "butonidekriptimit";
            this.butonidekriptimit.Size = new System.Drawing.Size(151, 38);
            this.butonidekriptimit.TabIndex = 1;
            this.butonidekriptimit.Text = "Dekriptimi";
            this.butonidekriptimit.UseVisualStyleBackColor = true;
            this.butonidekriptimit.Click += new System.EventHandler(this.butonidekriptimit_);
          
            // Butoni i fshirjes se te dhenave  
            this.butonifshirjes.Location = new System.Drawing.Point(12, 294);
            this.butonifshirjes.Name = "butonifshirjes";
            this.butonifshirjes.Size = new System.Drawing.Size(151, 38);
            this.butonifshirjes.TabIndex = 454;
            this.butonifshirjes.Text = "Fshij";
            this.butonifshirjes.UseVisualStyleBackColor = true;
            this.butonifshirjes.Click += new System.EventHandler(this.butonifshirjes_);
            
            // Butoni i informatave 
            this.butoniinformatave.Location = new System.Drawing.Point(170, 294);
            this.butoniinformatave.Name = "butoniinformatave";
            this.butoniinformatave.Size = new System.Drawing.Size(151, 38);
            this.butoniinformatave.TabIndex = 455;
            this.butoniinformatave.Text = "Info";
            this.butoniinformatave.UseVisualStyleBackColor = true;
            this.butoniinformatave.Click += new System.EventHandler(this.butoniinformatave_);
            
            // Forma e pjeseve te krijuara-Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.hapesiraperplaintext);
            this.Controls.Add(this.hapesirapercelestext);
            this.Controls.Add(this.hapesiraperciphertext);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butonienkriptimit);
            this.Controls.Add(this.butonidekriptimit);
            this.Controls.Add(this.butonifshirjes);
            this.Controls.Add(this.butoniinformatave);
            this.Name = "Form1";
            this.Text = "Beaufort Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox hapesiraperplaintext;
        private System.Windows.Forms.TextBox hapesirapercelestext;
        private System.Windows.Forms.TextBox hapesiraperciphertext;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butonienkriptimit;
        private System.Windows.Forms.Button butonidekriptimit;
        private System.Windows.Forms.Button butonifshirjes;
        private System.Windows.Forms.Button butoniinformatave;
           
        
    }
}
