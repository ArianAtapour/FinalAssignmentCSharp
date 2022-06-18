using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace SkateAssignment5ArianAtapour
{
    public partial class Main : Form
    {
        Distance distance = new Distance();
        Championship championship = new Championship();
        //Skater skater = new Skater();
        public Main()
        {
            Thread t = new Thread(new ThreadStart(SplashSc));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

            string conStr = "Data Source=DESKTOP-BFRIAQB;Initial Catalog=skChamp;Integrated Security=True;Pooling=False";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Name,Time,Distance FROM Skater", con);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            //Database connection
            /*string provider = ConfigurationManager.AppSettings["provider"]; //provider from App.config
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory=DbProviderFactories.GetFactory(provider); //generates an instance of factory, we can pass queries to db

            using (DbConnection connection = factory.CreateConnection())
            {
                if(connection == null)
                {
                    conEr.Text = "Connection error";
                }
                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    conEr.Text = "Command error";
                }

                command.Connection = connection;
                command.CommandText = "Select * From Skater";

                using(DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        conEr.Text=($"{dataReader["Name"]}");
                    }
                }
            }*/



            this.ContextMenuStrip = contextMenuStrip1;
        }

        public void SplashSc()
        {
            Application.Run(new Splash());
        }

        private void btnSk_Click(object sender, EventArgs e)
        {
            //string nameSkF=txtNSk.Text;
            Skater skater = new Skater();
            skater.addName(txtNSk.Text);
            string sql ="INSERT INTO Skater(Name) VALUES('" + txtNSk.Text+ "')";
            string provider = ConfigurationManager.AppSettings["provider"]; //provider from App.config
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider); //generates an instance of factory, we can pass queries to db

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    conEr.Text = "Connection error";
                }
                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    conEr.Text = "Command error";
                }

                command.Connection = connection;
                command.CommandText = sql;

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        conEr.Text = ($"{dataReader["Name"]}");
                    }
                }
            }
            //Distance distance = new Distance();
            dropSkD.Items.Add(skater.getName());
            distance.addSkater(skater);
            lblSk.Text=skater.getName() + " added";
        }

        private void dropSkD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDist_Click(object sender, EventArgs e)
        {
            championship.addDistance(distance);
            //varr selected = dropSkD.Text;
            string selSql= this.dropSkD.GetItemText(this.dropSkD.SelectedItem);
            double dist = Convert.ToDouble(txtDistD.Text);
            //skater.setDistance(dist);
            double dist500 = dist / 500;
            string subSD = timeD.Text;

            double hrsD = Convert.ToDouble(subSD.Substring(0, 2));
            double minsD = Convert.ToDouble(subSD.Substring(3, 2));
            double secsD = Convert.ToDouble(subSD.Substring(6, 2));

            double hrsToSec = hrsD * 3600;
            double minToSec = minsD * 60;

            double totalSec = hrsToSec + minToSec + secsD;
            double points = totalSec / dist500;

            string time = subSD.Substring(0, 2) + ":" + subSD.Substring(3, 2) + ":" + secsD;

            string sql = "UPDATE Skater SET Distance='"+ dist +"', Points='"+points+"', Time='"+time+"' WHERE Name='"+selSql+"'";
            string provider = ConfigurationManager.AppSettings["provider"]; //provider from App.config
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider); //generates an instance of factory, we can pass queries to db

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    distCon.Text = "Connection error";
                }
                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    distCon.Text = "Command error";
                }

                command.Connection = connection;
                command.CommandText = sql;

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        distCon.Text = ($"{dataReader["Distance"]}");
                    }
                }
            }



            foreach (Skater sk in distance.getSkaters())
            {
                //sk.setDistance(dist);
                if(sk.getName() == dropSkD.Text)
                {
                    sk.setDistance(dist);
                    sk.setPoints(points);

                    if(sk.getDistance() == 10000)
                    {
                        winner10000.Text = championship.getWinner();
                        //winner10000.Text = distance.winner10000();
                    }
                    else if(sk.getDistance() == 5000)
                    {
                        winner5000.Text = championship.getWinner();
                        //winner5000.Text = distance.winner5000();
                    }
                    else if (sk.getDistance() == 1500)
                    {
                        winner1500.Text = championship.getWinner();
                        //winner1500.Text = distance.winner1500();
                    }
                    else if(sk.getDistance() == 500)
                    {
                        //winner500.Text = distance.winner500();
                        winner500.Text = championship.getWinner();
                    }
                }

                lblDist.Text += "Time and distance added";
            }

            //winner500.Text = distance.winner500();
            //winner1500.Text = distance.winner1500();
            //winner5000.Text = distance.winner5000();
            //winner10000.Text = distance.winner10000();
        }

        private void timeD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Championship_Click(object sender, EventArgs e)
        {

        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            //notifyIcon1.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
