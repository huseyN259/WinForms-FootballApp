namespace WinForms_HW_7
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
            this.btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_Tactics = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnl_Categories = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Players = new System.Windows.Forms.Panel();
            this.player7 = new WinForms_HW_7.UserControls.Player();
            this.player6 = new WinForms_HW_7.UserControls.Player();
            this.player5 = new WinForms_HW_7.UserControls.Player();
            this.player11 = new WinForms_HW_7.UserControls.Player();
            this.player4 = new WinForms_HW_7.UserControls.Player();
            this.player10 = new WinForms_HW_7.UserControls.Player();
            this.player3 = new WinForms_HW_7.UserControls.Player();
            this.player9 = new WinForms_HW_7.UserControls.Player();
            this.player2 = new WinForms_HW_7.UserControls.Player();
            this.player8 = new WinForms_HW_7.UserControls.Player();
            this.player1 = new WinForms_HW_7.UserControls.Player();
            this.btn_Generate = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.cBox_Countries = new System.Windows.Forms.ComboBox();
            this.pnl_Categories.SuspendLayout();
            this.pnl_Players.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.FillColor = System.Drawing.Color.Red;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(586, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Close.Size = new System.Drawing.Size(35, 35);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country:";
            // 
            // cBox_Tactics
            // 
            this.cBox_Tactics.BackColor = System.Drawing.Color.Transparent;
            this.cBox_Tactics.BorderThickness = 3;
            this.cBox_Tactics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_Tactics.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBox_Tactics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Tactics.FillColor = System.Drawing.SystemColors.Window;
            this.cBox_Tactics.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_Tactics.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cBox_Tactics.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_Tactics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cBox_Tactics.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cBox_Tactics.ItemHeight = 30;
            this.cBox_Tactics.Location = new System.Drawing.Point(424, 52);
            this.cBox_Tactics.Name = "cBox_Tactics";
            this.cBox_Tactics.Size = new System.Drawing.Size(130, 36);
            this.cBox_Tactics.TabIndex = 2;
            this.cBox_Tactics.SelectedIndexChanged += new System.EventHandler(this.cBox_Tactics_SelectedIndexChanged);
            // 
            // pnl_Categories
            // 
            this.pnl_Categories.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Categories.Controls.Add(this.label4);
            this.pnl_Categories.Controls.Add(this.label3);
            this.pnl_Categories.Controls.Add(this.label2);
            this.pnl_Categories.FillColor = System.Drawing.Color.White;
            this.pnl_Categories.Location = new System.Drawing.Point(33, 100);
            this.pnl_Categories.Name = "pnl_Categories";
            this.pnl_Categories.ShadowColor = System.Drawing.Color.Black;
            this.pnl_Categories.Size = new System.Drawing.Size(573, 53);
            this.pnl_Categories.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(442, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(251, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Position";
            // 
            // pnl_Players
            // 
            this.pnl_Players.AutoScroll = true;
            this.pnl_Players.Controls.Add(this.player7);
            this.pnl_Players.Controls.Add(this.player6);
            this.pnl_Players.Controls.Add(this.player5);
            this.pnl_Players.Controls.Add(this.player11);
            this.pnl_Players.Controls.Add(this.player4);
            this.pnl_Players.Controls.Add(this.player10);
            this.pnl_Players.Controls.Add(this.player3);
            this.pnl_Players.Controls.Add(this.player9);
            this.pnl_Players.Controls.Add(this.player2);
            this.pnl_Players.Controls.Add(this.player8);
            this.pnl_Players.Controls.Add(this.player1);
            this.pnl_Players.Location = new System.Drawing.Point(33, 169);
            this.pnl_Players.Name = "pnl_Players";
            this.pnl_Players.Size = new System.Drawing.Size(588, 410);
            this.pnl_Players.TabIndex = 4;
            // 
            // player7
            // 
            this.player7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player7.Location = new System.Drawing.Point(12, 412);
            this.player7.Margin = new System.Windows.Forms.Padding(4);
            this.player7.Name = "player7";
            this.player7.Size = new System.Drawing.Size(542, 60);
            this.player7.TabIndex = 0;
            // 
            // player6
            // 
            this.player6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player6.Location = new System.Drawing.Point(12, 344);
            this.player6.Margin = new System.Windows.Forms.Padding(4);
            this.player6.Name = "player6";
            this.player6.Size = new System.Drawing.Size(542, 60);
            this.player6.TabIndex = 0;
            // 
            // player5
            // 
            this.player5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player5.Location = new System.Drawing.Point(12, 276);
            this.player5.Margin = new System.Windows.Forms.Padding(4);
            this.player5.Name = "player5";
            this.player5.Size = new System.Drawing.Size(542, 60);
            this.player5.TabIndex = 0;
            // 
            // player11
            // 
            this.player11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player11.Location = new System.Drawing.Point(12, 684);
            this.player11.Margin = new System.Windows.Forms.Padding(4);
            this.player11.Name = "player11";
            this.player11.Size = new System.Drawing.Size(542, 60);
            this.player11.TabIndex = 0;
            // 
            // player4
            // 
            this.player4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player4.Location = new System.Drawing.Point(12, 208);
            this.player4.Margin = new System.Windows.Forms.Padding(4);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(542, 60);
            this.player4.TabIndex = 0;
            // 
            // player10
            // 
            this.player10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player10.Location = new System.Drawing.Point(12, 616);
            this.player10.Margin = new System.Windows.Forms.Padding(4);
            this.player10.Name = "player10";
            this.player10.Size = new System.Drawing.Size(542, 60);
            this.player10.TabIndex = 0;
            // 
            // player3
            // 
            this.player3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player3.Location = new System.Drawing.Point(12, 140);
            this.player3.Margin = new System.Windows.Forms.Padding(4);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(542, 60);
            this.player3.TabIndex = 0;
            // 
            // player9
            // 
            this.player9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player9.Location = new System.Drawing.Point(12, 548);
            this.player9.Margin = new System.Windows.Forms.Padding(4);
            this.player9.Name = "player9";
            this.player9.Size = new System.Drawing.Size(542, 60);
            this.player9.TabIndex = 0;
            // 
            // player2
            // 
            this.player2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player2.Location = new System.Drawing.Point(12, 72);
            this.player2.Margin = new System.Windows.Forms.Padding(4);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(542, 60);
            this.player2.TabIndex = 0;
            // 
            // player8
            // 
            this.player8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player8.Location = new System.Drawing.Point(12, 480);
            this.player8.Margin = new System.Windows.Forms.Padding(4);
            this.player8.Name = "player8";
            this.player8.Size = new System.Drawing.Size(542, 60);
            this.player8.TabIndex = 0;
            // 
            // player1
            // 
            this.player1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.player1.Location = new System.Drawing.Point(12, 4);
            this.player1.Margin = new System.Windows.Forms.Padding(4);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(542, 60);
            this.player1.TabIndex = 0;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Animated = true;
            this.btn_Generate.BorderRadius = 15;
            this.btn_Generate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Generate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Generate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Generate.FillColor2 = System.Drawing.Color.Cyan;
            this.btn_Generate.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Generate.ForeColor = System.Drawing.Color.White;
            this.btn_Generate.Location = new System.Drawing.Point(467, 618);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(154, 41);
            this.btn_Generate.TabIndex = 5;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // cBox_Countries
            // 
            this.cBox_Countries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_Countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Countries.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cBox_Countries.FormattingEnabled = true;
            this.cBox_Countries.Location = new System.Drawing.Point(144, 52);
            this.cBox_Countries.Name = "cBox_Countries";
            this.cBox_Countries.Size = new System.Drawing.Size(260, 36);
            this.cBox_Countries.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(639, 682);
            this.Controls.Add(this.cBox_Countries);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.pnl_Players);
            this.Controls.Add(this.pnl_Categories);
            this.Controls.Add(this.cBox_Tactics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Categories.ResumeLayout(false);
            this.pnl_Categories.PerformLayout();
            this.pnl_Players.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btn_Close;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cBox_Tactics;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_Categories;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel pnl_Players;
        private UserControls.Player player7;
        private UserControls.Player player6;
        private UserControls.Player player5;
        private UserControls.Player player11;
        private UserControls.Player player4;
        private UserControls.Player player10;
        private UserControls.Player player3;
        private UserControls.Player player9;
        private UserControls.Player player2;
        private UserControls.Player player8;
        private UserControls.Player player1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Generate;
        private ComboBox cBox_Countries;
    }
}