namespace CC_GUI_
{
    partial class WndMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codeText = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tokenText = new System.Windows.Forms.RichTextBox();
            this.btnCmpl = new System.Windows.Forms.Button();
            this.errorRichTextbox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codeText);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code Window";
            // 
            // codeText
            // 
            this.codeText.Location = new System.Drawing.Point(7, 20);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(777, 522);
            this.codeText.TabIndex = 0;
            this.codeText.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.errorRichTextbox);
            this.groupBox2.Location = new System.Drawing.Point(13, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Errors";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tokenText);
            this.groupBox3.Location = new System.Drawing.Point(810, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 548);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tokens";
            // 
            // tokenText
            // 
            this.tokenText.Location = new System.Drawing.Point(7, 20);
            this.tokenText.Name = "tokenText";
            this.tokenText.ReadOnly = true;
            this.tokenText.Size = new System.Drawing.Size(446, 522);
            this.tokenText.TabIndex = 0;
            this.tokenText.Text = "";
            // 
            // btnCmpl
            // 
            this.btnCmpl.Location = new System.Drawing.Point(810, 577);
            this.btnCmpl.Name = "btnCmpl";
            this.btnCmpl.Size = new System.Drawing.Size(75, 23);
            this.btnCmpl.TabIndex = 3;
            this.btnCmpl.Text = "Compile";
            this.btnCmpl.UseVisualStyleBackColor = true;
            this.btnCmpl.Click += new System.EventHandler(this.Button1_Click);
            // 
            // errorRichTextbox
            // 
            this.errorRichTextbox.Location = new System.Drawing.Point(7, 20);
            this.errorRichTextbox.Name = "errorRichTextbox";
            this.errorRichTextbox.ReadOnly = true;
            this.errorRichTextbox.Size = new System.Drawing.Size(777, 110);
            this.errorRichTextbox.TabIndex = 0;
            this.errorRichTextbox.Text = "";
            // 
            // WndMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 716);
            this.Controls.Add(this.btnCmpl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WndMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compiler Construction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox codeText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCmpl;
        private System.Windows.Forms.RichTextBox tokenText;
        private System.Windows.Forms.RichTextBox errorRichTextbox;
    }
}

