using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

internal class Preset
{
    public Team Team1()
    {
        String[] Playername = { "Justine Sim", "Daniel Arif", "Billy Abner", "Abed Nego", "Jeremy Setiawan", "Peter Wu", "Kevin Sunur", "Ronaldo Arif", "Rainaldy Arif", "Yongki Ohentoro", "Calvin Adrian", "Leonardus Aprianto", "Ronald Bajawa", "Pietersz", "Carvin Aldiano" };
        String[] Playernumber = { "10", "23", "27", "13", "05", "07", "02", "08", "09", "43", "29", "17", "14", "32", "20" };
        String[] Pos = { "LW", "MDF", "CM", "CB", "CB", "GK", "ST", "RW", "CB", "CB", "DMF", "CB", "DF", "GK", "DF" };
        Team team = new Team();
        team.Name = "scar strom squad";
        team.Country = "Indonesia";
        team.City = "Surabaya";
        team.PlayerList = new List<Player>();
        for (int i = 0; i < Playername.Count(); i++)
        {
            Player player = new Player();
            player.Name = Playername[i];
            player.Number = Playernumber[i];
            player.Pos = Pos[i];
            team.PlayerList.Add(player);
            team.PlayerList.OrderBy(o => o.Number).ToList();
        }
        return team;
    }
    public Team Team2()
    {
        String[] Playername = { "Vinicius", "Benzema", "Asensio", "Kroos", "Casemiro", "Modric'", "mendy", "alaba", "militao", "carvajal", "Courtoiz", "Valverde", "Tchouameni", "Rodiger" };
        String[] Playernumber = { "18", "31", "33", "02", "03", "05", "06", "04", "08", "14", "17", "09", "19", "26" };
        String[] Pos = { "LW", "FW", "RW", "CM", "CM", "CM", "DF", "DF", "DF", "DF", "GK", "RW", "CM", "RW" };
        Team team = new Team();
        team.Name = "Real Madrid Squad";
        team.Country = "Spanyol";
        team.City = "Madrid";
        team.PlayerList = new List<Player>();
        for (int i = 0; i < Playername.Count(); i++)
        {
            Player player = new Player();
            player.Name = Playername[i];
            player.Number = Playernumber[i];
            player.Pos = Pos[i];
            team.PlayerList.Add(player);
            team.PlayerList.OrderBy(o => o.Number).ToList();
        }
        return team;
    }
    public Team Team3()
    {
        String[] Playername = { "De Bruyne", "Haaland", "Ederson", "Dias", "Cancelo", "Silva", "Rodri", "Laporte", "Foden", "Mahrez", "Gudogan", "Walker", "Grealish", "Stones", "Phillips" };
        String[] Playernumber = { "17", "09", "31", "03", "07", "20", "16", "14", "47", "26", "08", "02", "10", "05", "04" };
        String[] Pos = { "CM", "ST", "GK", "CB", "LB", "CAM", "CDM", "CB", "CAM", "RW", "CM", "RB", "LW", "CB", "CDM" };
        Team team = new Team();
        team.Name = "Manchester City Squad";
        team.Country = "United Kingdom";
        team.City = "Manchester City";
        team.PlayerList = new List<Player>();
        for (int i = 0; i < Playername.Count(); i++)
        {
            Player player = new Player();
            player.Name = Playername[i];
            player.Number = Playernumber[i];
            player.Pos = Pos[i];
            team.PlayerList.Add(player);
            team.PlayerList.OrderBy(o => o.Number).ToList();
        }
        return team;
    }

}