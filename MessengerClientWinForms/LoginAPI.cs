using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ASPServer;
using Newtonsoft.Json;
using RestSharp;

namespace MessengerClientWinForms
{
    class LoginAPI
    {
        private static readonly HttpClient client = new HttpClient();

        public bool SendAuthorization(User User)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://localhost:5000/api/Login");
                request.Method = "POST";
                //Message msg = new Message("RusAl", "Privet1100", DateTime.Now);
                string postData = JsonConvert.SerializeObject(User);
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                //Console.WriteLine(responseFromServer);
                reader.Close();
                dataStream.Close();
                response.Close();
                return true;
            }
            catch { return false; }
        }

        public bool SendRegistration(User User)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://localhost:5000/api/Login/Registration");
                request.Method = "POST";
                //Message msg = new Message("RusAl", "Privet1100", DateTime.Now);
                string postData = JsonConvert.SerializeObject(User);
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                //Console.WriteLine(responseFromServer);
                reader.Close();
                dataStream.Close();
                response.Close();
                return true;
            }
            catch { return false; }
        }
    }
}