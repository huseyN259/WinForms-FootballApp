namespace WinForms_HW_7.Forms
{
    partial class Stadium
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
            this.pic_Flag = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_CountryName = new System.Windows.Forms.Label();
            this.pnl_GK = new System.Windows.Forms.Panel();
            this.pnl_DD = new System.Windows.Forms.Panel();
            this.pnl_MD = new System.Windows.Forms.Panel();
            this.pnl_F = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Flag)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Flag
            // 
            this.pic_Flag.BackColor = System.Drawing.Color.Transparent;
            this.pic_Flag.ImageRotate = 0F;
            this.pic_Flag.Location = new System.Drawing.Point(12, 12);
            this.pic_Flag.Name = "pic_Flag";
            this.pic_Flag.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_Flag.Size = new System.Drawing.Size(100, 100);
            this.pic_Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Flag.TabIndex = 0;
            this.pic_Flag.TabStop = false;
            // 
            // lbl_CountryName
            // 
            this.lbl_CountryName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CountryName.ForeColor = System.Drawing.Color.White;
            this.lbl_CountryName.Location = new System.Drawing.Point(479, 12);
            this.lbl_CountryName.Name = "lbl_CountryName";
            this.lbl_CountryName.Size = new System.Drawing.Size(150, 100);
            this.lbl_CountryName.TabIndex = 1;
            this.lbl_CountryName.Text = "Country";
            this.lbl_CountryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_GK
            // 
            this.pnl_GK.BackColor = System.Drawing.Color.Transparent;
            this.pnl_GK.Location = new System.Drawing.Point(195, 775);
            this.pnl_GK.Name = "pnl_GK";
            this.pnl_GK.Size = new System.Drawing.Size(263, 149);
            this.pnl_GK.TabIndex = 2;
            // 
            // pnl_DD
            // 
            this.pnl_DD.BackColor = System.Drawing.Color.Transparent;
            this.pnl_DD.Location = new System.Drawing.Point(1, 584);
            this.pnl_DD.Name = "pnl_DD";
            this.pnl_DD.Size = new System.Drawing.Size(628, 152);
            this.pnl_DD.TabIndex = 3;
            // 
            // pnl_MD
            // 
            this.pnl_MD.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MD.Location = new System.Drawing.Point(1, 391);
            this.pnl_MD.Name = "pnl_MD";
            this.pnl_MD.Size = new System.Drawing.Size(628, 149);
            this.pnl_MD.TabIndex = 4;
            // 
            // pnl_F
            // 
            this.pnl_F.BackColor = System.Drawing.Color.Transparent;
            this.pnl_F.Location = new System.Drawing.Point(1, 165);
            this.pnl_F.Name = "pnl_F";
            this.pnl_F.Size = new System.Drawing.Size(628, 149);
            this.pnl_F.TabIndex = 5;
            // 
            // Stadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForms_HW_7.Resources.stadium;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(641, 958);
            this.Controls.Add(this.pnl_F);
            this.Controls.Add(this.pnl_MD);
            this.Controls.Add(this.pnl_DD);
            this.Controls.Add(this.pnl_GK);
            this.Controls.Add(this.lbl_CountryName);
            this.Controls.Add(this.pic_Flag);
            this.Name = "Stadium";
            this.Text = "Stadium";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Flag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_Flag;
        private Label lbl_CountryName;
        private Panel pnl_GK;
        private Panel pnl_DD;
        private Panel pnl_MD;
        private Panel pnl_F;
    }
}