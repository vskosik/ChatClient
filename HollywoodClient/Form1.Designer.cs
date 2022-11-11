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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btUload);
            this.tabPage1.Controls.Add(this.tbFiles);
            this.tabPage1.Controls.Add(this.btSelect);
            this.tabPage1.Controls.Add(this.cbMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btUload
            // 
            this.btUload.Location = new System.Drawing.Point(46, 143);
            this.btUload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUload.Name = "btUload";
            this.btUload.Size = new System.Drawing.Size(107, 38);
            this.btUload.TabIndex = 7;
            this.btUload.Text = "Upload";
            this.btUload.UseVisualStyleBackColor = true;
            this.btUload.Click += new System.EventHandler(this.btUload_Click);
            // 
            // tbFiles
            // 
            this.tbFiles.Location = new System.Drawing.Point(161, 96);
            this.tbFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.Size = new System.Drawing.Size(571, 31);
            this.tbFiles.TabIndex = 6;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(46, 95);
            this.btSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(107, 38);
            this.btSelect.TabIndex = 5;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // cbMovies
            // 
            this.cbMovies.FormattingEnabled = true;
            this.cbMovies.Location = new System.Drawing.Point(46, 45);
            this.cbMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(688, 33);
            this.cbMovies.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
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
    }
}
