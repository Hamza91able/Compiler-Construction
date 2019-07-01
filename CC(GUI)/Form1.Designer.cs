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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WndMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codeText = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorRichTextbox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tokenText = new System.Windows.Forms.RichTextBox();
            this.btnCmpl = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LineNumberTextBox);
            this.groupBox1.Controls.Add(this.codeText);
            this.groupBox1.Location = new System.Drawing.Point(13, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code Window";
            // 
            // codeText
            // 
            this.codeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeText.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeText.Location = new System.Drawing.Point(33, 16);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(754, 460);
            this.codeText.TabIndex = 0;
            this.codeText.Text = "";
            this.codeText.SelectionChanged += new System.EventHandler(this.CodeText_SelectionChanged);
            this.codeText.VScroll += new System.EventHandler(this.CodeText_VScroll);
            this.codeText.FontChanged += new System.EventHandler(this.CodeText_FontChanged);
            this.codeText.TextChanged += new System.EventHandler(this.CodeText_TextChanged);
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
            // errorRichTextbox
            // 
            this.errorRichTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorRichTextbox.Location = new System.Drawing.Point(7, 20);
            this.errorRichTextbox.Name = "errorRichTextbox";
            this.errorRichTextbox.ReadOnly = true;
            this.errorRichTextbox.Size = new System.Drawing.Size(777, 110);
            this.errorRichTextbox.TabIndex = 0;
            this.errorRichTextbox.Text = "";
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
            this.tokenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCmpl.Size = new System.Drawing.Size(453, 121);
            this.btnCmpl.TabIndex = 3;
            this.btnCmpl.Text = "Compile";
            this.btnCmpl.UseVisualStyleBackColor = true;
            this.btnCmpl.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.OpenFileButton);
            this.groupBox4.Controls.Add(this.SaveFileButton);
            this.groupBox4.Controls.Add(this.NewFileButton);
            this.groupBox4.Location = new System.Drawing.Point(20, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 63);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.Location = new System.Drawing.Point(6, 11);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(47, 46);
            this.OpenFileButton.TabIndex = 3;
            this.OpenFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileButton.Image")));
            this.SaveFileButton.Location = new System.Drawing.Point(112, 11);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(47, 46);
            this.SaveFileButton.TabIndex = 1;
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // NewFileButton
            // 
            this.NewFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewFileButton.Image = ((System.Drawing.Image)(resources.GetObject("NewFileButton.Image")));
            this.NewFileButton.Location = new System.Drawing.Point(59, 11);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(47, 46);
            this.NewFileButton.TabIndex = 0;
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.BackColor = System.Drawing.Color.White;
            this.LineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineNumberTextBox.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.LineNumberTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.LineNumberTextBox.Location = new System.Drawing.Point(3, 16);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.ReadOnly = true;
            this.LineNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumberTextBox.Size = new System.Drawing.Size(57, 460);
            this.LineNumberTextBox.TabIndex = 1;
            this.LineNumberTextBox.Text = "";
            // 
            // WndMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 716);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCmpl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WndMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compiler Construction";
            this.Load += new System.EventHandler(this.WndMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.RichTextBox LineNumberTextBox;
    }
}

