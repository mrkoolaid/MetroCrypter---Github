namespace MetroCrypter.Forms
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.button1 = new System.Windows.Forms.Button();
            this.Filename = new MetroFramework.Controls.MetroTextBox();
            this.Folder = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Source Code Pro Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 31);
            this.button1.TabIndex = 30;
            this.button1.TabStop = false;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filename
            // 
            // 
            // 
            // 
            this.Filename.CustomButton.Image = null;
            this.Filename.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.Filename.CustomButton.Name = "";
            this.Filename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Filename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Filename.CustomButton.TabIndex = 1;
            this.Filename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Filename.CustomButton.UseSelectable = true;
            this.Filename.CustomButton.Visible = false;
            this.Filename.Lines = new string[0];
            this.Filename.Location = new System.Drawing.Point(26, 50);
            this.Filename.MaxLength = 32767;
            this.Filename.Name = "Filename";
            this.Filename.PasswordChar = '\0';
            this.Filename.PromptText = "File Name";
            this.Filename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Filename.SelectedText = "";
            this.Filename.SelectionLength = 0;
            this.Filename.SelectionStart = 0;
            this.Filename.ShortcutsEnabled = true;
            this.Filename.Size = new System.Drawing.Size(181, 23);
            this.Filename.Style = MetroFramework.MetroColorStyle.Silver;
            this.Filename.TabIndex = 31;
            this.Filename.UseSelectable = true;
            this.Filename.WaterMark = "File Name";
            this.Filename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Filename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Folder
            // 
            // 
            // 
            // 
            this.Folder.CustomButton.Image = null;
            this.Folder.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.Folder.CustomButton.Name = "";
            this.Folder.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Folder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Folder.CustomButton.TabIndex = 1;
            this.Folder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Folder.CustomButton.UseSelectable = true;
            this.Folder.CustomButton.Visible = false;
            this.Folder.Lines = new string[0];
            this.Folder.Location = new System.Drawing.Point(26, 81);
            this.Folder.MaxLength = 32767;
            this.Folder.Name = "Folder";
            this.Folder.PasswordChar = '\0';
            this.Folder.PromptText = "Folder Name";
            this.Folder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Folder.SelectedText = "";
            this.Folder.SelectionLength = 0;
            this.Folder.SelectionStart = 0;
            this.Folder.ShortcutsEnabled = true;
            this.Folder.Size = new System.Drawing.Size(181, 23);
            this.Folder.Style = MetroFramework.MetroColorStyle.Silver;
            this.Folder.TabIndex = 32;
            this.Folder.UseSelectable = true;
            this.Folder.WaterMark = "Folder Name";
            this.Folder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Folder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(94)))), ((int)(((byte)(102)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(26, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(94)))), ((int)(((byte)(102)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(26, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Disabled";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(233, 160);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(233, 189);
            this.Name = "Startup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox Filename;
        private MetroFramework.Controls.MetroTextBox Folder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}