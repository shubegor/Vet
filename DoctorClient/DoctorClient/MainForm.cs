using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;

namespace DoctorClient
{
    public partial class MainForm : Form
    {
        
        public MainForm(string token)
        {
            InitializeComponent();
            Token = token;
            GetDocName();
            BuildGrid();
            
            Closing += new System.ComponentModel.CancelEventHandler(this.OnWindowClosing);
        }

        private void GetDocName()
        {
            string site = "http://localhost:64332/";
           
            var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/GetMyName");
            request.ContentType = "application/json";
            request.Headers.Add("Authorization: Bearer " + Token);

            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                Stream stream = httpWebResponse.GetResponseStream();

                DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(string));
                DocName.Text = (string)JsonSerializer.ReadObject(stream);
            }
        }

        private void OnWindowClosing(object sender, CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        public string GetToken()
        {
            return Token;
        }

        public static string Token;


        public void BuildGrid()
        {
            try
            {
                ServiceGrid.DataSource = DataReqService();
                ClientsGrid.DataSource = DataReqClients();
            } catch(Exception ex)
            {
                MessageBox.Show("При загрузке таблиц что то пошло не так");
            }
           
            
        }

        private static List<PetModel> DataReqClients()
        {
            List<PetModel> s = new List<PetModel>();

            string site = "http://localhost:64332/";
            // try
            //            {
            var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/AllDoctorPet");
            request.ContentType = "application/json";
            request.Headers.Add("Authorization: Bearer " + Token);

            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                Stream stream = httpWebResponse.GetResponseStream();

                DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(List<PetModel>));
                s = (List<PetModel>)JsonSerializer.ReadObject(stream);
            }


            //}
            //catch { }
            return s;
        }


        private static List<ServiceWebModel> DataReqService()
        {
            List<ServiceWebModel> s = new List<ServiceWebModel>();

            string site = "http://localhost:64332/";
           // try
//            {
                var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/AllDoctorServices");
                request.ContentType = "application/json";
                request.Headers.Add("Authorization: Bearer " + Token);

                using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
                {
                    Stream stream = httpWebResponse.GetResponseStream();

                    DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(List<ServiceWebModel>));
                    s = (List<ServiceWebModel>)JsonSerializer.ReadObject(stream);
                }


            //}
            //catch { }
            return s;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string g = ServiceGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].GetType().ToString();
            if (g == "System.Windows.Forms.DataGridViewButtonCell")
            {
                string id = ServiceGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                ServiceForm a = new ServiceForm(Token, id);
                a.Show();

            }
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string g = ClientsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].GetType().ToString();
            if (g == "System.Windows.Forms.DataGridViewButtonCell")
            {
                string id = ClientsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                PetForm a = new PetForm(Token, id);
                a.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
