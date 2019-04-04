namespace RC4_CSharp
{
    partial class EncryptForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtKKey = new System.Windows.Forms.TextBox();
            this.txtFilePathOpen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTKey = new System.Windows.Forms.RichTextBox();
            this.txtSKey = new System.Windows.Forms.RichTextBox();
            this.txtKeySchedule = new System.Windows.Forms.RichTextBox();
            this.txtKeyStream = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKeyStreamRead = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilePathSave = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Khóa S";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lập lịch khóa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Khóa T";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(1001, 44);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(889, 43);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Mở file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtKKey
            // 
            this.txtKKey.Location = new System.Drawing.Point(202, 71);
            this.txtKKey.Name = "txtKKey";
            this.txtKKey.Size = new System.Drawing.Size(874, 22);
            this.txtKKey.TabIndex = 13;
            // 
            // txtFilePathOpen
            // 
            this.txtFilePathOpen.Location = new System.Drawing.Point(202, 44);
            this.txtFilePathOpen.Name = "txtFilePathOpen";
            this.txtFilePathOpen.Size = new System.Drawing.Size(666, 22);
            this.txtFilePathOpen.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Khóa K";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đường dẫn";
            // 
            // txtTKey
            // 
            this.txtTKey.Location = new System.Drawing.Point(90, 158);
            this.txtTKey.Name = "txtTKey";
            this.txtTKey.ReadOnly = true;
            this.txtTKey.Size = new System.Drawing.Size(208, 184);
            this.txtTKey.TabIndex = 19;
            this.txtTKey.Text = "";
            // 
            // txtSKey
            // 
            this.txtSKey.Location = new System.Drawing.Point(335, 158);
            this.txtSKey.Name = "txtSKey";
            this.txtSKey.ReadOnly = true;
            this.txtSKey.Size = new System.Drawing.Size(213, 184);
            this.txtSKey.TabIndex = 20;
            this.txtSKey.Text = "";
            // 
            // txtKeySchedule
            // 
            this.txtKeySchedule.Location = new System.Drawing.Point(585, 158);
            this.txtKeySchedule.Name = "txtKeySchedule";
            this.txtKeySchedule.ReadOnly = true;
            this.txtKeySchedule.Size = new System.Drawing.Size(229, 184);
            this.txtKeySchedule.TabIndex = 21;
            this.txtKeySchedule.Text = "";
            // 
            // txtKeyStream
            // 
            this.txtKeyStream.Location = new System.Drawing.Point(858, 158);
            this.txtKeyStream.Name = "txtKeyStream";
            this.txtKeyStream.ReadOnly = true;
            this.txtKeyStream.Size = new System.Drawing.Size(218, 184);
            this.txtKeyStream.TabIndex = 22;
            this.txtKeyStream.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(855, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dòng khóa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Dòng khóa";
            // 
            // txtKeyStreamRead
            // 
            this.txtKeyStreamRead.Location = new System.Drawing.Point(202, 377);
            this.txtKeyStreamRead.Name = "txtKeyStreamRead";
            this.txtKeyStreamRead.ReadOnly = true;
            this.txtKeyStreamRead.Size = new System.Drawing.Size(874, 22);
            this.txtKeyStreamRead.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Bản rõ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Bản mã";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Đường dẫn";
            // 
            // txtFilePathSave
            // 
            this.txtFilePathSave.Location = new System.Drawing.Point(202, 498);
            this.txtFilePathSave.Name = "txtFilePathSave";
            this.txtFilePathSave.Size = new System.Drawing.Size(666, 22);
            this.txtFilePathSave.TabIndex = 29;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(202, 419);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(874, 22);
            this.txtInput.TabIndex = 29;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(202, 458);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(874, 22);
            this.txtOutput.TabIndex = 30;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(889, 496);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 31;
            this.btnSaveFile.Text = "Lưu file";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(1001, 496);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 32;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 536);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtFilePathSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKeyStreamRead);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKeyStream);
            this.Controls.Add(this.txtKeySchedule);
            this.Controls.Add(this.txtSKey);
            this.Controls.Add(this.txtTKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtKKey);
            this.Controls.Add(this.txtFilePathOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EncryptForm";
            this.Text = "EncryptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtKKey;
        private System.Windows.Forms.TextBox txtFilePathOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtTKey;
        private System.Windows.Forms.RichTextBox txtSKey;
        private System.Windows.Forms.RichTextBox txtKeySchedule;
        private System.Windows.Forms.RichTextBox txtKeyStream;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKeyStreamRead;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilePathSave;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnEncrypt;
    }
}