using System.Diagnostics.Metrics;
using System.Numerics;
using System.Windows.Forms.VisualStyles;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace W4_Homework
{
    public partial class Form1 : Form
    {
        List<Team> teamlist = new List<Team>();
        public string selected_player = "";
        public Form1()
        {
            InitializeComponent();
            Preset preset = new Preset();
            teamlist.Add(preset.Team1());
            teamlist.Add(preset.Team2());
            teamlist.Add(preset.Team3());
            Comboboxupdate();
        }

        private void button_add_team_Click(object sender, EventArgs e)
        {
            cbox_team.Items.Clear();
            Team team = new Team();
            team.Country = tbox_tcoun.Text;
            team.Name = tbox_tname.Text;
            team.City = tbox_tcity.Text;
            team.PlayerList = new List<Player>();
            teamlist.Add(team);
            Comboboxupdate();
            tbox_tcoun.Text = "";
            tbox_tname.Text = "";
            tbox_tcity.Text = "";

        }
        
        private void Comboboxupdate()
        {
            cbox_coun.Items.Clear();
            foreach(Team team in teamlist)
            {
                if (!cbox_coun.Items.Contains(team.Country))
                {
                    cbox_coun.Items.Add(team.Country);
                }
            }
        }
        private void Comboboxupdateteam()
        {
            cbox_team.Items.Clear();
            foreach (Team team in teamlist)
            {
                if (team.Country == cbox_coun.SelectedItem.ToString())
                {
                    cbox_team.Items.Add(team.Name);
                }
            }
        }
        public void RosterUpdate()
        {
            output_players.Items.Clear();
            foreach (Team team in teamlist)
            {
                if (team.Name == cbox_team.SelectedItem.ToString())
                {
                    foreach(Player player in team.PlayerList)
                    {
                        output_players.Items.Add($"[{player.Number }]{player.Name },{player.Pos}");
                    }
                }
            }
        }
        
        private void Country_Selected(object sender, EventArgs e)
        {
            Comboboxupdateteam();
        }

        private void Team_Selected(object sender, EventArgs e)
        {
            RosterUpdate();
        }
        private void button_add_player_Click(object sender, EventArgs e)
        {
            foreach (Team team in teamlist)
            {
                if (team.Name == cbox_team.SelectedItem.ToString())
                {
                    Player player = new Player();
                    player.Name = tbox_pname.Text;
                    player.Number = tbox_pnum.Text;
                    player.Pos = this.cbox_ppos.GetItemText(this.cbox_ppos.SelectedItem);
                    team.PlayerList.Add(player);
                    team.PlayerList.OrderBy(o => o.Number).ToList();
                    RosterUpdate();
                }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            foreach (Team team in teamlist)
            {
                if (team.Name == cbox_team.SelectedItem.ToString())
                {
                    for (int i = 0; i < team.PlayerList.Count; i++)
                    {
                        
                        if ($"[{team.PlayerList[i].Number}]{team.PlayerList[i].Name},{team.PlayerList[i].Pos}" == selected_player)
                        {
                            team.PlayerList.RemoveAt(i);
                            i--;
                            RosterUpdate();
                            break;

                        }
                    }
                    break;
                }
            }
        }

        private void lbox_value_change(object sender, EventArgs e)
        {
            selected_player = output_players.SelectedItem.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

