using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace W8_THA
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ComboBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox_Team.Visible = false;
            comboBox_Player.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
        }

        private void playerDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBox_Team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt = new DataTable();
            string text = ComboBox_Team.SelectedValue.ToString();
            sqlquery = "select player_name, player_id as 'id player' from player p where p.team_id = '" +text+"' ;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mydataadapter = new MySqlDataAdapter(sqlcommand);
            mydataadapter.Fill(dt);
            comboBox_Player.DataSource = dt;
            comboBox_Player.DisplayMember = "player_name";
            comboBox_Player.ValueMember = "id player";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ComboBox_Team.Visible = true;
            comboBox_Player.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;

            sqlquery = "select team_name, team_id from team;";
            sqlcommand = new MySqlCommand(sqlquery,sqlconnect);
            mydataadapter = new MySqlDataAdapter(sqlcommand);
            mydataadapter.Fill(ds);
            ComboBox_Team.DataSource = ds;
            ComboBox_Team.ValueMember = "team_id";
            ComboBox_Team.DisplayMember = "team_name";
        }

        private void comboBox_Player_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dp = new DataTable();
            sqlquery = $"select p.player_name, p.playing_pos, p.team_number, t.team_name, n.nation from player p, nationality n, team t where t.team_id = p.team_id and p.nationality_id = n.nationality_id and p.player_id = '{comboBox_Player.SelectedValue.ToString()}' ;"; 
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mydataadapter = new MySqlDataAdapter(sqlcommand);
            mydataadapter.Fill(dp);
            lbl_playername.Text = dp.Rows[0][0].ToString();
            lbl_Pos.Text = dp.Rows[0][1].ToString();
            lbl_num.Text = dp.Rows[0][2].ToString();
            lbl_teamname.Text = dp.Rows[0][3].ToString();
            lbl_nation.Text = dp.Rows[0][4].ToString();

            dk = new DataTable();
            sqlquery = $"select `type` as 'Cards' from dmatch d, player p where d.player_id = p.player_id and p.player_name = '{comboBox_Player.GetItemText(comboBox_Player.SelectedItem).ToString()}';";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            mydataadapter = new MySqlDataAdapter(sqlcommand);
            mydataadapter.Fill(dk);

            int cy = 0;
            int cr = 0;
            int go = 0;
            int gw = 0;
            int pm = 0;
            int gws = 0;
            int gp = 0;

            for (int i = 0; i < dk.Rows.Count; i++)
            {
                if (dk.Rows[i][0].ToString() == "CY")
                {
                    cy++;
                }
                if (dk.Rows[i][0].ToString() == "CR")
                {
                    cr++;
                }
                if (dk.Rows[i][0].ToString() == "GO")
                {
                    go++;
                }
                if (dk.Rows[i][0].ToString() == "GW")
                {
                    gws++;
                }
                if (dk.Rows[i][0].ToString() == "PM")
                {
                    pm++;
                }
                if (dk.Rows[i][0].ToString() == "GP")
                {
                    gp++;
                }
            }
            lbl_ycard.Text = cy.ToString();
            lbl_rcard.Text = cr.ToString();
            lbl_goal.Text = go.ToString();
            lbl_owngoal.Text = gws.ToString();
            lbl_penmis.Text = pm.ToString();
            lbl_pengoal.Text = gp.ToString();

        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ayam = new Form2();
            ayam.Show();
            
        }
    }
}
