using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace WindFormMovieAss2Feb
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
        SqlCommand cm = null;
        SqlDataReader dr = null;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbMovieDetails_Click(object sender, EventArgs e)
        {
            

        }

        private void btnShowMovie_Click(object sender, EventArgs e)
        {
            lblActor.Visible = true;
            lblMovieName.Visible = true;
            lblTicketsSold.Visible = true;
            try
            {
                SqlCommand cm = new SqlCommand("sp_ShowMovie", cn);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@MovieId", txtMovieId.Text);
                cn.Open();
                dr = cm.ExecuteReader(CommandBehavior.CloseConnection);
                if(dr.HasRows && dr.Read())
                {
                    lblMovieName.Text = dr["MovieName"].ToString();
                    lblActor.Text = dr["Actor"].ToString();
                    lblTicketsSold.Text = dr["Tickets"].ToString();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
        }
        private void ShowData()
        {
            using (cm = new SqlCommand("Select * from MovieTable", cn))
            {
                cn.Open();
                dr = cm.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                
                dataGridView1.DataSource = dt;
                dr.Close();
                cn.Close();

            }
        }

        private void tbShowMovie_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowAllMovies_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cm = new SqlCommand("sp_UpdateMovie", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.AddWithValue("@MovieId", txtUMovieId.Text);
                    cm.Parameters.AddWithValue("@MovieName", txtUMovieName.Text);
                    cm.Parameters.AddWithValue("@Actor", txtUActor.Text);
                    cm.Parameters.AddWithValue("@Tickets", txtUTickets.Text);

                    cn.Open();
                    int i = cm.ExecuteNonQuery();
                    MessageBox.Show("Updated Succcesfully");
                    ShowData();
                    cn.Close();
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btShowOnlyMovie_Click(object sender, EventArgs e)
        {
            lblMovieNameOnly.Visible = true;
            try
            {
                using (cm = new SqlCommand("sp_ShowOnlyMovie", cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MovieId", txtMovieId.Text);

                    cn.Open();
                    

                    lblMovieNameOnly.Text = cm.ExecuteScalar().ToString();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
