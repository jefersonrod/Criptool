namespace Criptool
{
    partial class CriptForm1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btClearCryptTab = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEncrypted = new System.Windows.Forms.TextBox();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.tbSalt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStrToEncrypt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btClearEncodeTab = new System.Windows.Forms.Button();
            this.btEncode = new System.Windows.Forms.Button();
            this.tbASCIICodes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStrToEncode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btDecode = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(455, 186);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btClearCryptTab);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbEncrypted);
            this.tabPage1.Controls.Add(this.btDecrypt);
            this.tabPage1.Controls.Add(this.btEncrypt);
            this.tabPage1.Controls.Add(this.tbSalt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbStrToEncrypt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(447, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt/Decrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btClearCryptTab
            // 
            this.btClearCryptTab.Location = new System.Drawing.Point(246, 79);
            this.btClearCryptTab.Name = "btClearCryptTab";
            this.btClearCryptTab.Size = new System.Drawing.Size(75, 23);
            this.btClearCryptTab.TabIndex = 8;
            this.btClearCryptTab.Text = "Clear All";
            this.btClearCryptTab.UseVisualStyleBackColor = true;
            this.btClearCryptTab.Click += new System.EventHandler(this.btClearAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encrypted";
            // 
            // tbEncrypted
            // 
            this.tbEncrypted.Location = new System.Drawing.Point(131, 120);
            this.tbEncrypted.Name = "tbEncrypted";
            this.tbEncrypted.Size = new System.Drawing.Size(298, 20);
            this.tbEncrypted.TabIndex = 6;
            // 
            // btDecrypt
            // 
            this.btDecrypt.Location = new System.Drawing.Point(354, 79);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btDecrypt.TabIndex = 5;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // btEncrypt
            // 
            this.btEncrypt.Location = new System.Drawing.Point(131, 79);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btEncrypt.TabIndex = 4;
            this.btEncrypt.Text = "Encrypt";
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // tbSalt
            // 
            this.tbSalt.Location = new System.Drawing.Point(131, 39);
            this.tbSalt.Name = "tbSalt";
            this.tbSalt.Size = new System.Drawing.Size(298, 20);
            this.tbSalt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String to encrypt";
            // 
            // tbStrToEncrypt
            // 
            this.tbStrToEncrypt.Location = new System.Drawing.Point(131, 7);
            this.tbStrToEncrypt.Name = "tbStrToEncrypt";
            this.tbStrToEncrypt.Size = new System.Drawing.Size(298, 20);
            this.tbStrToEncrypt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btDecode);
            this.tabPage2.Controls.Add(this.btClearEncodeTab);
            this.tabPage2.Controls.Add(this.btEncode);
            this.tabPage2.Controls.Add(this.tbASCIICodes);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbStrToEncode);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(447, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encode ASCII";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btClearEncodeTab
            // 
            this.btClearEncodeTab.Location = new System.Drawing.Point(235, 59);
            this.btClearEncodeTab.Name = "btClearEncodeTab";
            this.btClearEncodeTab.Size = new System.Drawing.Size(75, 23);
            this.btClearEncodeTab.TabIndex = 5;
            this.btClearEncodeTab.Text = "Clear All";
            this.btClearEncodeTab.UseVisualStyleBackColor = true;
            this.btClearEncodeTab.Click += new System.EventHandler(this.btClearEncodeTab_Click);
            // 
            // btEncode
            // 
            this.btEncode.Location = new System.Drawing.Point(128, 59);
            this.btEncode.Name = "btEncode";
            this.btEncode.Size = new System.Drawing.Size(75, 23);
            this.btEncode.TabIndex = 4;
            this.btEncode.Text = "Encode";
            this.btEncode.UseVisualStyleBackColor = true;
            this.btEncode.Click += new System.EventHandler(this.btEncode_Click);
            // 
            // tbASCIICodes
            // 
            this.tbASCIICodes.Location = new System.Drawing.Point(128, 108);
            this.tbASCIICodes.Name = "tbASCIICodes";
            this.tbASCIICodes.Size = new System.Drawing.Size(291, 20);
            this.tbASCIICodes.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ASCII Code";
            // 
            // tbStrToEncode
            // 
            this.tbStrToEncode.Location = new System.Drawing.Point(128, 18);
            this.tbStrToEncode.Name = "tbStrToEncode";
            this.tbStrToEncode.Size = new System.Drawing.Size(291, 20);
            this.tbStrToEncode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "String to encode";
            // 
            // btDecode
            // 
            this.btDecode.Location = new System.Drawing.Point(344, 59);
            this.btDecode.Name = "btDecode";
            this.btDecode.Size = new System.Drawing.Size(75, 23);
            this.btDecode.TabIndex = 6;
            this.btDecode.Text = "Decode";
            this.btDecode.UseVisualStyleBackColor = true;
            this.btDecode.Click += new System.EventHandler(this.btDecode_Click);
            // 
            // CriptForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 207);
            this.Controls.Add(this.tabControl1);
            this.Name = "CriptForm1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btEncode;
        private System.Windows.Forms.TextBox tbASCIICodes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStrToEncode;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbEncrypted;
        public System.Windows.Forms.TextBox tbSalt;
        public System.Windows.Forms.TextBox tbStrToEncrypt;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btClearCryptTab;
        private System.Windows.Forms.Button btClearEncodeTab;
        private System.Windows.Forms.Button btDecode;
    }
}

