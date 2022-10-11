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

namespace WinForms_HW_7.Forms
{
    public partial class Stadium : Form
    {
        public Dictionary<Enums.Position, Panel> PositionPanels { get; set; }
            = new Dictionary<Enums.Position, Panel>();
        public List<Models.Player>? Players{ get; set; }
        public string CountryName{
            get { return lbl_CountryName.Text; }
            set { lbl_CountryName.Text = value; ChangeFlag(); } 
        }
        public int[] TacticsFormat{ get; set; }


        private void ChangeFlag()
        {
            pic_Flag.LoadAsync($"https://countryflagsapi.com/png/{CountryName}");
        }

        public Stadium()
        {
            InitializeComponent();
            InitilaizePanels();
        }

        public void LoadPlayersToPanels()
        {
            foreach (var player in Players)
                PositionPanels[player.Position].Controls
                    .Add(new UserControls.InGamePlayer(player));

            AdjustPlayerPositions();
        }

        private void AdjustPlayerPositions()
        {
            foreach (var pair in PositionPanels)
            {
                var players = GetPlayersInPanel(pair.Value).ToList();
                int startingIndex = 0;

                int middleAlligned = players.Count % 2;
                int leftAlligned = (players.Count - middleAlligned) / 2;
                int rightAlligned = players.Count - middleAlligned - leftAlligned;

                for (int i = 0; i < leftAlligned; i++)
                    players[startingIndex++].Dock = DockStyle.Left;

                for (int i = 0; i < rightAlligned; i++)
                    players[startingIndex++].Dock = DockStyle.Right;

                if (middleAlligned > 0)
                    players[startingIndex++].Dock = DockStyle.Fill;
            }
        }

        IEnumerable<UserControls.InGamePlayer> GetPlayersInPanel(Panel panel)
        {
            foreach (var item in panel.Controls)
                if(item is UserControls.InGamePlayer player)
                    yield return player;
        }

        private void InitilaizePanels()
        {
            PositionPanels[Enums.Position.GK] = pnl_GK;
            PositionPanels[Enums.Position.DD] = pnl_DD;
            PositionPanels[Enums.Position.MD] = pnl_MD;
            PositionPanels[Enums.Position.F] = pnl_F;
        }
    }
}
