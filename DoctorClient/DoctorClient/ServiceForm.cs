using Newtonsoft.Json;
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
    public partial class ServiceForm : Form
    {
        public static string Token;
        public static string SerId;
        public static List<ServiceTypeModel> st;
        public ServiceForm(string token, string sID)
        {
            Token = token;
            SerId = sID;
            InitializeComponent();

            GetServiceInfo();
        }

        private void GetServiceInfo()
        {
            ServiceModel s = new ServiceModel();

            string site = "http://localhost:64332/";
            // try
            //            {
            var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/GetService?id=" + SerId);
            request.ContentType = "application/json";
            request.Headers.Add("Authorization: Bearer " + Token);

            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                Stream stream = httpWebResponse.GetResponseStream();

                DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(ServiceModel));
                s = (ServiceModel)JsonSerializer.ReadObject(stream);
            }

            
            //load servicetypes
            request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/GetServiceTypes");
            request.ContentType = "application/json";
            request.Headers.Add("Authorization: Bearer " + Token);

            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                Stream stream = httpWebResponse.GetResponseStream();

                DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(List<ServiceTypeModel>));
                st = (List<ServiceTypeModel>)JsonSerializer.ReadObject(stream);
            }

            comboBox1.DataSource = st;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ServiceTypeId";




            
            ClientName.Text = s.Pet.OwnerName;
            PetName.Text = s.Pet.Name;
            DoctorName.Text = s.Doctor.Name;
            SerDate.Text = DateTime.Parse(s.DateTimeService).ToString("dd.MM.yyyy");
            SerTime.Text = DateTime.Parse(s.DateTimeService).ToString("HH:mm");
            comboBox1.SelectedValue = s.ServiceTypeId;
            //SerTypeName.Text = s.ServiceType.Name;
            Cost.Text = s.ServiceType.Cost.ToString();
            if (s.IsPaid == false) IsPaid.Text = "не оплачено";
            else
                IsPaid.Text = "оплачено";
            Anamnes.Text = s.Anamnesis;
            Diagnos.Text = s.Diagnosis;
            Lechenie.Text = s.Treatment;




        }

       

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ServiceModel temp = new ServiceModel() {
                ServiceId = Guid.Parse(SerId),
                ServiceTypeId = (Guid)comboBox1.SelectedValue,
                Anamnesis = Anamnes.Text,
                Diagnosis = Diagnos.Text,
                Treatment = Lechenie.Text };
            
            string site = "http://localhost:64332/";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(site + "api/Doctor/UpdateService");
                request.ContentType = "application/json";
                request.Headers.Add("Authorization: Bearer " + Token);
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(temp);
                    streamWriter.Write(json);

                }

                var httpResponse = (HttpWebResponse)request.GetResponse();

            }
            catch { }

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceTypeModel a = (ServiceTypeModel)comboBox1.SelectedItem;
            Cost.Text = a.Cost.ToString();
        }
    }
}
