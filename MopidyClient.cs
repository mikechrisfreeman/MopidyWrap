using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using MopidyWrap.Models;
using MopidyWrap.Requests.Core;

using Newtonsoft.Json;

namespace MopidyWrap
{
    public class MopidyClient
    {
        private string Endpoint;
        public bool Connected = false;
        MopidyVersion Version;

        public MopidyClient(string endpoint)
        {
            this.Endpoint = endpoint;
            Connected = Connect();
        }

        private bool Connect()
        {
            Version = POST<MopidyVersion, MopidyGetVersion>(new MopidyGetVersion());
            if (Version != null && Version.Error == null)
                return true;
            else
                return false;
        }

        public T POST<T, M>(M query)
        {
            T result = default(T);

            //MopidyGetVersion is a connection request - we allow this call through if we are not connected
            if (!Connected && !(query is MopidyGetVersion))
                return result;

            //Need to serialise the object
            string stringQuery = getJsonString<M>(query);

            //Sending the HttpRequest
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Endpoint);

            try
            {
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = stringQuery.Length;
                request.GetRequestStream().Write(System.Text.Encoding.UTF8.GetBytes(stringQuery), 0, stringQuery.Length);
                request.GetRequestStream().Close();
                HttpWebResponse response = null;

                //Processing the response
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader sr = new StreamReader(response.GetResponseStream());
                    string responseString = sr.ReadToEnd();

                    //For debug : TODO-REMOVE
                    Console.WriteLine(responseString);
                    result = JsonConvert.DeserializeObject<T>(responseString);
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
            }
            return result;
        }

        private string getJsonString<T>(T request)
        {

            string stringRequest = "";
            try
            {
                stringRequest = JsonConvert.SerializeObject(request);
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return stringRequest;
        }


    }
}
