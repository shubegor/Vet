using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorClient
{
    public partial class PetForm : Form
    {

        public static string Token;
        public static string PetId;
        public static string ClientName;
        public static string PetName;

        public PetForm(string token, string Petid)
        {
            InitializeComponent();
            Token = token;
            PetId = Petid;
            PetUserDataLoad();
            ServicesLoad();
            VaccineLoad();
           
        }

        public void VaccineLoad()
        {
            List<VaccinationModel> s = new List<VaccinationModel>();
            string site = "http://localhost:64332/";

            var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/GetVaccinationPet?id=" + PetId);
            request.ContentType = "application/json";
            request.Headers.Add("Authorization: Bearer " + Token);

            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                Stream stream = httpWebResponse.GetResponseStream();

                DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(List<VaccinationModel>));
                s = (List<VaccinationModel>)JsonSerializer.ReadObject(stream);
            }
            s = s.OrderByDescending(x => x.DateOfVaccination).ToList();
            VaccineGrid.DataSource = s;

        }

        private void ServicesLoad()
        {
            List<ServiceModel> s = new List<ServiceModel>();
            string site = "http://localhost:64332/";
            
            var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/GetServicesPet?id=" + PetId);
            request.ContentType = "application/json";
            request.Headers.Add("Authorization: Bearer " + Token);

            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                Stream stream = httpWebResponse.GetResponseStream();

                DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(List<ServiceModel>));
                s = (List<ServiceModel>)JsonSerializer.ReadObject(stream);
            }

            foreach(var i in s)
            {
                ServicesTextBox.Text += "Врач: " + i.Doctor.Name + Environment.NewLine;
                ServicesTextBox.Text += "Дата: " + i.DateTimeService + Environment.NewLine;
                ServicesTextBox.Text += "Услуга: " + i.ServiceType.Name + Environment.NewLine;
                ServicesTextBox.Text += "Cтоимость услуги: " + i.ServiceType.Cost + Environment.NewLine;
                ServicesTextBox.Text += "Анамнез: " + i.Anamnesis + Environment.NewLine;
                ServicesTextBox.Text += "Диагноз: " + i.Diagnosis + Environment.NewLine;
                ServicesTextBox.Text += "Лечение: " + i.Treatment + Environment.NewLine;
                ServicesTextBox.Text += Environment.NewLine;


            }
        }

        private void PetUserDataLoad()
        {
            PetModel s = new PetModel();

            string site = "http://localhost:64332/";
           
            var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/GetPet?id=" + PetId);
            request.ContentType = "application/json";
            request.Headers.Add("Authorization: Bearer " + Token);

            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                Stream stream = httpWebResponse.GetResponseStream();

                DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(PetModel));
                s = (PetModel)JsonSerializer.ReadObject(stream);
            }

            CardId.Text = s.PetId.ToString();
            species.Text = s.Species;
            breed.Text = s.Breed;
            PetName = s.Name;
            petname.Text = s.Name;
            DateTime temp;
            if (DateTime.TryParse(s.Birth, out temp))
            {
                birth.Text = (DateTime.Now.Year - temp.Year).ToString() + " года (" + temp.ToString("dd/MM/yyyy") + ")";
            }
            else birth.Text = "";

            weight.Text = s.Weight.ToString();
            if (s.Gender == false) male.Text = "Ж"; else male.Text = "М";
            colour.Text = s.Colour;


            UserModel u = new UserModel();
            request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/GetClientById?id=" + s.OwnerId);
            request.ContentType = "application/json";
            request.Headers.Add("Authorization: Bearer " + Token);
            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                Stream stream = httpWebResponse.GetResponseStream();
  
                DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(UserModel));
                u = (UserModel)JsonSerializer.ReadObject(stream);
            }

            ClientName = u.Surname + " " + u.Name + " " + u.Patronymic;
            FIO.Text = ClientName;
            tel.Text = u.PhoneNumber;
            email.Text = u.Email;
            adress.Text = u.Address;
            Note.Text = u.Note;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            VaccineForm v = new VaccineForm(Token, ClientName, PetName, PetId, this);
            v.Show();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow i in VaccineGrid.Rows)
            {
                string id = i.Cells[0].Value.ToString();
                string res = i.Cells[7].Value.ToString();
                string site = "http://localhost:64332/";

                var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/UpdateVaccination?id=" + id + "&IsVaccinated=" + res);
                request.ContentType = "application/json";
                request.Headers.Add("Authorization: Bearer " + Token);

                using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
                {
                    Stream stream = httpWebResponse.GetResponseStream();
                    
                }
            }
            VaccineLoad();

        }
    }
}
