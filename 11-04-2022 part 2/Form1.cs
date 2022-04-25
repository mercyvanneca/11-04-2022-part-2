using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _11_04_2022_part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); 
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtTimkanan = new DataTable();
            sqlQuery = "SELECT team_name as 'Nama Tim', team_id as `id` from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTimkanan);
            CB_TimB.DisplayMember = "Nama Tim";
            CB_TimB.ValueMember = "id";
            CB_TimB.DataSource = dtTimkanan;

            DataTable dtTimkiri = new DataTable();
            sqlQuery = "SELECT team_name as 'Nama Tim', team_id as `id` from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTimkiri);
            CB_TimA.DisplayMember = "Nama Tim";
            CB_TimA.ValueMember = "id";
            CB_TimA.DataSource = dtTimkiri;
        }

        private void CB_TimA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable CB_kiri= new DataTable();
            sqlQuery = "SELECT manager.manager_name as `manager name`, player.player_name as `captain`" +
                "FROM team, player, manager " +
                "where team.captain_id = player.player_id and manager.manager_id = team.manager_id and team.team_id = '" + CB_TimA.SelectedValue.ToString() + "'";
         
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(CB_kiri);
            Label_OutputManagerA.Text = CB_kiri.Rows[0]["manager name"].ToString();
            Label_OutputCaptainA.Text = CB_kiri.Rows[0]["captain"].ToString();

            DataTable Stadium = new DataTable();
        }

        private void Label_OutputManagerA_Click(object sender, EventArgs e)
        {
            

        }

        private void CB_TimB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable CB_Kanan= new DataTable();
            sqlQuery = "SELECT manager.manager_name as `manager name`, player.player_name as `captain`" +
                "FROM team, player, manager " +
                "where team.captain_id = player.player_id and manager.manager_id = team.manager_id and team.team_id = '" + CB_TimB.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(CB_Kanan);
            Label_OutputManagerB.Text = CB_Kanan.Rows[0]["manager name"].ToString();
            Label_OutputCaptain2.Text = CB_Kanan.Rows[0]["captain"].ToString();
        }

        private void Label_OutputManagerB_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable stanggal = new DataTable();
            sqlQuery = sqlQuery = "SELECT date_format(match_date, '%e %M %Y') as 'tanggal', concat(goal_home, '-', goal_away) AS 'skor' from match where team_home = '" + CB_TimA.SelectedValue.ToString() + "' and team_away = '" + CB_TimB.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(stanggal);
            Lbl_OutputTgl.Text = stanggal.Rows[0]["tanggal"].ToString();
            Lbl_OutputSkor.Text = stanggal.Rows[0]["skor"].ToString();
        }

        private void Label_OutputStadium_Click(object sender, EventArgs e)
        {

        }

        private void Label_OutputCapacity_Click(object sender, EventArgs e)
        {

        }

        private void Data_Output_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lbl_OutputTgl_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_OutputSkor_Click(object sender, EventArgs e)
        {

        }
    }
}
