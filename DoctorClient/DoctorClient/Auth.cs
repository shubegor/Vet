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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string site = "http://localhost:64332/";
            string user = Username.Text;
            string pass = Password.Text;
            try
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(site + "Token");
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                var postData = "grant_type=password";
                postData += "&username=" + user;
                postData += "&password=" + pass;
                var data = Encoding.ASCII.GetBytes(postData);
                req.ContentLength = data.Length;

                using (var stream = req.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)req.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                string token = responseString.ToString();
                var x = token.Split('\\', '"');
                token = "";
                foreach (var a in x)
                {
                    if (token.Length < a.Length)
                        token = a;
                }

                MainForm form = new MainForm(token);
                form.Show();
                this.Hide();
            }
            catch(Exception ex) {
                MessageBox.Show("Ошибка авторизации " + ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = NewEmail.Text;
            string p1 = NewPassword.Text;
            string p2 = NewPassword2.Text;
            if (p1 != p2)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            UserModel u = new UserModel() { Email = email, Password = p1 };

            string site = "http://localhost:64332/";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(site + "api/Account/Register");
                request.ContentType = "application/json";
                
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(u);
                    streamWriter.Write(json);

                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                if(httpResponse.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Вы успешно зарегистрировались!");

                }
                
            }
            catch(Exception exc) {
                MessageBox.Show("Ошибка регистрации: " + exc.Message);
            }
        }
    }
}
