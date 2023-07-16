using MaterialSkin.Controls;
using MedicalCabinetUI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCabinetUI
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        List<MedicalStaff> listOfMedicalStaff = null;
        List<Medication> listOfMedication = null;
        List<Patient> listOfPatient = null;
        List<Consultation> listOfConsultation = null;
        List<Cons_MedicDto> listConsMedic = null;
        private  bool isButtonVisible = false;
        private bool addMedicationVerify = false;

        // MyApiClient client;

        public Form1()
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
            await GetAllMedication();
            await GetAllPatient();
            await GetAllConsultations();

            listConsMedic = new List<Cons_MedicDto>();


            //------MEDICAL STAFF------
            MS_add_btn.Location = new Point(227, 238);
            MS_update_btn.Location = new Point(227, 238);
            MS_delete_btn.Location = new Point(227, 238);
            
            //----MEDICATION------
            M_add_btn.Location = new Point(230, 200);
            M_update_btn.Location = new Point(230, 200);
            M_delete_btn.Location = new Point(230, 200);
            //Init comboBox Medication
            init_medicalStaff_comboBox();

            //-----PATIENT------
            P_add_btn.Location = new Point(230, 269);
            P_update_btn.Location = new Point(230, 269);
            P_delete_btn.Location = new Point(230, 269);





        }
        private void init_medicalStaff_comboBox()
        {
            //----MEDICATION----
            M_medicalStaff_comboBox.DisplayMember = "LastName_FirstName";
            M_medicalStaff_comboBox.ValueMember = "Id";
            M_medicalStaff_comboBox.DataSource = listOfMedicalStaff.Select(p => new {
                Id = p.ID.ToString(),
                LastName_FirstName = p.LastName + " " + p.FirstName
            }).ToList();

            //----PATIENT------
            P_medicalStaff_comboBox.DisplayMember = "LastName_FirstName";
            P_medicalStaff_comboBox.ValueMember = "Id";
            P_medicalStaff_comboBox.DataSource = listOfMedicalStaff.Select(p => new {
                Id = p.ID.ToString(),
                LastName_FirstName = p.LastName + " " + p.FirstName
            }).ToList();


            //----consultation-----
            C_medicalStaff_comboBox.DisplayMember = "LastName_FirstName";
            C_medicalStaff_comboBox.ValueMember = "Id";
            C_medicalStaff_comboBox.DataSource = listOfMedicalStaff.Select(p => new {
                Id = p.ID.ToString(),
                LastName_FirstName = p.LastName + " " + p.FirstName
            }).ToList();

            C_patient_comboBox.DisplayMember = "LastName_FirstName";
            C_patient_comboBox.ValueMember = "Id";
            C_patient_comboBox.DataSource = listOfPatient.Select(p => new {
                Id = p.ID.ToString(),
                LastName_FirstName = p.LastName + " " + p.FirstName
            }).ToList();

            C_medication_comboBox.DisplayMember = "Name";
            C_medication_comboBox.ValueMember = "ID";
            C_medication_comboBox.DataSource = listOfMedication;



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
                
            }
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MSlastName_txtBox.Text) && !string.IsNullOrEmpty(MSfirstName_txtBox.Text) &&
                !string.IsNullOrEmpty(MSphoneNo_txtBox.Text) && MSspeciality_comboBox.SelectedIndex != -1)
            {
                
                await AddNewMedic();
                await GetAllMedicalStaff();
                MSlastName_txtBox.Clear();
                MSfirstName_txtBox.Clear();
                MSphoneNo_txtBox.Clear();
                MSspeciality_comboBox.StartIndex = -1;

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
        private async Task GetAllMedicalStaffHard()
        {
            listOfMedicalStaff = new List<MedicalStaff>();
            for (int i = medicalStaff_listView.Items.Count - 1; i >= 0; i--)
            {
                medicalStaff_listView.Items.RemoveAt(i);
            }
            HttpClient client = new HttpClient();
            listOfMedicalStaff = await MyApiClient.GetJsonHttpClientHard(client);
            if (listOfMedicalStaff == null)
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
        private async Task GetMedicByName()
        {
            listOfMedicalStaff = new List<MedicalStaff>();
            for (int i = medicalStaff_listView.Items.Count - 1; i >= 0; i--)
            {
                medicalStaff_listView.Items.RemoveAt(i);
            }
            HttpClient client = new HttpClient();
            string name = MS_firstNameSearch_txtBox.Text;
            listOfMedicalStaff = await MyApiClient.GetJsonHttpClientByName(client,name.ToUpper());
            if (listOfMedicalStaff == null)
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
        private async Task UpdateMedic()
        {
            HttpClient client = new HttpClient();
            MedicalStaffPOST medicalStaffPOST = new MedicalStaffPOST();
            medicalStaffPOST.LastName = MSlastName_txtBox.Text;
            medicalStaffPOST.FirstName = MSfirstName_txtBox.Text;
            medicalStaffPOST.Speciality = MSspeciality_comboBox.Text;
            medicalStaffPOST.PhoneNumber = MSphoneNo_txtBox.Text;

            ListViewItem selectedItem = medicalStaff_listView.SelectedItems[0];
            var indexSelItem = selectedItem.Index;
            Guid id = listOfMedicalStaff[indexSelItem].ID;
            await MyApiClient.PutJsonHttpClient(client, medicalStaffPOST, id);


        }
        private async Task DeleteMedicById()
        {
            HttpClient client = new HttpClient();
            if (medicalStaff_listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = medicalStaff_listView.SelectedItems[0];
                var indexSelItem = selectedItem.Index;
                Guid id = listOfMedicalStaff[indexSelItem].ID;
                await MyApiClient.DeleteResource(client, id);
            }
            else
            {
                MessageBox.Show("Please select a person to delete.");
            }
        }
        private async Task DeleteMedicByIdHard()
        {
            HttpClient client = new HttpClient();
            if (medicalStaff_listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = medicalStaff_listView.SelectedItems[0];
                var indexSelItem = selectedItem.Index;
                Guid id = listOfMedicalStaff[indexSelItem].ID;
                await MyApiClient.DeleteResourceHard(client, id);
            }
            else
            {
                MessageBox.Show("Please select a person to delete.");
            }
        }

        private async void materialButton2_Click(object sender, EventArgs e)
        {
            await DeleteMedicById();
            await GetAllMedicalStaff();
        }

      
        private void MS_CheckState_RadioBtn()
        {
            MSlastName_txtBox.Clear();
            MSfirstName_txtBox.Clear();
            MSphoneNo_txtBox.Clear();
            MSspeciality_comboBox.StartIndex = -1;
            medicalStaff_listView.SelectedItems.Clear();

            if (MS_ADD_radio.Checked == true)
            {
                MS_panel_control.Visible = true;
                MS_add_btn.Visible = true;
                MS_update_btn.Visible = false;
                MS_delete_btn.Visible = false;

                MSlastName_txtBox.Enabled = true;
                MSfirstName_txtBox.Enabled = true;
                MSphoneNo_txtBox.Enabled = true;
                MSspeciality_comboBox.Enabled = true;
            }
            else if (MS_UPDATE_radio.Checked == true)
            {
                MS_panel_control.Visible = true;
                MS_add_btn.Visible = false;
                MS_update_btn.Visible = true;
                MS_delete_btn.Visible = false;

                MSlastName_txtBox.Enabled = true;
                MSfirstName_txtBox.Enabled = true;
                MSphoneNo_txtBox.Enabled = true;
                MSspeciality_comboBox.Enabled = true;
            }
            else if (MS_DELETE_radio.Checked == true)
            {
                MS_panel_control.Visible = true;
                MS_add_btn.Visible = false;
                MS_update_btn.Visible = false;
                MS_delete_btn.Visible = true;

                MSlastName_txtBox.Enabled = false;
                MSfirstName_txtBox.Enabled = false;
                MSphoneNo_txtBox.Enabled=false;
                MSspeciality_comboBox.Enabled = false;


                
            }
        }
        private void MS_ADD_radio_Click(object sender, EventArgs e)
        {
            MS_CheckState_RadioBtn();
        }

        private void MS_DELETE_radio_Click(object sender, EventArgs e)
        {
            MS_CheckState_RadioBtn();
        }

        private void MS_UPDATE_radio_Click(object sender, EventArgs e)
        {
            MS_CheckState_RadioBtn();
        }

        private void medicalStaff_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (medicalStaff_listView.SelectedItems.Count > 0)
            {
                var selectedItem = medicalStaff_listView.SelectedItems[0];

                string lastName = selectedItem.SubItems[0].Text;
                string firstName = selectedItem.SubItems[1].Text;
                string speciality = selectedItem.SubItems[2].Text;
                string phoneNo = selectedItem.SubItems[3].Text;


                if (MS_DELETE_radio.Checked == true || MS_UPDATE_radio.Checked == true)
                {
                    MSlastName_txtBox.Text = lastName;
                    MSfirstName_txtBox.Text = firstName;
                    MSphoneNo_txtBox.Text = phoneNo;
                    int index = MSspeciality_comboBox.FindStringExact(speciality);
                    MSspeciality_comboBox.StartIndex = index;
                    //MSspeciality_comboBox.SelectedText = speciality;
                }
            }
        }

        private void materialTabControl1_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.R && e.Control && e.Shift)
             {
               
                isButtonVisible = !isButtonVisible; 
                MS_deleteHard_btn.Visible = isButtonVisible;
                MS_showAll_btn.Visible = isButtonVisible;
                MS_show_btn.Visible = isButtonVisible;
                MS_search_btn.Visible = isButtonVisible;
                MS_firstNameSearch_txtBox.Visible = isButtonVisible;
                MS_firstName_label.Visible = isButtonVisible;
            }
        }

        private async void MS_deleteHard_btn_Click(object sender, EventArgs e)
        {
            await DeleteMedicByIdHard();
            
        }

        private async void MS_show_btn_Click(object sender, EventArgs e)
        {
           await GetAllMedicalStaff();
        }

        private async void MS_showAll_btn_Click(object sender, EventArgs e)
        {
           await GetAllMedicalStaffHard();
        }

        private async void MS_search_btn_Click(object sender, EventArgs e)
        {
            await GetMedicByName();
        }

        private async void MS_update_btn_Click(object sender, EventArgs e)
        {
            await UpdateMedic();
            await GetAllMedicalStaff();
        }

        //-------------------------  MEDICATION  ---------------------------

        private void M_firstName_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Anulează evenimentul KeyPress
            }
        }

        private void M_add_radio_CheckedChanged(object sender, EventArgs e)
        {
            M_CheckState_RadioBtn();
        }

        private void M_delete_radio_Click(object sender, EventArgs e)
        {
            M_CheckState_RadioBtn();
        }

        private void M_update_radio_Click(object sender, EventArgs e)
        {
            M_CheckState_RadioBtn();
        }

        private async Task GetAllMedication()
        {
            listOfMedication = new List<Medication>();
            for (int i = M_listView.Items.Count - 1; i >= 0; i--)
            {
                M_listView.Items.RemoveAt(i);
            }
            HttpClient client = new HttpClient();
            listOfMedication = await MyApiClient.M_GetJsonHttpClient(client);
            if (listOfMedication == null)
            {
                M_listView.Items.Clear();
                M_listView.Visible = false;
                M_NODATA_label.Visible = true;

            }
            else
            {
                M_listView.Visible = true;
                M_NODATA_label.Visible = false;

                foreach (Medication medication in listOfMedication)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = medication.Name;
                    item.SubItems.Add(medication.AvailableQuantity.ToString());
                    item.SubItems.Add(medication.ExpirationDate.ToString("dd.MM.yyyy"));
                    var listMedicalStaffById = await MyApiClient.GetJsonHttpClientById(client, medication.ID_medicalStaff);
                    if(listMedicalStaffById != null)
                    {
                        item.SubItems.Add(listMedicalStaffById.LastName +" "+ listMedicalStaffById.FirstName);
                    }
                    M_listView.Items.Add(item);
                }

            }

        }
        private async Task AddNewMeidcation()
        {
            HttpClient client = new HttpClient();
            MedicationPOST medicationPOST = new MedicationPOST();
            medicationPOST.Name = M_name_txtBox.Text;
            medicationPOST.AvailableQuantity = int.Parse( M_avaibQA_txtBox.Text);
            medicationPOST.ExpirationDate = M_calendar.Value;
            medicationPOST.ID_medicalStaff = Guid.Parse( M_medicalStaff_comboBox.SelectedValue.ToString());
           
            await MyApiClient.M_PostJsonHttpClient(client, medicationPOST);


        }
        private async Task UpdateMedication()
        {
            HttpClient client = new HttpClient();
            MedicationPOST medicationPOST = new MedicationPOST();
            medicationPOST.Name = M_name_txtBox.Text;
            medicationPOST.AvailableQuantity = int.Parse(M_avaibQA_txtBox.Text);
            medicationPOST.ExpirationDate = M_calendar.Value;
            medicationPOST.ID_medicalStaff = Guid.Parse(M_medicalStaff_comboBox.SelectedValue.ToString());

            ListViewItem selectedItem = M_listView.SelectedItems[0];
            var indexSelItem = selectedItem.Index;
            Guid id = listOfMedication[indexSelItem].ID;
            await MyApiClient.M_PutJsonHttpClient(client, medicationPOST, id);


        }

        private async Task DeleteMedicationById()
        {
            HttpClient client = new HttpClient();
            if (M_listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = M_listView.SelectedItems[0];
                var indexSelItem = selectedItem.Index;
                Guid id = listOfMedication[indexSelItem].ID;
                await MyApiClient.M_DeleteResource(client, id);
            }
            else
            {
                MessageBox.Show("Please select a medication to delete.");
            }
        }


        private void M_CheckState_RadioBtn()
        {
            M_name_txtBox.Clear();
            M_avaibQA_txtBox.Clear();
            M_medicalStaff_comboBox.StartIndex = -1;
            M_listView.SelectedItems.Clear();
            P_dateOfBirth_timepicker.Value = DateTime.Now;

            if (M_add_radio.Checked == true)
            {
                M_panel.Visible = true;
                M_add_btn.Visible = true;
                M_update_btn.Visible = false;
                M_delete_btn.Visible = false;


                M_name_txtBox.Enabled = true;
                M_avaibQA_txtBox.Enabled = true;
                M_calendar.Enabled = true;
                M_medicalStaff_comboBox.Enabled = true;
               
            }
            else if (M_update_radio.Checked == true)
            {
                M_panel.Visible = true;
                M_add_btn.Visible = false;
                M_update_btn.Visible = true;
                M_delete_btn.Visible = false;


                M_name_txtBox.Enabled = true;
                M_avaibQA_txtBox.Enabled = true;
                M_calendar.Enabled = true;
                M_medicalStaff_comboBox.Enabled = true;
            }
            else if (M_delete_radio.Checked == true)
            {
                M_panel.Visible = true;
                M_add_btn.Visible = false;
                M_update_btn.Visible = false;
                M_delete_btn.Visible = true;


                M_name_txtBox.Enabled = false;
                M_avaibQA_txtBox.Enabled = false;
                M_calendar.Enabled = false;
                M_medicalStaff_comboBox.Enabled = false;
            }
        }

        private void M_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (M_listView.SelectedItems.Count > 0)
            {
                var selectedItem = M_listView.SelectedItems[0];

                string name = selectedItem.SubItems[0].Text;
                string avaibleQA = selectedItem.SubItems[1].Text;
                string dateOfExpiration = selectedItem.SubItems[2].Text;
                DateTime date = DateTime.Parse(dateOfExpiration);
                string fullNameMedicalStaff = selectedItem.SubItems[3].Text;    

                if (M_delete_radio.Checked == true || M_update_radio.Checked == true)
                {
                    M_name_txtBox.Text = name;
                    M_avaibQA_txtBox.Text = avaibleQA;
                    M_calendar.Value = date;                   
                    int index = M_medicalStaff_comboBox.FindStringExact(fullNameMedicalStaff);
                    M_medicalStaff_comboBox.StartIndex = index;
                }
            }
        }

        private async void M_add_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(M_name_txtBox.Text) && !string.IsNullOrEmpty(M_avaibQA_txtBox.Text) &&
                M_medicalStaff_comboBox.SelectedIndex != -1)
            {
                await AddNewMeidcation();
                await GetAllMedication();
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields!");
            }
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            test_label.Text = M_medicalStaff_comboBox.SelectedValue.ToString();
        }

        private  void M_medicalStaff_comboBox_Click(object sender, EventArgs e)
        {
            init_medicalStaff_comboBox();
        }

        private async void M_update_btn_Click(object sender, EventArgs e)
        {
            await UpdateMedication();
            await GetAllMedication();
        }

        private async void M_delete_btn_Click(object sender, EventArgs e)
        {
            await DeleteMedicationById();
            await GetAllMedication();
        }



        //----------------------------  PATIENT  -------------------------------------------------

        private void P_medicalStaff_comboBox_Click(object sender, EventArgs e)
        {
            init_medicalStaff_comboBox();
        }

        private void P_phoneNo_txtBox_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (P_phoneNo_txtBox.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void P_add_radio_CheckedChanged(object sender, EventArgs e)
        {
            P_CheckState_RadioBtn();
        }

        private void P_delete_radio_CheckedChanged(object sender, EventArgs e)
        {
            P_CheckState_RadioBtn();
        }

        private void P_update_radio_CheckedChanged(object sender, EventArgs e)
        {
            P_CheckState_RadioBtn();
        }
        private void P_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P_listView.SelectedItems.Count > 0)
            {
                var selectedItem = P_listView.SelectedItems[0];

                string lastName = selectedItem.SubItems[0].Text;
                string firstName = selectedItem.SubItems[1].Text;
                string dateOfBirth = selectedItem.SubItems[2].Text;
                DateTime date = DateTime.Parse(dateOfBirth);
                string address = selectedItem.SubItems[3].Text;
                string phoneNo = selectedItem.SubItems[4].Text;
                string fullNameMedicalStaff = selectedItem.SubItems[5].Text;


                if (P_delete_radio.Checked == true || P_update_radio.Checked == true)
                {
                    P_lastName_txtBox.Text = lastName;
                    P_firstName_txtBox.Text = firstName;
                    P_dateOfBirth_timepicker.Value = date;
                    P_address_txtBox.Text = address;
                    P_phoneNo_txtBox.Text = phoneNo;

                    int index = P_medicalStaff_comboBox.FindStringExact(fullNameMedicalStaff);
                    P_medicalStaff_comboBox.StartIndex = index;
                }
            }
        }
        private void P_CheckState_RadioBtn()
        {
            P_lastName_txtBox.Clear();
            P_firstName_txtBox.Clear();
            P_dateOfBirth_timepicker.Value = DateTime.Now;
            P_phoneNo_txtBox.Clear();
            P_address_txtBox.Clear();
            P_medicalStaff_comboBox.StartIndex = -1;
            P_listView.SelectedItems.Clear();
           

            if (P_add_radio.Checked == true)
            {
                P_panel.Visible = true;
                P_add_btn.Visible = true;
                P_update_btn.Visible = false;
                P_delete_btn.Visible = false;


                P_lastName_txtBox.Enabled = true;
                P_firstName_txtBox.Enabled = true;
                P_dateOfBirth_timepicker.Enabled = true;
                P_phoneNo_txtBox.Enabled = true;
                P_address_txtBox.Enabled = true;
                P_medicalStaff_comboBox.Enabled = true;
               

            }
            else if (P_update_radio.Checked == true)
            {
                P_panel.Visible = true;
                P_add_btn.Visible = false;
                P_update_btn.Visible = true;
                P_delete_btn.Visible = false;


                P_lastName_txtBox.Enabled = true;
                P_firstName_txtBox.Enabled = true;
                P_dateOfBirth_timepicker.Enabled = true;
                P_phoneNo_txtBox.Enabled = true;
                P_address_txtBox.Enabled = true;
                P_medicalStaff_comboBox.Enabled = true;
            }
            else if (P_delete_radio.Checked == true)
            {
                P_panel.Visible = true;
                P_add_btn.Visible = false;
                P_update_btn.Visible = false;
                P_delete_btn.Visible = true;


                P_lastName_txtBox.Enabled = false;
                P_firstName_txtBox.Enabled = false;
                P_dateOfBirth_timepicker.Enabled = false;
                P_phoneNo_txtBox.Enabled = false;
                P_address_txtBox.Enabled = false;
                P_medicalStaff_comboBox.Enabled = false;
            }
        }

        private async Task GetAllPatient()
        {
            listOfPatient = new List<Patient>();
            for (int i = P_listView.Items.Count - 1; i >= 0; i--)
            {
                P_listView.Items.RemoveAt(i);
            }
            HttpClient client = new HttpClient();
            listOfPatient = await MyApiClient.P_GetJsonHttpClient(client);
            if (listOfPatient == null)
            {
                P_listView.Items.Clear();
                P_listView.Visible = false;
                P_NODATA_label.Visible = true;

            }
            else
            {
                P_listView.Visible = true;
                P_NODATA_label.Visible = false;

                foreach (Patient patient in listOfPatient)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = patient.LastName;
                    item.SubItems.Add(patient.FirstName);                   
                    item.SubItems.Add(patient.DateOfBirth.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(patient.Address);
                    item.SubItems.Add(patient.PhoneNumber);

                    var listMedicalStaffById = await MyApiClient.GetJsonHttpClientById(client, patient.ID_medicalStaff);
                    if (listMedicalStaffById != null)
                    {
                        item.SubItems.Add(listMedicalStaffById.LastName + " " + listMedicalStaffById.FirstName);
                    }
                    P_listView.Items.Add(item);
                }

            }

        }

        private async Task AddNewPatient()
        {
            HttpClient client = new HttpClient();
            PatientPOST patientPOST = new PatientPOST();
            patientPOST.LastName = P_lastName_txtBox.Text;
            patientPOST.FirstName = P_firstName_txtBox.Text;
            patientPOST.DateOfBirth = P_dateOfBirth_timepicker.Value;
            patientPOST.Address = P_address_txtBox.Text;
            patientPOST.PhoneNumber = P_phoneNo_txtBox.Text;
            patientPOST.ID_medicalStaff = Guid.Parse(P_medicalStaff_comboBox.SelectedValue.ToString());       

            await MyApiClient.P_PostJsonHttpClient(client, patientPOST);

        }
        private async Task UpdatePatient()
        {
            HttpClient client = new HttpClient();
            PatientPOST patientPOST = new PatientPOST();
            patientPOST.LastName = P_lastName_txtBox.Text;
            patientPOST.FirstName = P_firstName_txtBox.Text;
            patientPOST.DateOfBirth = P_dateOfBirth_timepicker.Value;
            patientPOST.Address = P_address_txtBox.Text;
            patientPOST.PhoneNumber = P_phoneNo_txtBox.Text;
            patientPOST.ID_medicalStaff = Guid.Parse(P_medicalStaff_comboBox.SelectedValue.ToString());

            ListViewItem selectedItem = P_listView.SelectedItems[0];
            var indexSelItem = selectedItem.Index;
            Guid id = listOfPatient[indexSelItem].ID;
            await MyApiClient.P_PutJsonHttpClient(client, patientPOST, id);


        }

        private async Task DeletePatientById()
        {
            HttpClient client = new HttpClient();
            if (P_listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = P_listView.SelectedItems[0];
                var indexSelItem = selectedItem.Index;
                Guid id = listOfPatient[indexSelItem].ID;
                await MyApiClient.P_DeleteResource(client, id);
            }
            else
            {
                MessageBox.Show("Please select a patient to delete.");
            }
        }

        private async void P_add_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(P_lastName_txtBox.Text) && !string.IsNullOrEmpty(P_firstName_txtBox.Text) &&
               !string.IsNullOrEmpty(P_address_txtBox.Text) && !string.IsNullOrEmpty(P_phoneNo_txtBox.Text) &&
               P_medicalStaff_comboBox.SelectedIndex != -1)
            {
                await AddNewPatient();
                await GetAllPatient();
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields!");
            }
        }

        private async void P_delete_btn_Click(object sender, EventArgs e)
        {
            await DeletePatientById();
            await GetAllPatient();
        }

        private async void P_update_btn_Click(object sender, EventArgs e)
        {
            await UpdatePatient();
            await GetAllPatient();
        }

        private void P_phoneNo_txtBox_Leave(object sender, EventArgs e)
        {
            if ((P_phoneNo_txtBox.Text.Length < 10) && (P_phoneNo_txtBox.Text.Length > 0))
            {
                MessageBox.Show("Phone number must be 10 digits!");
                
            }
          
        }



        //----------------------------  CONSULTATION  -------------------------------------------------
        private void C_prescribedDose_txtBox_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (P_phoneNo_txtBox.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void C_period_txtBox_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (P_phoneNo_txtBox.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void C_CheckState_RadioBtn()
        {
            listConsMedic.Clear();
            C_patient_comboBox.StartIndex = -1;
            C_medicalStaff_comboBox.StartIndex = -1;
            C_symptoms_txtBox.Clear();
            C_diagnosis_txtBox.Clear();           
            C_date_timePicker.Value = DateTime.Now;
            
            C_medication_comboBox.SelectedIndex = -1;
            C_prescribedDose_txtBox.Clear();
            C_period_txtBox.Clear();
            
            C_listView.SelectedItems.Clear();
            C_med_listView.SelectedItems.Clear();
            C_med_listView.Items.Clear();

            if (C_add_radio.Checked == true)
            {
                C_panel.Visible = true;
                C_next_btn.Visible = true;
                C_addMedication_btn.Visible = true;
                C_update_btn.Visible = false;
                C_delete_btn.Visible = false;


                C_patient_comboBox.Enabled = true;
                C_medicalStaff_comboBox.Enabled = true;
                C_symptoms_txtBox.Enabled = true;
                C_diagnosis_txtBox.Enabled = true;
                C_date_timePicker.Enabled = true;
                C_medication_comboBox.Enabled = true;
                C_prescribedDose_txtBox.Enabled = true;
                C_period_txtBox.Enabled = true;


                C_medication_comboBox.Visible = true;
                C_prescribedDose_txtBox.Visible = true;
                C_period_txtBox.Visible = true;
                materialCard1.Visible = true;
                materialLabel24.Visible = true;
                materialLabel30.Visible = true;
                materialLabel31.Visible = true;

                C_med_listView.Visible = true;

            }
            else if (C_update_radio.Checked == true)
            {
                C_panel.Visible = true;
                C_next_btn.Visible = false;
                C_addMedication_btn.Visible = false;
                C_update_btn.Visible = true;
                C_delete_btn.Visible = false;


                C_patient_comboBox.Enabled = true;
                C_medicalStaff_comboBox.Enabled = true;
                C_symptoms_txtBox.Enabled = true;
                C_diagnosis_txtBox.Enabled = true;
                C_date_timePicker.Enabled = true;
                C_medication_comboBox.Enabled = true;
                C_prescribedDose_txtBox.Enabled = true;
                C_period_txtBox.Enabled = true;

                C_medication_comboBox.Visible = true;
                C_prescribedDose_txtBox.Visible = true;
                C_period_txtBox.Visible = true;
                materialCard1.Visible = true;
                materialLabel24.Visible = true;
                materialLabel30.Visible = true;
                materialLabel31.Visible = true;

                C_med_listView.Visible = true;
            }
            else if (C_delete_radio.Checked == true)
            {
                C_panel.Visible = true;
                C_next_btn.Visible = false;
                C_addMedication_btn.Visible = false;
                C_update_btn.Visible = false;
                C_delete_btn.Visible = true;


                C_patient_comboBox.Enabled = false;
                C_medicalStaff_comboBox.Enabled = false;
                C_symptoms_txtBox.Enabled = false;
                C_diagnosis_txtBox.Enabled = false;
                C_date_timePicker.Enabled = false;
                C_medication_comboBox.Enabled = false;
                C_prescribedDose_txtBox.Enabled = false;
                C_period_txtBox.Enabled = false;

                C_medication_comboBox.Visible = false;
                C_prescribedDose_txtBox.Visible = false;
                C_period_txtBox.Visible = false;
                materialCard1.Visible = false;
                materialLabel24.Visible = false;
                materialLabel30.Visible = false;
                materialLabel31.Visible = false;

                C_med_listView.Visible = false;
            }
        }

        private void C_add_radio_CheckedChanged(object sender, EventArgs e)
        {
            C_CheckState_RadioBtn();
        }

        private void C_delete_radio_CheckedChanged(object sender, EventArgs e)
        {
            C_CheckState_RadioBtn();
        }

        private void C_update_radio_CheckedChanged(object sender, EventArgs e)
        {
            C_CheckState_RadioBtn();
        }

        private void C_patient_comboBox_Click(object sender, EventArgs e)
        {
            init_medicalStaff_comboBox();
            /*C_patient_comboBox.StartIndex = -1;
            C_medicalStaff_comboBox.StartIndex = -1;
            C_medication_comboBox.StartIndex = -1;*/
        }

        private void C_medicalStaff_comboBox_Click(object sender, EventArgs e)
        {
           // init_medicalStaff_comboBox();
           /* C_patient_comboBox.StartIndex = -1;
            C_medicalStaff_comboBox.StartIndex = -1;
            C_medication_comboBox.StartIndex = -1;*/
        }

        private void C_medication_comboBox_Click(object sender, EventArgs e)
        {
          //  init_medicalStaff_comboBox();
           /* C_patient_comboBox.StartIndex = -1;
            C_medicalStaff_comboBox.StartIndex = -1;
            C_medication_comboBox.StartIndex = -1;*/
        }

        private async Task GetAllConsultations()
        {
            listOfConsultation = new List<Consultation>();
            for (int i = C_listView.Items.Count - 1; i >= 0; i--)
            {
                C_listView.Items.RemoveAt(i);
            }
            for (int i = C_med_listView.Items.Count - 1; i >= 0; i--)
            {
                C_med_listView.Items.RemoveAt(i);
            }

            HttpClient client = new HttpClient();
            listOfConsultation = await MyApiClient.C_GetJsonHttpClient(client);
            if (listOfConsultation == null)
            {
                C_listView.Items.Clear();
                C_listView.Visible = false;
                C_NODATA_lbl.Visible = true;

                C_med_listView.Items.Clear();
                C_med_listView.Visible = false;

            }
            else
            {
                C_listView.Visible = true;
                C_NODATA_lbl.Visible = false;
                C_med_listView.Visible = true;

                foreach (Consultation cons in listOfConsultation)
                {
                    ListViewItem item = new ListViewItem();
                    var patient = listOfPatient.Find(ob => ob.ID.Equals(cons.ID_Patient));
                    item.Text = patient.LastName+" "+ patient.FirstName;

                    var medicalStaff = listOfMedicalStaff.Find(ob => ob.ID.Equals(cons.ID_MedicalStaff));
                    item.SubItems.Add(medicalStaff.LastName+" "+medicalStaff.FirstName);


                    item.SubItems.Add(cons.DateOfConsultation.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(cons.Symptoms);
                    item.SubItems.Add(cons.Diagnosis);
                   
                    C_listView.Items.Add(item);

                   /* ListViewItem item1 = new ListViewItem();
                    foreach(var cons_med in cons.ListOfCons_Medic)
                    {
                        var medi = listOfMedication.Find(ob => ob.ID.Equals(cons_med.ID_medication));
                        item1.Text=medi.Name;
                        item1.SubItems.Add(cons_med.PrescribedDoseMedication.ToString());
                        item1.SubItems.Add(cons_med.PeriodOfTreatment.ToString());

                        C_med_listView.Items.Add(item1);
                    }*/
                    
                    
                }

            }



        }

        private async void materialButton1_Click_1(object sender, EventArgs e)
        {
            await GetAllConsultations();
        }

        private void C_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_listView.SelectedItems.Count > 0)
            {
                var selectedItem = C_listView.SelectedItems[0];

                string patient = selectedItem.SubItems[0].Text;
                string medicalStaff = selectedItem.SubItems[1].Text;
                string dateOfCons = selectedItem.SubItems[2].Text;
                DateTime date = DateTime.Parse(dateOfCons);
                string symptoms = selectedItem.SubItems[3].Text;
                string diagnosis = selectedItem.SubItems[4].Text;
                


                if (C_delete_radio.Checked == true || C_update_radio.Checked == true)
                {
                   int index1 = C_patient_comboBox.FindStringExact(patient);
                   C_patient_comboBox.StartIndex = index1;

                    int index2 = C_medicalStaff_comboBox.FindStringExact(patient);
                    C_medicalStaff_comboBox.StartIndex = index2;

                    C_symptoms_txtBox.Text = symptoms;
                    C_diagnosis_txtBox.Text = diagnosis;

                    C_date_timePicker.Value = date;
               
                }
                C_med_listView.Items.Clear();
                var indexSelItem = selectedItem.Index;
                var listcons_med = listOfConsultation[indexSelItem].ListOfCons_Medic;
                
               // ListViewItem item1 = new ListViewItem();
                foreach (var cons_med in listcons_med)
                {
                    ListViewItem item1 = new ListViewItem();
                    var medi = listOfMedication.Find(ob => ob.ID.Equals(cons_med.ID_medication));
                    item1.Text = medi.Name;
                    item1.SubItems.Add(cons_med.PrescribedDoseMedication.ToString());
                    item1.SubItems.Add(cons_med.PeriodOfTreatment.ToString());

                    C_med_listView.Items.Add(item1);
                }
                C_medication_comboBox.StartIndex = -1;
                C_prescribedDose_txtBox.Clear();
                C_period_txtBox.Clear();
            }
        }
        
        private void C_med_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_med_listView.SelectedItems.Count > 0)
            {
                var selectedItem = C_med_listView.SelectedItems[0];

                string medication = selectedItem.SubItems[0].Text;
                string presribedDose = selectedItem.SubItems[1].Text;
                string periodof = selectedItem.SubItems[2].Text;


                if (C_delete_radio.Checked == true || C_update_radio.Checked == true)
                {
                    int index1 = C_medication_comboBox.FindStringExact(medication);
                    C_medication_comboBox.StartIndex = index1;

                    C_prescribedDose_txtBox.Text = presribedDose;
                    C_period_txtBox.Text = periodof;

                }
            }
        }

        private void C_addMedication_btn_Click(object sender, EventArgs e)
        {
            if (C_medication_comboBox.StartIndex != -1 && !string.IsNullOrEmpty(C_prescribedDose_txtBox.Text) && !string.IsNullOrEmpty(C_period_txtBox.Text))
            {
                addMedicationVerify = true;
                Cons_MedicDto c = new Cons_MedicDto();
                c.ID_medication = Guid.Parse(C_medication_comboBox.SelectedValue.ToString());
                c.PrescribedDoseMedication = int.Parse(C_prescribedDose_txtBox.Text);
                c.PeriodOfTreatment = int.Parse(C_period_txtBox.Text);

                listConsMedic.Add(c);

                C_medication_comboBox.StartIndex = -1;
                C_prescribedDose_txtBox.Clear();
                C_period_txtBox.Clear();
            }
            else { MessageBox.Show("Please fill all fields!"); }
        }
        private async Task AddNewConsultation()
        {
            HttpClient client = new HttpClient();
            ConsultationPOST consultationPOST = new ConsultationPOST();
            consultationPOST.ID_Patient = Guid.Parse(C_patient_comboBox.SelectedValue.ToString());
            consultationPOST.ID_MedicalStaff = Guid.Parse(C_medicalStaff_comboBox.SelectedValue.ToString());
            consultationPOST.DateOfConsultation = C_date_timePicker.Value;
            consultationPOST.Symptoms = C_symptoms_txtBox.Text;
            consultationPOST.Diagnosis = C_diagnosis_txtBox.Text;
            consultationPOST.ListConsMedic = listConsMedic;

            await MyApiClient.C_PostJsonHttpClient(client, consultationPOST);



        }
        private async Task UpdateConsultation()
        {
            if (!string.IsNullOrEmpty(C_prescribedDose_txtBox.Text) /*&& !string.IsNullOrEmpty(C_period_txtBox.Text) && C_patient_comboBox.StartIndex != -1
                && C_medicalStaff_comboBox.StartIndex != -1 && !string.IsNullOrEmpty(C_symptoms_txtBox.Text) 
                && !string.IsNullOrEmpty(C_diagnosis_txtBox.Text) && C_medication_comboBox.StartIndex != -1*/)
            {

                HttpClient client = new HttpClient();

                ListViewItem selectedItem = C_listView.SelectedItems[0];
                var indexSelItem = selectedItem.Index;
                Guid id = listOfConsultation[indexSelItem].ID;

                ConsultationPUT consultationPUT = new ConsultationPUT();
                consultationPUT.ID_Patient = Guid.Parse(C_patient_comboBox.SelectedValue.ToString());
                consultationPUT.ID_MedicalStaff = Guid.Parse(C_medicalStaff_comboBox.SelectedValue.ToString());
                consultationPUT.DateOfConsultation = C_date_timePicker.Value;
                consultationPUT.Symptoms = C_symptoms_txtBox.Text;
                consultationPUT.Diagnosis = C_diagnosis_txtBox.Text;


                List<Cons_medic> list = new List<Cons_medic>();
                Cons_medic c = new Cons_medic();
                c.ID_medication = Guid.Parse(C_medication_comboBox.SelectedValue.ToString());
                c.PrescribedDoseMedication = int.Parse(C_prescribedDose_txtBox.Text);
                c.PeriodOfTreatment = int.Parse(C_period_txtBox.Text);
                c.ID_consultation = id;

                var selectedItem1 = C_listView.SelectedItems[0];
                var indexSelItem1 = selectedItem1.Index;
                var listcons_med = listOfConsultation[indexSelItem1].ListOfCons_Medic;

                var selectedItem2 = C_med_listView.SelectedItems[0];
                var indexSelItem2 = selectedItem2.Index;
                c.ID = listcons_med[indexSelItem2].ID;

                list.Add(c);


                consultationPUT.ListConsMedic = list;


                await MyApiClient.C_PutJsonHttpClient(client, consultationPUT, id);
            }
            else { MessageBox.Show("Choose the medication for update!"); }

        }

        private async Task DeleteConsultationById()
        {
            HttpClient client = new HttpClient();
            if (C_listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = C_listView.SelectedItems[0];
                var indexSelItem = selectedItem.Index;
                Guid id = listOfConsultation[indexSelItem].ID;
                await MyApiClient.C_DeleteResource(client, id);
            }
            else
            {
                MessageBox.Show("Please select a patient to delete.");
            }
        }

        private async void C_delete_btn_Click(object sender, EventArgs e)
        {
            await DeleteConsultationById();
            await GetAllConsultations();
        }

        private async void C_update_btn_Click(object sender, EventArgs e)
        {
            await UpdateConsultation();
            await GetAllConsultations();
        }

        private async void C_next_btn_Click(object sender, EventArgs e)
        {
            
            if (addMedicationVerify==true && C_patient_comboBox.StartIndex != -1)
            {
                await AddNewConsultation();
                await GetAllConsultations();

                C_patient_comboBox.StartIndex=-1;
                C_medicalStaff_comboBox.StartIndex = -1;
                C_symptoms_txtBox.Clear();
                C_diagnosis_txtBox.Clear();
                C_date_timePicker.Value = DateTime.Now;

                C_medication_comboBox.StartIndex = -1;
                C_prescribedDose_txtBox.Clear();
                C_period_txtBox.Clear();


                listConsMedic.Clear();
                addMedicationVerify = false;
            }
            else { MessageBox.Show("Please add an medication or complete all fields!");
                
            }

        }
    }
}
