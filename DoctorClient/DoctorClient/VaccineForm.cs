using Newtonsoft.Json;
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

namespace DoctorClient
{
    public partial class VaccineForm : Form
    {
        public static string Token;
        public static string PetId;
        public static PetForm PetF;

        public VaccineForm(string _Token, string _ClientName, string _PetName, string _PetId, PetForm f)
        {
            InitializeComponent();
            Token = _Token;
            PetId = _PetId;
            labelClient.Text += _ClientName;
            labelPet.Text += _PetName;
            PetF = f;
           
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
           
            VaccinationModel s = new VaccinationModel()
            {
                IDPet = int.Parse(PetId),
                VaccineName = textBoxVaccineName.Text,
                DateOfVaccination = dateTimePicker1.Value.ToString(),
                ExpiredDate = dateTimePicker2.Value.ToString(),
                Description = textBoxDescription.Text,
                IsVaccinated = false
                
            };

            string site = "http://localhost:64332/";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/NewVaccination");
                request.ContentType = "application/json";
                request.Headers.Add("Authorization: Bearer " + Token);
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(s);
                    streamWriter.Write(json);

                }

                var httpResponse = (HttpWebResponse)request.GetResponse();

            }
            catch { MessageBox.Show("Ошибка при добавлении вакцины"); }
            PetF.VaccineLoad();
            this.Close();
        }
    }
}
