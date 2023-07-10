using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MedicalCabinetUI
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        //HttpClient httpClient = null;
        MyApiClient client;
       /* [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();*/
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
            // httpClient = new HttpClient();
            // httpClient.BaseAddress = new Uri("http://localhost:7111");
            client = new MyApiClient();
           // AllocConsole();
           // Console.WriteLine("ttt");
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private async void materialFloatingActionButton1_Click_1(object sender, EventArgs e)
        {
            
           /* HttpClient cl = new HttpClient();

            var ob = await MyApiClient.GetJsonHttpClient("https://localhost:7111/api/MedicalStaff",cl);
           
            if (ob != null)
            {
                foreach (var item in ob) { listBox1.Items.Add("Item " + item.LastName); }

            }
            else { listBox1.Items.Add("null"); }*/
            
        }
    }
}
