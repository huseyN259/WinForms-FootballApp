namespace WinForms_HW_7.UserControls
{
    partial class Player
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBox_Posiiton = new System.Windows.Forms.TextBox();
            this.tBox_Number = new System.Windows.Forms.TextBox();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBox_Posiiton
            // 
            this.tBox_Posiiton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tBox_Posiiton.Enabled = false;
            this.tBox_Posiiton.Location = new System.Drawing.Point(31, 14);
            this.tBox_Posiiton.Name = "tBox_Posiiton";
            this.tBox_Posiiton.PlaceholderText = "Position";
            this.tBox_Posiiton.Size = new System.Drawing.Size(125, 32);
            this.tBox_Posiiton.TabIndex = 0;
            this.tBox_Posiiton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBox_Number
            // 
            this.tBox_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBox_Number.Location = new System.Drawing.Point(251, 14);
            this.tBox_Number.Name = "tBox_Number";
            this.tBox_Number.PlaceholderText = "Number";
            this.tBox_Number.Size = new System.Drawing.Size(125, 32);
            this.tBox_Number.TabIndex = 0;
            this.tBox_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_Number.TextChanged += new System.EventHandler(this.tBox_Number_TextChanged);
            // 
            // tBox_Name
            // 
            this.tBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Name.Location = new System.Drawing.Point(471, 14);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.PlaceholderText = "Name";
            this.tBox_Name.Size = new System.Drawing.Size(170, 32);
            this.tBox_Name.TabIndex = 0;
            this.tBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.tBox_Number);
            this.Controls.Add(this.tBox_Posiiton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(673, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox tBox_Posiiton;
        public TextBox tBox_Number;
        public TextBox tBox_Name;
    }
}
