using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W8_Felicia.S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> data = new List<string>() { "Name", "Team", "Position", "Nationality", "Squad Number", "Yellow Cards", "Red Cards", "Goal Scored", "Penalty Missed" };
        int xNama = 15;
        int yData = 100;
        int xData = 110;
        bool cek = false;
        Label[] Data1;
        Label[] Data2;

        MySqlConnection mysqlConnect;
        MySqlCommand mysqlCommand;
        MySqlDataAdapter mySqlAdapter;
        string connectionString;
        string sqlQuery;

        DataTable dataTeam = new DataTable();
        DataTable dataComb2 = new DataTable();
        DataTable dataPemain = new DataTable();
        DataTable dataMatch = new DataTable();
        DataTable dataHome = new DataTable();
        DataTable dataAway = new DataTable();
        DataTable dataCard = new DataTable();

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTeam.Clear();
            dataComb2.Clear();
            dataPemain.Clear();

            comboBoxteam.Enabled = true;
            comboBoxplayer.Enabled = true;
            comboBoxteam2.Enabled = false;
            comboBoxplayer2.Enabled = false;
            yData = 100;
            if (cek == false)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    Label Data = new Label();
                    Data.Location = new Point(xNama, yData);
                    Data.Size = new Size(100, 15);
                    Data.Text = data[i];
                    this.Controls.Add(Data);
                    yData += 20;
                }
                cek = true;
            }

            sqlQuery = "SELECT t.team_name, t.team_id FROM team t;";
            mysqlCommand = new MySqlCommand(sqlQuery, mysqlConnect);
            mySqlAdapter = new MySqlDataAdapter(mysqlCommand);
            mySqlAdapter.Fill(dataTeam);
            comboBoxteam.DataSource = dataTeam;
            comboBoxteam.ValueMember = "team_id";
            comboBoxteam.DisplayMember = "team_name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxteam.Enabled = false;
            comboBoxplayer.Enabled = false;
            comboBoxteam2.Enabled = false;
            comboBoxplayer2.Enabled = false;

            connectionString = "server=localhost;uid=root;pwd=Apakau123;database=premier_league";
            mysqlConnect = new MySqlConnection(connectionString);

            yData = 100;
            Data1 = new Label[5];
            Data2 = new Label[4];
            for (int i = 0; i < 5; i++)
            {
                Data1[i] = new Label();
                Data1[i].Location = new Point(xData, yData);
                Data1[i].Size = new Size(100, 15);
                Data1[i].Text = "";
                this.Controls.Add(Data1[i]);
                yData += 20;
            }
            for (int i = 0; i < 4; i++)
            {
                Data2[i] = new Label();
                Data2[i].Location = new Point(xData, yData);
                Data2[i].Size = new Size(100, 15);
                Data2[i].Text = "";
                this.Controls.Add(Data2[i]);
                yData += 20;
            }
        }

        private void comboBoxteam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataPemain.Clear();
            dataComb2.Clear();

            sqlQuery = "SELECT p.player_name FROM team t, player p WHERE t.team_id = p.team_id AND t.team_id = '" + comboBoxteam.SelectedValue.ToString() + "';";
            mysqlCommand = new MySqlCommand(sqlQuery, mysqlConnect);
            mySqlAdapter = new MySqlDataAdapter(mysqlCommand);
            mySqlAdapter.Fill(dataComb2);
            comboBoxplayer.DataSource = dataComb2;
            comboBoxplayer.ValueMember = "player_name";
            comboBoxplayer.DisplayMember = "player_name";
        }

        private void comboBoxplayer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //yData = 100;
            dataPemain.Clear();
            dataCard.Clear();  
            
            sqlQuery = "SELECT p.player_name, t.team_name, if(p.playing_pos = 'D', 'Defender', if(p.playing_pos = 'M', 'Midfielder', if (p.playing_pos = 'G', 'GoalKeeper', 'Forward'))), n.nation, p.team_number\r\nFROM team t, player p, nationality n\r\nWHERE t.team_id = p.team_id\r\nAND p.nationality_id = n.nationality_id AND p.player_name = '" + comboBoxplayer.SelectedValue.ToString() + "' group by 1, 2, 3, 4, 5;";
            mysqlCommand = new MySqlCommand(sqlQuery, mysqlConnect);
            mySqlAdapter = new MySqlDataAdapter(mysqlCommand);
            mySqlAdapter.Fill(dataPemain);

            sqlQuery = "SELECT ifnull(sum(d.`type` = 'CY'), '0'), ifnull(sum(d.`type` = 'CR'), '0'), ifnull(sum(d.`type` = 'GO'), '0'), ifnull(sum(d.`type` = 'PM'), 0) FROM dmatch d, player p WHERE d.player_id = p.player_id AND p.player_name = '" + comboBoxplayer.SelectedValue.ToString() + "';";
            mysqlCommand = new MySqlCommand(sqlQuery, mysqlConnect);
            mySqlAdapter = new MySqlDataAdapter(mysqlCommand);
            mySqlAdapter.Fill(dataCard);
            for (int i = 0; i < dataPemain.Columns.Count; i++)
            {
                Data1[i].Text = ": " + dataPemain.Rows[0][i].ToString();
            }
            for (int i = 0; i < dataCard.Columns.Count; i++)
            {
                Data2[i].Text = ": " + dataCard.Rows[0][i].ToString();
            }
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxteam.Enabled = false;
            comboBoxplayer.Enabled = false;
            comboBoxteam2.Enabled = true;
            comboBoxplayer2.Enabled = true;
            dataPemain.Clear();

            sqlQuery = "SELECT t.team_name, t.team_id FROM team t;";
            mysqlCommand = new MySqlCommand(sqlQuery, mysqlConnect);
            mySqlAdapter = new MySqlDataAdapter(mysqlCommand);
            mySqlAdapter.Fill(dataTeam);
            comboBoxteam2.DataSource = dataTeam;
            comboBoxteam2.ValueMember = "team_id";
            comboBoxteam2.DisplayMember = "team_name";
        }

        private void comboBoxteam2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataPemain.Clear();
            dataComb2.Clear();

            sqlQuery = "SELECT m.match_date, m.match_id\r\nFROM `match` m, dmatch d\r\nWHERE d.match_id = m.match_id AND (m.team_home = d.team_id or m.team_away = d.team_id) AND d.team_id = '" + comboBoxteam2.SelectedValue.ToString() + "' \r\ngroup by m.match_id;";
            mysqlCommand = new MySqlCommand(sqlQuery, mysqlConnect);
            mySqlAdapter = new MySqlDataAdapter(mysqlCommand);
            mySqlAdapter.Fill(dataComb2);
            comboBoxplayer2.DataSource = dataComb2;
            comboBoxplayer2.ValueMember = "match_id";
            comboBoxplayer2.DisplayMember = "match_date";
        }

        private void comboBoxplayer2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataHome.Clear();
            dataAway.Clear();
            dataMatch.Clear();

            sqlQuery = "SELECT t.team_name as 'Team Name', p.player_name as 'Player Home Team', if(p.playing_pos = 'D', 'Defender', if(p.playing_pos = 'M', 'Midfielder', if (p.playing_pos = 'G', 'GoalKeeper', 'Forward'))) as 'Position'\r\nFROM `match` m, player p, team t\r\nWHERE p.team_id = m.team_home\r\nAND t.team_id = m.team_home AND m.match_id = '" + comboBoxplayer2.SelectedValue.ToString() + "';";
            mysqlCommand = new MySqlCommand(sqlQuery, mysqlConnect);
            mySqlAdapter = new MySqlDataAdapter(mysqlCommand);
            mySqlAdapter.Fill(dataHome);
            dataGridView1.DataSource = dataHome;

            sqlQuery = "SELECT t.team_name as 'Team Name', p.player_name as 'Player Away Team', if(p.playing_pos = 'D', 'Defender', if(p.playing_pos = 'M', 'Midfielder', if (p.playing_pos = 'G', 'GoalKeeper', 'Forward'))) as 'Position'\r\nFROM `match` m, player p, team t\r\nWHERE p.team_id = m.team_away\r\nAND t.team_id = m.team_away\r\nAND m.match_id = '" + comboBoxplayer2.SelectedValue.ToString() + "';";
            mysqlCommand = new MySqlCommand(sqlQuery, mysqlConnect);
            mySqlAdapter = new MySqlDataAdapter(mysqlCommand);
            mySqlAdapter.Fill(dataAway);
            dataGridView2.DataSource = dataAway;

            sqlQuery = "SELECT d.minute as 'Minute', t.team_name as 'Team Name', p.player_name as 'Player Name', if(d.`type` = 'CR', 'Red Card (CR)', if(d.`type` = 'CY', 'Yellow Card (CY)', if(d.`type` = 'GP', 'Penalty Goal (GP)', if(d.`type` = 'GO', 'Goal Scored (GO)', if(d.`type` = 'GW', 'Own Goal (GW)', 'Penalty Missed (PM)'))))) as 'Type'\r\nFROM dmatch d, team t, player p\r\nWHERE d.team_id = t.team_id\r\nAND p.player_id = d.player_id\r\nAND d.match_id = '" + comboBoxplayer2.SelectedValue.ToString() + "';";
            mysqlCommand = new MySqlCommand(sqlQuery, mysqlConnect);
            mySqlAdapter = new MySqlDataAdapter(mysqlCommand);
            mySqlAdapter.Fill(dataMatch);
            dataGridView3.DataSource = dataMatch;
        }
    }
}
