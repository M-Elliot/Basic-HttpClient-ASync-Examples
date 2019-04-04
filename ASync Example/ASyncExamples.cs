using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Declare the required namespaces
using System.Threading.Tasks;
using System.Net.Http;

namespace ASync_Example
{
    //ASync Example Class
    class ASyncExamples
    {
        //Declare Local-Scope Variables 
        //private readonly HttpClientHandler OurHttpClientHandler; //Will Implement this soon
        private readonly HttpClient OurHttpClient;
        private readonly Dictionary<string, string> OurRequestFields;

        //Class Constructor
        public ASyncExamples()
        {
            //OurHttpClientHandler = new HttpClientHandler(); //Will Implement this soon
            OurHttpClient = new HttpClient();
            OurRequestFields = new Dictionary<string, string>();
        }

        //Public PostMethod (will update to receive content rather)
         public async Task<string> PostMethod()
        {
            //Assign our TestValue and Add it to the Dictionary
            OurRequestFields.Add("TestValue", "This is a test value 1 2 3...");

            //Await a response from the request to the Uri with our Dictionary as a FormUrlEncodedContent object, ConfigureAwait to avoid possible UI deadlocks
            HttpResponseMessage TempResponse = await OurHttpClient.PostAsync(new Uri("http://localhost/indox.php"), new FormUrlEncodedContent(OurRequestFields)).ConfigureAwait(false);

            //If the Request was a success await the Response Content read as a String, else return null
            if (TempResponse.IsSuccessStatusCode)
            {
                return await TempResponse.Content.ReadAsStringAsync();
            }
            else
            {
                return null;
            }
        }
    }
}
