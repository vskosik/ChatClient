namespace HollywoodClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btUload = new System.Windows.Forms.Button();
            this.tbFiles = new System.Windows.Forms.TextBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.cbMovies = new System.Windows.Forms.ComboBox();
            this.btDisplay = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 233);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btDisplay);
            this.tabPage1.Controls.Add(this.btUload);
            this.tabPage1.Controls.Add(this.tbFiles);
            this.tabPage1.Controls.Add(this.btSelect);
            this.tabPage1.Controls.Add(this.cbMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(465, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btUload
            // 
            this.btUload.Location = new System.Drawing.Point(28, 74);
            this.btUload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btUload.Name = "btUload";
            this.btUload.Size = new System.Drawing.Size(64, 20);
            this.btUload.TabIndex = 7;
            this.btUload.Text = "Upload";
            this.btUload.UseVisualStyleBackColor = true;
            this.btUload.Click += new System.EventHandler(this.btUload_Click);
            // 
            // tbFiles
            // 
            this.tbFiles.Location = new System.Drawing.Point(97, 50);
            this.tbFiles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.Size = new System.Drawing.Size(344, 22);
            this.tbFiles.TabIndex = 6;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(28, 49);
            this.btSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(64, 20);
            this.btSelect.TabIndex = 5;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // cbMovies
            // 
            this.cbMovies.FormattingEnabled = true;
            this.cbMovies.Location = new System.Drawing.Point(28, 23);
            this.cbMovies.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(414, 21);
            this.cbMovies.TabIndex = 4;
            // 
            // btDisplay
            // 
            this.btDisplay.Location = new System.Drawing.Point(28, 100);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(64, 23);
            this.btDisplay.TabIndex = 1;
            this.btDisplay.Text = "Display";
            this.btDisplay.UseVisualStyleBackColor = true;
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 234);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btUload;
        private System.Windows.Forms.TextBox tbFiles;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.ComboBox cbMovies;
        private System.Windows.Forms.Button btDisplay;
    }
}
