using MaterialSkin.Controls;
using MedicalCabinetUI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicalCabinetUI
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        List<MedicalStaff> listOfMedicalStaff = null;
       // MyApiClient client;

        public  Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
            // client = new MyApiClient();                      
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await GetAllMedicalStaff();
        }

        private void materialMaskedTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                // is a digit or backspace - ignore digits if length is alreay 10 - allow backspace
                if (Char.IsDigit(e.KeyChar))
                {
                    if (MSphoneNo_txtBox.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void phoneNo_medicalStaff_Leave(object sender, EventArgs e)
        {
            if ((MSphoneNo_txtBox.Text.Length < 10) && (MSphoneNo_txtBox.Text.Length > 0))
            {
                MessageBox.Show("Phone number must be 10 digits!");
                //phoneNo_medicalStaff.Focus();
            }
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MSlastName_txtBox.Text) && !string.IsNullOrEmpty(MSfirstName_txtBox.Text) &&
                !string.IsNullOrEmpty(MSphoneNo_txtBox.Text) && MSspeciality_comboBox.SelectedIndex != -1)
            {
                await AddNewMedic();
                await GetAllMedicalStaff();
               
            }
            else
            {             
                MessageBox.Show("Please fill in all the required fields!");
            }
        }
       

        private async Task GetAllMedicalStaff()
        {
            listOfMedicalStaff = new List<MedicalStaff>();
            for (int i = medicalStaff_listView.Items.Count - 1; i >= 0; i--)
            {
                medicalStaff_listView.Items.RemoveAt(i);
            }
            HttpClient client = new HttpClient();
             listOfMedicalStaff = await MyApiClient.GetJsonHttpClient(client);
            if(listOfMedicalStaff == null)
            {
                medicalStaff_listView.Items.Clear();
                medicalStaff_listView.Visible = false;
                medicalStaff_labelNODATA.Visible = true;

            }
            else
            {
                medicalStaff_listView.Visible = true;
                medicalStaff_labelNODATA.Visible = false;

                foreach (MedicalStaff staff in listOfMedicalStaff)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = staff.LastName;
                    item.SubItems.Add(staff.FirstName);
                    item.SubItems.Add(staff.Speciality);
                    item.SubItems.Add(staff.PhoneNumber);

                    medicalStaff_listView.Items.Add(item);
                }

            }

        }
        private async Task AddNewMedic()
        {
            HttpClient client = new HttpClient();
            MedicalStaffPOST medicalStaffPOST = new MedicalStaffPOST();
            medicalStaffPOST.LastName = MSlastName_txtBox.Text;
            medicalStaffPOST.FirstName = MSfirstName_txtBox.Text;
            medicalStaffPOST.Speciality = MSspeciality_comboBox.Text;
            medicalStaffPOST.PhoneNumber = MSphoneNo_txtBox.Text;
            await MyApiClient.PostJsonHttpClient(client, medicalStaffPOST);
            

        }
        private async Task DeleteMedicById()
        {
            HttpClient client = new HttpClient();
            ListViewItem selectedItem = medicalStaff_listView.SelectedItems[0];
            var indexSelItem = selectedItem.Index;
            Guid id = listOfMedicalStaff[indexSelItem].ID;
            await MyApiClient.DeleteResource(client, id);
        }

        private async void materialButton2_Click(object sender, EventArgs e)
        {
            await DeleteMedicById();
            await GetAllMedicalStaff();
        }

      

        private void medicalStaff_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            MSremove_btn.Visible = true;
        }
    }
}
