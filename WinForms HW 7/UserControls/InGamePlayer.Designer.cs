namespace WinForms_HW_7.UserControls
{
    partial class InGamePlayer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WinForms_HW_7.Resources.shirt;
            this.pictureBox1.Location = new System.Drawing.Point(9, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Position
            // 
            this.lbl_Position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Position.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Position.Location = new System.Drawing.Point(76, -2);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(43, 25);
            this.lbl_Position.TabIndex = 1;
            this.lbl_Position.Text = "OO";
            this.lbl_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(3, 128);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(117, 28);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name Surname";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Number
            // 
            this.lbl_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Number.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Number.Location = new System.Drawing.Point(15, -2);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(43, 25);
            this.lbl_Number.TabIndex = 1;
            this.lbl_Number.Text = "00";
            this.lbl_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InGamePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_Position);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InGamePlayer";
            this.Size = new System.Drawing.Size(128, 151);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_Position;
        private Label lbl_Name;
        private Label lbl_Number;
    }
}
