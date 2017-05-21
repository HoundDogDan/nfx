/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2017 ITAdapter Corp. Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/
namespace WinFormsTest
{
    partial class MailForm
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
      this.lblFROMName = new System.Windows.Forms.Label();
      this.lblFROMAddress = new System.Windows.Forms.Label();
      this.tbFROMName = new System.Windows.Forms.TextBox();
      this.tbFROMAddress = new System.Windows.Forms.TextBox();
      this.tbTOAddress = new System.Windows.Forms.TextBox();
      this.tbTOName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbSubject = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbBody = new System.Windows.Forms.TextBox();
      this.btSend = new System.Windows.Forms.Button();
      this.tbHTML = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblFROMName
      // 
      this.lblFROMName.AutoSize = true;
      this.lblFROMName.Location = new System.Drawing.Point(13, 13);
      this.lblFROMName.Name = "lblFROMName";
      this.lblFROMName.Size = new System.Drawing.Size(64, 13);
      this.lblFROMName.TabIndex = 0;
      this.lblFROMName.Text = "From Name:";
      // 
      // lblFROMAddress
      // 
      this.lblFROMAddress.AutoSize = true;
      this.lblFROMAddress.Location = new System.Drawing.Point(13, 37);
      this.lblFROMAddress.Name = "lblFROMAddress";
      this.lblFROMAddress.Size = new System.Drawing.Size(74, 13);
      this.lblFROMAddress.TabIndex = 1;
      this.lblFROMAddress.Text = "From Address:";
      // 
      // tbFROMName
      // 
      this.tbFROMName.Location = new System.Drawing.Point(93, 10);
      this.tbFROMName.Name = "tbFROMName";
      this.tbFROMName.Size = new System.Drawing.Size(125, 20);
      this.tbFROMName.TabIndex = 2;
      // 
      // tbFROMAddress
      // 
      this.tbFROMAddress.Location = new System.Drawing.Point(93, 34);
      this.tbFROMAddress.Name = "tbFROMAddress";
      this.tbFROMAddress.Size = new System.Drawing.Size(125, 20);
      this.tbFROMAddress.TabIndex = 3;
      // 
      // tbTOAddress
      // 
      this.tbTOAddress.Location = new System.Drawing.Point(305, 33);
      this.tbTOAddress.Name = "tbTOAddress";
      this.tbTOAddress.Size = new System.Drawing.Size(167, 20);
      this.tbTOAddress.TabIndex = 7;
      // 
      // tbTOName
      // 
      this.tbTOName.Location = new System.Drawing.Point(305, 9);
      this.tbTOName.Name = "tbTOName";
      this.tbTOName.Size = new System.Drawing.Size(167, 20);
      this.tbTOName.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(235, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "To Address:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(235, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "To Name:";
      // 
      // tbSubject
      // 
      this.tbSubject.Location = new System.Drawing.Point(93, 64);
      this.tbSubject.Name = "tbSubject";
      this.tbSubject.Size = new System.Drawing.Size(215, 20);
      this.tbSubject.TabIndex = 9;
      this.tbSubject.Text = "Test";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 67);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Subject:";
      // 
      // tbBody
      // 
      this.tbBody.Location = new System.Drawing.Point(16, 102);
      this.tbBody.Multiline = true;
      this.tbBody.Name = "tbBody";
      this.tbBody.Size = new System.Drawing.Size(605, 148);
      this.tbBody.TabIndex = 10;
      this.tbBody.Text = "Test";
      // 
      // btSend
      // 
      this.btSend.Location = new System.Drawing.Point(521, 5);
      this.btSend.Name = "btSend";
      this.btSend.Size = new System.Drawing.Size(100, 44);
      this.btSend.TabIndex = 11;
      this.btSend.Text = "Send";
      this.btSend.UseVisualStyleBackColor = true;
      this.btSend.Click += new System.EventHandler(this.btSend_Click);
      // 
      // tbHTML
      // 
      this.tbHTML.Location = new System.Drawing.Point(16, 270);
      this.tbHTML.Multiline = true;
      this.tbHTML.Name = "tbHTML";
      this.tbHTML.Size = new System.Drawing.Size(605, 148);
      this.tbHTML.TabIndex = 12;
      this.tbHTML.Text = "<html>\r\n<body>\r\n<h1>Header</h1>\r\n<p>Test Message</p>\r\n</body>\r\n</html>";
      // 
      // MailForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(640, 464);
      this.Controls.Add(this.tbHTML);
      this.Controls.Add(this.btSend);
      this.Controls.Add(this.tbBody);
      this.Controls.Add(this.tbSubject);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tbTOAddress);
      this.Controls.Add(this.tbTOName);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbFROMAddress);
      this.Controls.Add(this.tbFROMName);
      this.Controls.Add(this.lblFROMAddress);
      this.Controls.Add(this.lblFROMName);
      this.Name = "MailForm";
      this.Text = "MailForm";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFROMName;
        private System.Windows.Forms.Label lblFROMAddress;
        private System.Windows.Forms.TextBox tbFROMName;
        private System.Windows.Forms.TextBox tbFROMAddress;
        private System.Windows.Forms.TextBox tbTOAddress;
        private System.Windows.Forms.TextBox tbTOName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbHTML;
  }
}