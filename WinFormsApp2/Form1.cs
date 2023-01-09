using MyDataService.Models;
using Newtonsoft.Json;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async Task Index()
        {
            List<Gubudik> listem = new List<Gubudik>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5126/store"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listem = JsonConvert.DeserializeObject<List<Gubudik>>(apiResponse);
                }
            }
            this.dataGridView1.DataSource = listem;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Index();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Index();
        }
        private void genel_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var title = btn.Text;
            Index();
        }
    }
}