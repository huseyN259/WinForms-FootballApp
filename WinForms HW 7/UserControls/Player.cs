using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_HW_7.Models;

namespace WinForms_HW_7.UserControls
{
    public partial class Player : UserControl
    {
        public Player()
        {
            InitializeComponent();
        }

        string previous_Text = "";
        private void tBox_Number_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tBox_Number.Text, out int num) || tBox_Number.Text == string.Empty)
                previous_Text = tBox_Number.Text;
            else
                tBox_Number.Text = previous_Text; 
        }


        public Models.Player GetPlayer()
            => new Models.Player(tBox_Name.Text, 
                Convert.ToByte(tBox_Number.Text), 
                ExtraUtility.GetPosition(tBox_Posiiton.Text));
        
        public void AdjustData(Models.Player player)
        {
            tBox_Name.Text = player.Name;
            tBox_Number.Text = player.Number.ToString();
            tBox_Posiiton.Text = player.Position.ToString();
        }
    }
}
