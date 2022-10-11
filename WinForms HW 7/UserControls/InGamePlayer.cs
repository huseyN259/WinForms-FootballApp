namespace WinForms_HW_7.UserControls;

public partial class InGamePlayer : UserControl
{
    public InGamePlayer(Models.Player player) 
        : this() 
    {
        lbl_Name.Text = player.Name;
        lbl_Number.Text = player.Number.ToString();
        lbl_Position.Text = player.Position.ToString();
    }

    public InGamePlayer()
    {
        InitializeComponent();
    }
}