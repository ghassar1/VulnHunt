using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
namespace VulnHunt
{
    public partial class Main : Form
    {
        CMD cmd;
        public Main()
        {
            InitializeComponent();
            cmd = new CMD(RichTextArea1);
        }

        private void Btn_Scan_Click(object sender, EventArgs e)
        {

           
            cmd.RunAsync();
           
        }

        private void RichTextArea_TextChanged(object sender, EventArgs e)
        {

        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // Metasploit API connection details
            string msgrpcUrl = "http://127.0.0.1:55552";
            string msgrpcUsername = "msf";
            string msgrpcPassword = "T2Wf0DbV";

            // Create an HttpClient with the appropriate authentication headers
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(msgrpcUrl);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{msgrpcUsername}:{msgrpcPassword}")));

                // Make a request to the Metasploit API to list available modules
                var response = await httpClient.PostAsync("/api/v1/modules", null);
                response.EnsureSuccessStatusCode();

                // Parse the response and print the module names
                var responseContent = await response.Content.ReadAsStringAsync();
                dynamic modules = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(responseContent);
                foreach (var module in modules)
                {
                    Console.WriteLine(module.name);
                }
            }
        }
    }
}
