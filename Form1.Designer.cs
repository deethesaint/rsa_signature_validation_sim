namespace RSA_Digital_Signature
{
    partial class RSADigitalSignature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSADigitalSignature));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sender_FileName_textBox = new System.Windows.Forms.TextBox();
            this.sender_FileBrowse_Button = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.sign_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Alice_Hash_Button = new System.Windows.Forms.Button();
            this.sender_Sig = new System.Windows.Forms.TextBox();
            this.sender_SHA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.receiver_FileName_textBox = new System.Windows.Forms.TextBox();
            this.receiver_FileBrowse_Button = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.receiver_SHA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bob_Hash_button = new System.Windows.Forms.Button();
            this.verify_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.receiver_Sig = new System.Windows.Forms.TextBox();
            this.keyGen_button = new System.Windows.Forms.Button();
            this.p_textBox = new System.Windows.Forms.TextBox();
            this.q_textBox = new System.Windows.Forms.TextBox();
            this.mod_textBox = new System.Windows.Forms.TextBox();
            this.e_textBox = new System.Windows.Forms.TextBox();
            this.phi_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.d_textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.priv_Param2 = new System.Windows.Forms.TextBox();
            this.priv_Param1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.public_Param2 = new System.Windows.Forms.TextBox();
            this.public_Param1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sender_FileName_textBox);
            this.groupBox1.Controls.Add(this.sender_FileBrowse_Button);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.sign_Button);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Alice_Hash_Button);
            this.groupBox1.Controls.Add(this.sender_Sig);
            this.groupBox1.Controls.Add(this.sender_SHA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alice";
            // 
            // sender_FileName_textBox
            // 
            this.sender_FileName_textBox.Location = new System.Drawing.Point(63, 68);
            this.sender_FileName_textBox.Name = "sender_FileName_textBox";
            this.sender_FileName_textBox.ReadOnly = true;
            this.sender_FileName_textBox.Size = new System.Drawing.Size(610, 22);
            this.sender_FileName_textBox.TabIndex = 7;
            // 
            // sender_FileBrowse_Button
            // 
            this.sender_FileBrowse_Button.Location = new System.Drawing.Point(679, 67);
            this.sender_FileBrowse_Button.Name = "sender_FileBrowse_Button";
            this.sender_FileBrowse_Button.Size = new System.Drawing.Size(75, 24);
            this.sender_FileBrowse_Button.TabIndex = 0;
            this.sender_FileBrowse_Button.Text = "Browse";
            this.sender_FileBrowse_Button.UseVisualStyleBackColor = true;
            this.sender_FileBrowse_Button.Click += new System.EventHandler(this.sender_FileBrowse_Button_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "File";
            // 
            // sign_Button
            // 
            this.sign_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_Button.Location = new System.Drawing.Point(910, 155);
            this.sign_Button.Name = "sign_Button";
            this.sign_Button.Size = new System.Drawing.Size(88, 39);
            this.sign_Button.TabIndex = 2;
            this.sign_Button.Text = "Sign";
            this.sign_Button.UseVisualStyleBackColor = true;
            this.sign_Button.Click += new System.EventHandler(this.sign_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signature";
            // 
            // Alice_Hash_Button
            // 
            this.Alice_Hash_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alice_Hash_Button.Location = new System.Drawing.Point(6, 155);
            this.Alice_Hash_Button.Name = "Alice_Hash_Button";
            this.Alice_Hash_Button.Size = new System.Drawing.Size(88, 39);
            this.Alice_Hash_Button.TabIndex = 1;
            this.Alice_Hash_Button.Text = "Hash";
            this.Alice_Hash_Button.UseVisualStyleBackColor = true;
            this.Alice_Hash_Button.Click += new System.EventHandler(this.Alice_Hash_Button_Click);
            // 
            // sender_Sig
            // 
            this.sender_Sig.Location = new System.Drawing.Point(618, 166);
            this.sender_Sig.Name = "sender_Sig";
            this.sender_Sig.ReadOnly = true;
            this.sender_Sig.Size = new System.Drawing.Size(286, 22);
            this.sender_Sig.TabIndex = 9;
            // 
            // sender_SHA
            // 
            this.sender_SHA.Location = new System.Drawing.Point(193, 166);
            this.sender_SHA.Name = "sender_SHA";
            this.sender_SHA.ReadOnly = true;
            this.sender_SHA.Size = new System.Drawing.Size(324, 22);
            this.sender_SHA.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "SHA-1 HASH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.receiver_FileName_textBox);
            this.groupBox2.Controls.Add(this.receiver_FileBrowse_Button);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.receiver_SHA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Bob_Hash_button);
            this.groupBox2.Controls.Add(this.verify_Button);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.receiver_Sig);
            this.groupBox2.Location = new System.Drawing.Point(12, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 218);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bob";
            // 
            // receiver_FileName_textBox
            // 
            this.receiver_FileName_textBox.Location = new System.Drawing.Point(63, 72);
            this.receiver_FileName_textBox.Name = "receiver_FileName_textBox";
            this.receiver_FileName_textBox.ReadOnly = true;
            this.receiver_FileName_textBox.Size = new System.Drawing.Size(610, 22);
            this.receiver_FileName_textBox.TabIndex = 20;
            // 
            // receiver_FileBrowse_Button
            // 
            this.receiver_FileBrowse_Button.Location = new System.Drawing.Point(679, 71);
            this.receiver_FileBrowse_Button.Name = "receiver_FileBrowse_Button";
            this.receiver_FileBrowse_Button.Size = new System.Drawing.Size(75, 24);
            this.receiver_FileBrowse_Button.TabIndex = 4;
            this.receiver_FileBrowse_Button.Text = "Browse";
            this.receiver_FileBrowse_Button.UseVisualStyleBackColor = true;
            this.receiver_FileBrowse_Button.Click += new System.EventHandler(this.receiver_FileBrowse_Button_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "File";
            // 
            // receiver_SHA
            // 
            this.receiver_SHA.Location = new System.Drawing.Point(193, 179);
            this.receiver_SHA.Name = "receiver_SHA";
            this.receiver_SHA.ReadOnly = true;
            this.receiver_SHA.Size = new System.Drawing.Size(324, 22);
            this.receiver_SHA.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "SHA-1 HASH";
            // 
            // Bob_Hash_button
            // 
            this.Bob_Hash_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bob_Hash_button.Location = new System.Drawing.Point(6, 168);
            this.Bob_Hash_button.Name = "Bob_Hash_button";
            this.Bob_Hash_button.Size = new System.Drawing.Size(88, 39);
            this.Bob_Hash_button.TabIndex = 5;
            this.Bob_Hash_button.Text = "Hash";
            this.Bob_Hash_button.UseVisualStyleBackColor = true;
            this.Bob_Hash_button.Click += new System.EventHandler(this.Bob_Hash_button_Click);
            // 
            // verify_Button
            // 
            this.verify_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify_Button.Location = new System.Drawing.Point(910, 168);
            this.verify_Button.Name = "verify_Button";
            this.verify_Button.Size = new System.Drawing.Size(88, 39);
            this.verify_Button.TabIndex = 6;
            this.verify_Button.Text = "Verify";
            this.verify_Button.UseVisualStyleBackColor = true;
            this.verify_Button.Click += new System.EventHandler(this.verify_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Signature";
            // 
            // receiver_Sig
            // 
            this.receiver_Sig.Location = new System.Drawing.Point(618, 179);
            this.receiver_Sig.Name = "receiver_Sig";
            this.receiver_Sig.ReadOnly = true;
            this.receiver_Sig.Size = new System.Drawing.Size(286, 22);
            this.receiver_Sig.TabIndex = 22;
            // 
            // keyGen_button
            // 
            this.keyGen_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyGen_button.Location = new System.Drawing.Point(18, 218);
            this.keyGen_button.Name = "keyGen_button";
            this.keyGen_button.Size = new System.Drawing.Size(98, 86);
            this.keyGen_button.TabIndex = 3;
            this.keyGen_button.Text = "512 bits key gen";
            this.keyGen_button.UseVisualStyleBackColor = true;
            this.keyGen_button.Click += new System.EventHandler(this.keyGen_button_Click);
            // 
            // p_textBox
            // 
            this.p_textBox.Location = new System.Drawing.Point(171, 225);
            this.p_textBox.Name = "p_textBox";
            this.p_textBox.ReadOnly = true;
            this.p_textBox.Size = new System.Drawing.Size(358, 22);
            this.p_textBox.TabIndex = 10;
            // 
            // q_textBox
            // 
            this.q_textBox.Location = new System.Drawing.Point(171, 253);
            this.q_textBox.Name = "q_textBox";
            this.q_textBox.ReadOnly = true;
            this.q_textBox.Size = new System.Drawing.Size(358, 22);
            this.q_textBox.TabIndex = 11;
            // 
            // mod_textBox
            // 
            this.mod_textBox.Location = new System.Drawing.Point(171, 281);
            this.mod_textBox.Name = "mod_textBox";
            this.mod_textBox.ReadOnly = true;
            this.mod_textBox.Size = new System.Drawing.Size(358, 22);
            this.mod_textBox.TabIndex = 12;
            // 
            // e_textBox
            // 
            this.e_textBox.Location = new System.Drawing.Point(171, 309);
            this.e_textBox.Name = "e_textBox";
            this.e_textBox.ReadOnly = true;
            this.e_textBox.Size = new System.Drawing.Size(358, 22);
            this.e_textBox.TabIndex = 13;
            // 
            // phi_textBox
            // 
            this.phi_textBox.Location = new System.Drawing.Point(171, 337);
            this.phi_textBox.Name = "phi_textBox";
            this.phi_textBox.ReadOnly = true;
            this.phi_textBox.Size = new System.Drawing.Size(358, 22);
            this.phi_textBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Q";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "N";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "E";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "φ(N)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "D";
            // 
            // d_textBox
            // 
            this.d_textBox.Location = new System.Drawing.Point(171, 365);
            this.d_textBox.Name = "d_textBox";
            this.d_textBox.ReadOnly = true;
            this.d_textBox.Size = new System.Drawing.Size(358, 22);
            this.d_textBox.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.priv_Param2);
            this.groupBox3.Controls.Add(this.priv_Param1);
            this.groupBox3.Location = new System.Drawing.Point(535, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 71);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Private Key";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "E";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "N";
            // 
            // priv_Param2
            // 
            this.priv_Param2.Location = new System.Drawing.Point(117, 43);
            this.priv_Param2.Name = "priv_Param2";
            this.priv_Param2.ReadOnly = true;
            this.priv_Param2.Size = new System.Drawing.Size(358, 22);
            this.priv_Param2.TabIndex = 17;
            // 
            // priv_Param1
            // 
            this.priv_Param1.Location = new System.Drawing.Point(117, 15);
            this.priv_Param1.Name = "priv_Param1";
            this.priv_Param1.ReadOnly = true;
            this.priv_Param1.Size = new System.Drawing.Size(358, 22);
            this.priv_Param1.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.public_Param2);
            this.groupBox4.Controls.Add(this.public_Param1);
            this.groupBox4.Location = new System.Drawing.Point(535, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 71);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Public Key";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "D";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "N";
            // 
            // public_Param2
            // 
            this.public_Param2.Location = new System.Drawing.Point(117, 43);
            this.public_Param2.Name = "public_Param2";
            this.public_Param2.ReadOnly = true;
            this.public_Param2.Size = new System.Drawing.Size(358, 22);
            this.public_Param2.TabIndex = 19;
            // 
            // public_Param1
            // 
            this.public_Param1.Location = new System.Drawing.Point(117, 15);
            this.public_Param1.Name = "public_Param1";
            this.public_Param1.ReadOnly = true;
            this.public_Param1.Size = new System.Drawing.Size(358, 22);
            this.public_Param1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "P";
            // 
            // RSADigitalSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 614);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.d_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phi_textBox);
            this.Controls.Add(this.e_textBox);
            this.Controls.Add(this.mod_textBox);
            this.Controls.Add(this.q_textBox);
            this.Controls.Add(this.p_textBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.keyGen_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RSADigitalSignature";
            this.Text = "RSA Digital Signature";
            this.Load += new System.EventHandler(this.RSADigitalSignature_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Alice_Hash_Button;
        private System.Windows.Forms.TextBox sender_Sig;
        private System.Windows.Forms.TextBox sender_SHA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button keyGen_button;
        private System.Windows.Forms.Button verify_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox receiver_Sig;
        private System.Windows.Forms.TextBox receiver_SHA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bob_Hash_button;
        private System.Windows.Forms.TextBox p_textBox;
        private System.Windows.Forms.TextBox q_textBox;
        private System.Windows.Forms.TextBox mod_textBox;
        private System.Windows.Forms.TextBox e_textBox;
        private System.Windows.Forms.TextBox phi_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox d_textBox;
        private System.Windows.Forms.Button sign_Button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox priv_Param2;
        private System.Windows.Forms.TextBox priv_Param1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox public_Param2;
        private System.Windows.Forms.TextBox public_Param1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sender_FileName_textBox;
        private System.Windows.Forms.Button sender_FileBrowse_Button;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox receiver_FileName_textBox;
        private System.Windows.Forms.Button receiver_FileBrowse_Button;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

