using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace W8_THA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string Sqlconnection = "server=localhost;uid=root;pwd=Ayamgoreng1025;database=premier_league";
        public MySqlConnection sqlconnect = new MySqlConnection(Sqlconnection);
        public MySqlCommand sqlcommand;
        public MySqlDataAdapter mydataadapter;
        public string sqlquery;
        DataTable ds = new DataTable();
        DataTable dt = new DataTable();
        DataTable dp = new DataTable();
        DataTable dk = new DataTable();
        DataTable dz = new DataTable();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sqlquery = "select team_name, team_id from team;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mydataadapter = new MySqlDataAdapter(sqlcommand);
            mydataadapter.Fill(ds);
            comboBox_Team.DataSource = ds;
            comboBox_Team.ValueMember = "team_id";
            comboBox_Team.DisplayMember = "team_name";
        }

        private void comboBox_Team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            sqlquery = "select t1.team_id as 'teamid', m.match_id as'matchid',m.match_date as'match date',t1.team_name as'home team',t2.team_name as'away team' from `match`m,dmatch d,team t1,team t2 where m.team_home=t1.team_id and m.team_away=t2.team_id and m.match_id=d.match_id and (t1.team_id=" + $"'{comboBox_Team.SelectedValue.ToString()}'or t2.team_id=" + $"'{comboBox_Team.SelectedValue.ToString()}') group by m.match_id;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mydataadapter = new MySqlDataAdapter(sqlcommand);
            mydataadapter.Fill(dt);
            comboBox_matchid.DataSource = dt;
            comboBox_matchid.ValueMember = "matchid";
            comboBox_matchid.DisplayMember = "matchid";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_matchid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dp.Clear();
            dk.Clear();
            dz.Clear();

            string simpan = comboBox_matchid.SelectedValue.ToString();
            sqlquery = $"select t.team_name as 'Home Team', p.player_name as 'Home Player', p.playing_pos as 'Pos' from `match` m, team t, player p where  p.team_id = t.team_id and t.team_id = m.team_home and m.match_id = '{simpan}'; ";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mydataadapter = new MySqlDataAdapter(sqlcommand);
            mydataadapter.Fill(dp);
            dataGridView1.DataSource = dp;

            sqlquery = $"select t.team_name as 'Team Away', p.player_name as 'Away Player', p.playing_pos as 'Pos' from `match` m,team t, player p where  p.team_id = t.team_id and t.team_id = m.team_away and m.match_id = '{simpan}' ; ";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mydataadapter = new MySqlDataAdapter(sqlcommand);
            mydataadapter.Fill(dk);
            dataGridView2.DataSource = dk;

            sqlquery = $"select d.`minute` as 'Time', p.player_name as 'Player name',t.team_name as 'Team name' ,if(d.type='CY','Yellow Card',if(d.type='CR','Red Card',if(d.type='GO','Goal',if(d.type='GW','OwnGoal',if(d.type='Gp','Goal Penalty','Penalty Miss'))))) as 'Cards' from dmatch d, player p, team t where d.team_id = t.team_id and p.player_id = d.player_id and d.match_id = '{simpan}' ; ";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mydataadapter = new MySqlDataAdapter(sqlcommand);
            mydataadapter.Fill(dz);
            dataGridView3.DataSource = dz;
        }
    }
}
