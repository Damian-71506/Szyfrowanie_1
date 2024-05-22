namespace Szyfrowanie_1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.ivBox = new System.Windows.Forms.TextBox();
            this.ivLabel = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.asciiBox = new System.Windows.Forms.TextBox();
            this.plaintextBox = new System.Windows.Forms.Label();
            this.asciiLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.hexBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.asciiBox2 = new System.Windows.Forms.TextBox();
            this.hexBox2 = new System.Windows.Forms.TextBox();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.asciiLabel2 = new System.Windows.Forms.Label();
            this.hexLabel2 = new System.Windows.Forms.Label();
            this.encryptTimeButton = new System.Windows.Forms.Button();
            this.decryptTimeButton = new System.Windows.Forms.Button();
            this.encryptTimeLabel = new System.Windows.Forms.Label();
            this.decryptionTimeLabel = new System.Windows.Forms.Label();
            this.encryptTimeBox = new System.Windows.Forms.TextBox();
            this.decryptTimeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aes",
            "DES",
            "RC2",
            "Rijndael",
            "TripleDES"});
            this.comboBox1.Location = new System.Drawing.Point(32, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(32, 75);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(121, 23);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate Key and IV";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(253, 38);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(264, 20);
            this.keyBox.TabIndex = 2;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(258, 22);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 3;
            this.keyLabel.Text = "Key";
            // 
            // ivBox
            // 
            this.ivBox.Location = new System.Drawing.Point(253, 78);
            this.ivBox.Name = "ivBox";
            this.ivBox.Size = new System.Drawing.Size(264, 20);
            this.ivBox.TabIndex = 4;
            // 
            // ivLabel
            // 
            this.ivLabel.AutoSize = true;
            this.ivLabel.Location = new System.Drawing.Point(258, 62);
            this.ivLabel.Name = "ivLabel";
            this.ivLabel.Size = new System.Drawing.Size(17, 13);
            this.ivLabel.TabIndex = 5;
            this.ivLabel.Text = "IV";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(32, 137);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(121, 23);
            this.encryptButton.TabIndex = 6;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // asciiBox
            // 
            this.asciiBox.Location = new System.Drawing.Point(253, 139);
            this.asciiBox.Name = "asciiBox";
            this.asciiBox.Size = new System.Drawing.Size(264, 20);
            this.asciiBox.TabIndex = 7;
            // 
            // plaintextBox
            // 
            this.plaintextBox.AutoSize = true;
            this.plaintextBox.Location = new System.Drawing.Point(258, 123);
            this.plaintextBox.Name = "plaintextBox";
            this.plaintextBox.Size = new System.Drawing.Size(54, 13);
            this.plaintextBox.TabIndex = 8;
            this.plaintextBox.Text = "Plain Text";
            // 
            // asciiLabel
            // 
            this.asciiLabel.AutoSize = true;
            this.asciiLabel.Location = new System.Drawing.Point(213, 142);
            this.asciiLabel.Name = "asciiLabel";
            this.asciiLabel.Size = new System.Drawing.Size(34, 13);
            this.asciiLabel.TabIndex = 9;
            this.asciiLabel.Text = "ASCII";
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(218, 173);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(29, 13);
            this.hexLabel.TabIndex = 10;
            this.hexLabel.Text = "HEX";
            // 
            // hexBox
            // 
            this.hexBox.Location = new System.Drawing.Point(253, 170);
            this.hexBox.Name = "hexBox";
            this.hexBox.Size = new System.Drawing.Size(264, 20);
            this.hexBox.TabIndex = 11;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(32, 248);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(121, 23);
            this.decryptButton.TabIndex = 12;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // asciiBox2
            // 
            this.asciiBox2.Location = new System.Drawing.Point(253, 251);
            this.asciiBox2.Name = "asciiBox2";
            this.asciiBox2.Size = new System.Drawing.Size(254, 20);
            this.asciiBox2.TabIndex = 13;
            // 
            // hexBox2
            // 
            this.hexBox2.Location = new System.Drawing.Point(253, 284);
            this.hexBox2.Name = "hexBox2";
            this.hexBox2.Size = new System.Drawing.Size(254, 20);
            this.hexBox2.TabIndex = 14;
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.AutoSize = true;
            this.cipherTextLabel.Location = new System.Drawing.Point(258, 235);
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.Size = new System.Drawing.Size(61, 13);
            this.cipherTextLabel.TabIndex = 15;
            this.cipherTextLabel.Text = "Cipher Text";
            // 
            // asciiLabel2
            // 
            this.asciiLabel2.AutoSize = true;
            this.asciiLabel2.Location = new System.Drawing.Point(213, 254);
            this.asciiLabel2.Name = "asciiLabel2";
            this.asciiLabel2.Size = new System.Drawing.Size(34, 13);
            this.asciiLabel2.TabIndex = 16;
            this.asciiLabel2.Text = "ASCII";
            // 
            // hexLabel2
            // 
            this.hexLabel2.AutoSize = true;
            this.hexLabel2.Location = new System.Drawing.Point(218, 287);
            this.hexLabel2.Name = "hexLabel2";
            this.hexLabel2.Size = new System.Drawing.Size(29, 13);
            this.hexLabel2.TabIndex = 17;
            this.hexLabel2.Text = "HEX";
            // 
            // encryptTimeButton
            // 
            this.encryptTimeButton.Location = new System.Drawing.Point(32, 347);
            this.encryptTimeButton.Name = "encryptTimeButton";
            this.encryptTimeButton.Size = new System.Drawing.Size(121, 23);
            this.encryptTimeButton.TabIndex = 18;
            this.encryptTimeButton.Text = "Get Encrypt Time";
            this.encryptTimeButton.UseVisualStyleBackColor = true;
            this.encryptTimeButton.Click += new System.EventHandler(this.encryptTimeButton_Click);
            // 
            // decryptTimeButton
            // 
            this.decryptTimeButton.Location = new System.Drawing.Point(32, 399);
            this.decryptTimeButton.Name = "decryptTimeButton";
            this.decryptTimeButton.Size = new System.Drawing.Size(121, 23);
            this.decryptTimeButton.TabIndex = 19;
            this.decryptTimeButton.Text = "Get Decrypt Time";
            this.decryptTimeButton.UseVisualStyleBackColor = true;
            this.decryptTimeButton.Click += new System.EventHandler(this.decryptTimeButton_Click);
            // 
            // encryptTimeLabel
            // 
            this.encryptTimeLabel.AutoSize = true;
            this.encryptTimeLabel.Location = new System.Drawing.Point(250, 352);
            this.encryptTimeLabel.Name = "encryptTimeLabel";
            this.encryptTimeLabel.Size = new System.Drawing.Size(141, 13);
            this.encryptTimeLabel.TabIndex = 20;
            this.encryptTimeLabel.Text = "Time/message at encyption:";
            // 
            // decryptionTimeLabel
            // 
            this.decryptionTimeLabel.AutoSize = true;
            this.decryptionTimeLabel.Location = new System.Drawing.Point(250, 404);
            this.decryptionTimeLabel.Name = "decryptionTimeLabel";
            this.decryptionTimeLabel.Size = new System.Drawing.Size(144, 13);
            this.decryptionTimeLabel.TabIndex = 21;
            this.decryptionTimeLabel.Text = "Time/message at decryption:";
            // 
            // encryptTimeBox
            // 
            this.encryptTimeBox.Location = new System.Drawing.Point(398, 349);
            this.encryptTimeBox.Name = "encryptTimeBox";
            this.encryptTimeBox.Size = new System.Drawing.Size(100, 20);
            this.encryptTimeBox.TabIndex = 22;
            // 
            // decryptTimeBox
            // 
            this.decryptTimeBox.Location = new System.Drawing.Point(398, 401);
            this.decryptTimeBox.Name = "decryptTimeBox";
            this.decryptTimeBox.Size = new System.Drawing.Size(100, 20);
            this.decryptTimeBox.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 561);
            this.Controls.Add(this.decryptTimeBox);
            this.Controls.Add(this.encryptTimeBox);
            this.Controls.Add(this.decryptionTimeLabel);
            this.Controls.Add(this.encryptTimeLabel);
            this.Controls.Add(this.decryptTimeButton);
            this.Controls.Add(this.encryptTimeButton);
            this.Controls.Add(this.hexLabel2);
            this.Controls.Add(this.asciiLabel2);
            this.Controls.Add(this.cipherTextLabel);
            this.Controls.Add(this.hexBox2);
            this.Controls.Add(this.asciiBox2);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.asciiLabel);
            this.Controls.Add(this.plaintextBox);
            this.Controls.Add(this.asciiBox);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.ivLabel);
            this.Controls.Add(this.ivBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "AlgorytmySzyfrowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox ivBox;
        private System.Windows.Forms.Label ivLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox asciiBox;
        private System.Windows.Forms.Label plaintextBox;
        private System.Windows.Forms.Label asciiLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.TextBox hexBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox asciiBox2;
        private System.Windows.Forms.TextBox hexBox2;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.Label asciiLabel2;
        private System.Windows.Forms.Label hexLabel2;
        private System.Windows.Forms.Button encryptTimeButton;
        private System.Windows.Forms.Button decryptTimeButton;
        private System.Windows.Forms.Label encryptTimeLabel;
        private System.Windows.Forms.Label decryptionTimeLabel;
        private System.Windows.Forms.TextBox encryptTimeBox;
        private System.Windows.Forms.TextBox decryptTimeBox;
    }
}

