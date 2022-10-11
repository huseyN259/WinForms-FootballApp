using WinForms_HW_7.Forms;
using WinForms_HW_7.Models;

namespace WinForms_HW_7
{
    public partial class Form1 : Form
    {
        public List<UserControls.Player> PlayerPanels = new List<UserControls.Player>();
        
        public IEnumerable<Models.Player> GetPlayers()
        {
            foreach (UserControls.Player player in PlayerPanels)
                yield return player.GetPlayer();
        }

        public Form1()
        {
            InitializeComponent();
            IntializePlayers();
            
            cBox_Countries.DataSource = FakeData.GetCountryNames();
            cBox_Tactics.DataSource = FakeData.GetTacticFormats();

        }

        private void IntializePlayers()
        {
            foreach (var item in pnl_Players.Controls)
                if(item is UserControls.Player player)
                    PlayerPanels.Add(player);
            SortPanels(PlayerPanels);
            
        }

        void SortPanels(List<UserControls.Player> list)
        {
            // Selection Sort

            for (int i = 0; i < list.Count - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < list.Count; j++)
                    if (list[j].Location.Y < list[min_idx].Location.Y)
                        min_idx = j;

                var temp = list[min_idx];
                list[min_idx] = list[i];
                list[i] = temp;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cBox_Tactics_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] tacticFormat = Array.ConvertAll(cBox_Tactics.Text.Split('-'), int.Parse);
            int selectedIndex = 0;
            List<Models.Player> currentPlayers;

            currentPlayers = FakeData
                .FakePlayers[Enums.Position.GK.ToString()]
                .OrderBy(p => Random.Shared.Next())
                .ToList();
            PlayerPanels[selectedIndex++].AdjustData(currentPlayers[0]);
            
            // kod qisa olsun deye melumatin azligindan yararlanarqi bu qeder random sort 
            // taktikasinda istifade eledim.

            currentPlayers = FakeData
                .FakePlayers[Enums.Position.DD.ToString()]
                .OrderBy(p => Random.Shared.Next())
                .ToList();

            for (int i = 0; i < tacticFormat[0]; i++)
                PlayerPanels[selectedIndex++].AdjustData(currentPlayers[i]);


            currentPlayers = FakeData
                .FakePlayers[Enums.Position.MD.ToString()]
                .OrderBy(p => Random.Shared.Next())
                .ToList();

            for (int i = 0; i < tacticFormat[1]; i++)
                PlayerPanels[selectedIndex++].AdjustData(currentPlayers[i]);

            
            currentPlayers = FakeData
                .FakePlayers[Enums.Position.F.ToString()]
                .OrderBy(p => Random.Shared.Next())
                .ToList();

            for (int i = 0; i < tacticFormat[2]; i++)
                PlayerPanels[selectedIndex++].AdjustData(currentPlayers[i]);



        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            Stadium StadiumForm = new Stadium();

            StadiumForm.CountryName = cBox_Countries.Text.Replace(' ', '\n');
            StadiumForm.Players = GetPlayers().ToList();
            StadiumForm.LoadPlayersToPanels();
            
            this.Hide();
            StadiumForm.ShowDialog();
            this.Visible = true;
        }
    }
}