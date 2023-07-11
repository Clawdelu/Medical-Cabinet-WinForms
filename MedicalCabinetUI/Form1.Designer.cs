namespace MedicalCabinetUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.AddMedicalStaff = new System.Windows.Forms.TabPage();
            this.MSremove_btn = new MaterialSkin.Controls.MaterialButton();
            this.MSspeciality_comboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.MSphoneNo_txtBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.MSfirstName_txtBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.MSlastName_txtBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.medicalStaff_listView = new MaterialSkin.Controls.MaterialListView();
            this.AddMedication = new System.Windows.Forms.TabPage();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddPatient = new System.Windows.Forms.TabPage();
            this.AddConsultation = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.medicalStaff_labelNODATA = new MaterialSkin.Controls.MaterialLabel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1.SuspendLayout();
            this.AddMedicalStaff.SuspendLayout();
            this.AddMedication.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.AddMedicalStaff);
            this.materialTabControl1.Controls.Add(this.AddMedication);
            this.materialTabControl1.Controls.Add(this.AddPatient);
            this.materialTabControl1.Controls.Add(this.AddConsultation);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1019, 388);
            this.materialTabControl1.TabIndex = 1;
            // 
            // AddMedicalStaff
            // 
            this.AddMedicalStaff.BackColor = System.Drawing.Color.White;
            this.AddMedicalStaff.Controls.Add(this.medicalStaff_labelNODATA);
            this.AddMedicalStaff.Controls.Add(this.MSremove_btn);
            this.AddMedicalStaff.Controls.Add(this.MSspeciality_comboBox);
            this.AddMedicalStaff.Controls.Add(this.materialLabel4);
            this.AddMedicalStaff.Controls.Add(this.MSphoneNo_txtBox);
            this.AddMedicalStaff.Controls.Add(this.materialLabel3);
            this.AddMedicalStaff.Controls.Add(this.materialLabel2);
            this.AddMedicalStaff.Controls.Add(this.MSfirstName_txtBox);
            this.AddMedicalStaff.Controls.Add(this.materialLabel1);
            this.AddMedicalStaff.Controls.Add(this.MSlastName_txtBox);
            this.AddMedicalStaff.Controls.Add(this.materialButton1);
            this.AddMedicalStaff.Controls.Add(this.medicalStaff_listView);
            this.AddMedicalStaff.ImageKey = "medicalStaff_32px.png";
            this.AddMedicalStaff.Location = new System.Drawing.Point(4, 39);
            this.AddMedicalStaff.Name = "AddMedicalStaff";
            this.AddMedicalStaff.Padding = new System.Windows.Forms.Padding(3);
            this.AddMedicalStaff.Size = new System.Drawing.Size(1011, 345);
            this.AddMedicalStaff.TabIndex = 1;
            this.AddMedicalStaff.Text = "Add Medical Staff";
            // 
            // MSremove_btn
            // 
            this.MSremove_btn.AutoSize = false;
            this.MSremove_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MSremove_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MSremove_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MSremove_btn.Depth = 0;
            this.MSremove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MSremove_btn.HighEmphasis = true;
            this.MSremove_btn.Icon = null;
            this.MSremove_btn.Location = new System.Drawing.Point(304, 250);
            this.MSremove_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MSremove_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MSremove_btn.Name = "MSremove_btn";
            this.MSremove_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MSremove_btn.Size = new System.Drawing.Size(86, 48);
            this.MSremove_btn.TabIndex = 18;
            this.MSremove_btn.Text = "Remove";
            this.MSremove_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MSremove_btn.UseAccentColor = false;
            this.MSremove_btn.UseVisualStyleBackColor = true;
            this.MSremove_btn.Visible = false;
            this.MSremove_btn.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // MSspeciality_comboBox
            // 
            this.MSspeciality_comboBox.AutoResize = false;
            this.MSspeciality_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MSspeciality_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MSspeciality_comboBox.Depth = 0;
            this.MSspeciality_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MSspeciality_comboBox.DropDownHeight = 174;
            this.MSspeciality_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MSspeciality_comboBox.DropDownWidth = 121;
            this.MSspeciality_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MSspeciality_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MSspeciality_comboBox.FormattingEnabled = true;
            this.MSspeciality_comboBox.IntegralHeight = false;
            this.MSspeciality_comboBox.ItemHeight = 43;
            this.MSspeciality_comboBox.Items.AddRange(new object[] {
            "Medic ORL",
            "Asistent medical ORL",
            "Medic oftalmologie",
            "Asistent medical oftalmologie",
            "Medic cardiologie",
            "Asistent medical cardiologie",
            "Medic generalist",
            "Asistent medical generalist",
            "Medic pediatrie",
            "Asistent medical pediatrie"});
            this.MSspeciality_comboBox.Location = new System.Drawing.Point(3, 150);
            this.MSspeciality_comboBox.MaxDropDownItems = 4;
            this.MSspeciality_comboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MSspeciality_comboBox.Name = "MSspeciality_comboBox";
            this.MSspeciality_comboBox.Size = new System.Drawing.Size(387, 49);
            this.MSspeciality_comboBox.StartIndex = -1;
            this.MSspeciality_comboBox.TabIndex = 17;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 228);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(104, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Phone number";
            // 
            // MSphoneNo_txtBox
            // 
            this.MSphoneNo_txtBox.AccessibleName = "";
            this.MSphoneNo_txtBox.AllowPromptAsInput = true;
            this.MSphoneNo_txtBox.AnimateReadOnly = false;
            this.MSphoneNo_txtBox.AsciiOnly = false;
            this.MSphoneNo_txtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MSphoneNo_txtBox.BeepOnError = false;
            this.MSphoneNo_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MSphoneNo_txtBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MSphoneNo_txtBox.Depth = 0;
            this.MSphoneNo_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MSphoneNo_txtBox.HidePromptOnLeave = false;
            this.MSphoneNo_txtBox.HideSelection = true;
            this.MSphoneNo_txtBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MSphoneNo_txtBox.LeadingIcon = null;
            this.MSphoneNo_txtBox.Location = new System.Drawing.Point(6, 250);
            this.MSphoneNo_txtBox.Mask = "";
            this.MSphoneNo_txtBox.MaxLength = 32767;
            this.MSphoneNo_txtBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MSphoneNo_txtBox.Name = "MSphoneNo_txtBox";
            this.MSphoneNo_txtBox.PasswordChar = '\0';
            this.MSphoneNo_txtBox.PrefixSuffixText = null;
            this.MSphoneNo_txtBox.PromptChar = '_';
            this.MSphoneNo_txtBox.ReadOnly = false;
            this.MSphoneNo_txtBox.RejectInputOnFirstFailure = false;
            this.MSphoneNo_txtBox.ResetOnPrompt = true;
            this.MSphoneNo_txtBox.ResetOnSpace = true;
            this.MSphoneNo_txtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MSphoneNo_txtBox.SelectedText = "";
            this.MSphoneNo_txtBox.SelectionLength = 0;
            this.MSphoneNo_txtBox.SelectionStart = 0;
            this.MSphoneNo_txtBox.ShortcutsEnabled = true;
            this.MSphoneNo_txtBox.Size = new System.Drawing.Size(185, 48);
            this.MSphoneNo_txtBox.SkipLiterals = true;
            this.MSphoneNo_txtBox.TabIndex = 15;
            this.MSphoneNo_txtBox.TabStop = false;
            this.MSphoneNo_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MSphoneNo_txtBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MSphoneNo_txtBox.TrailingIcon = null;
            this.MSphoneNo_txtBox.UseSystemPasswordChar = false;
            this.MSphoneNo_txtBox.ValidatingType = null;
            this.MSphoneNo_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialMaskedTextBox2_KeyPress);
            this.MSphoneNo_txtBox.Leave += new System.EventHandler(this.phoneNo_medicalStaff_Leave);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(9, 128);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Speciality";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(208, 25);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "First name";
            // 
            // MSfirstName_txtBox
            // 
            this.MSfirstName_txtBox.AccessibleName = "";
            this.MSfirstName_txtBox.AllowPromptAsInput = true;
            this.MSfirstName_txtBox.AnimateReadOnly = false;
            this.MSfirstName_txtBox.AsciiOnly = false;
            this.MSfirstName_txtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MSfirstName_txtBox.BeepOnError = false;
            this.MSfirstName_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MSfirstName_txtBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MSfirstName_txtBox.Depth = 0;
            this.MSfirstName_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MSfirstName_txtBox.HidePromptOnLeave = false;
            this.MSfirstName_txtBox.HideSelection = true;
            this.MSfirstName_txtBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MSfirstName_txtBox.LeadingIcon = null;
            this.MSfirstName_txtBox.Location = new System.Drawing.Point(208, 47);
            this.MSfirstName_txtBox.Mask = "";
            this.MSfirstName_txtBox.MaxLength = 32767;
            this.MSfirstName_txtBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MSfirstName_txtBox.Name = "MSfirstName_txtBox";
            this.MSfirstName_txtBox.PasswordChar = '\0';
            this.MSfirstName_txtBox.PrefixSuffixText = null;
            this.MSfirstName_txtBox.PromptChar = '_';
            this.MSfirstName_txtBox.ReadOnly = false;
            this.MSfirstName_txtBox.RejectInputOnFirstFailure = false;
            this.MSfirstName_txtBox.ResetOnPrompt = true;
            this.MSfirstName_txtBox.ResetOnSpace = true;
            this.MSfirstName_txtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MSfirstName_txtBox.SelectedText = "";
            this.MSfirstName_txtBox.SelectionLength = 0;
            this.MSfirstName_txtBox.SelectionStart = 0;
            this.MSfirstName_txtBox.ShortcutsEnabled = true;
            this.MSfirstName_txtBox.Size = new System.Drawing.Size(182, 48);
            this.MSfirstName_txtBox.SkipLiterals = true;
            this.MSfirstName_txtBox.TabIndex = 11;
            this.MSfirstName_txtBox.TabStop = false;
            this.MSfirstName_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MSfirstName_txtBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MSfirstName_txtBox.TrailingIcon = null;
            this.MSfirstName_txtBox.UseSystemPasswordChar = false;
            this.MSfirstName_txtBox.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Last name";
            // 
            // MSlastName_txtBox
            // 
            this.MSlastName_txtBox.AccessibleName = "";
            this.MSlastName_txtBox.AllowPromptAsInput = true;
            this.MSlastName_txtBox.AnimateReadOnly = false;
            this.MSlastName_txtBox.AsciiOnly = false;
            this.MSlastName_txtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MSlastName_txtBox.BeepOnError = false;
            this.MSlastName_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MSlastName_txtBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MSlastName_txtBox.Depth = 0;
            this.MSlastName_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MSlastName_txtBox.HidePromptOnLeave = false;
            this.MSlastName_txtBox.HideSelection = true;
            this.MSlastName_txtBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.MSlastName_txtBox.LeadingIcon = null;
            this.MSlastName_txtBox.Location = new System.Drawing.Point(6, 47);
            this.MSlastName_txtBox.Mask = "";
            this.MSlastName_txtBox.MaxLength = 32767;
            this.MSlastName_txtBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MSlastName_txtBox.Name = "MSlastName_txtBox";
            this.MSlastName_txtBox.PasswordChar = '\0';
            this.MSlastName_txtBox.PrefixSuffixText = null;
            this.MSlastName_txtBox.PromptChar = '_';
            this.MSlastName_txtBox.ReadOnly = false;
            this.MSlastName_txtBox.RejectInputOnFirstFailure = false;
            this.MSlastName_txtBox.ResetOnPrompt = true;
            this.MSlastName_txtBox.ResetOnSpace = true;
            this.MSlastName_txtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MSlastName_txtBox.SelectedText = "";
            this.MSlastName_txtBox.SelectionLength = 0;
            this.MSlastName_txtBox.SelectionStart = 0;
            this.MSlastName_txtBox.ShortcutsEnabled = true;
            this.MSlastName_txtBox.Size = new System.Drawing.Size(185, 48);
            this.MSlastName_txtBox.SkipLiterals = true;
            this.MSlastName_txtBox.TabIndex = 8;
            this.MSlastName_txtBox.TabStop = false;
            this.MSlastName_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MSlastName_txtBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.MSlastName_txtBox.TrailingIcon = null;
            this.MSlastName_txtBox.UseSystemPasswordChar = false;
            this.MSlastName_txtBox.ValidatingType = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(208, 250);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(86, 48);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Add";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // medicalStaff_listView
            // 
            this.medicalStaff_listView.AutoSizeTable = false;
            this.medicalStaff_listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.medicalStaff_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicalStaff_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.medicalStaff_listView.Depth = 0;
            this.medicalStaff_listView.FullRowSelect = true;
            this.medicalStaff_listView.HideSelection = false;
            this.medicalStaff_listView.Location = new System.Drawing.Point(434, 47);
            this.medicalStaff_listView.MinimumSize = new System.Drawing.Size(200, 100);
            this.medicalStaff_listView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.medicalStaff_listView.MouseState = MaterialSkin.MouseState.OUT;
            this.medicalStaff_listView.Name = "medicalStaff_listView";
            this.medicalStaff_listView.OwnerDraw = true;
            this.medicalStaff_listView.Size = new System.Drawing.Size(500, 251);
            this.medicalStaff_listView.TabIndex = 4;
            this.medicalStaff_listView.UseCompatibleStateImageBehavior = false;
            this.medicalStaff_listView.View = System.Windows.Forms.View.Details;
            this.medicalStaff_listView.SelectedIndexChanged += new System.EventHandler(this.medicalStaff_listView_SelectedIndexChanged);
            // 
            // AddMedication
            // 
            this.AddMedication.BackColor = System.Drawing.Color.White;
            this.AddMedication.Controls.Add(this.materialListView2);
            this.AddMedication.ImageKey = "medication_32px.png";
            this.AddMedication.Location = new System.Drawing.Point(4, 39);
            this.AddMedication.Name = "AddMedication";
            this.AddMedication.Size = new System.Drawing.Size(1085, 501);
            this.AddMedication.TabIndex = 2;
            this.AddMedication.Text = "Add Medication";
            // 
            // materialListView2
            // 
            this.materialListView2.AutoSizeTable = false;
            this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.materialListView2.Depth = 0;
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HideSelection = false;
            this.materialListView2.Location = new System.Drawing.Point(3, 3);
            this.materialListView2.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(526, 191);
            this.materialListView2.TabIndex = 0;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // AddPatient
            // 
            this.AddPatient.BackColor = System.Drawing.Color.White;
            this.AddPatient.ImageKey = "patient.png";
            this.AddPatient.Location = new System.Drawing.Point(4, 39);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Padding = new System.Windows.Forms.Padding(3);
            this.AddPatient.Size = new System.Drawing.Size(1085, 501);
            this.AddPatient.TabIndex = 0;
            this.AddPatient.Text = "Add Patient";
            // 
            // AddConsultation
            // 
            this.AddConsultation.BackColor = System.Drawing.Color.White;
            this.AddConsultation.ImageKey = "consultation_32px.png";
            this.AddConsultation.Location = new System.Drawing.Point(4, 39);
            this.AddConsultation.Name = "AddConsultation";
            this.AddConsultation.Size = new System.Drawing.Size(1085, 501);
            this.AddConsultation.TabIndex = 3;
            this.AddConsultation.Text = "Add Consultation";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "patient.png");
            this.imageList1.Images.SetKeyName(1, "medicalStaff_32px.png");
            this.imageList1.Images.SetKeyName(2, "consultation_32px.png");
            this.imageList1.Images.SetKeyName(3, "medication_32px.png");
            this.imageList1.Images.SetKeyName(4, "asdf.png");
            // 
            // medicalStaff_labelNODATA
            // 
            this.medicalStaff_labelNODATA.AutoSize = true;
            this.medicalStaff_labelNODATA.Depth = 0;
            this.medicalStaff_labelNODATA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.medicalStaff_labelNODATA.Location = new System.Drawing.Point(639, 150);
            this.medicalStaff_labelNODATA.MouseState = MaterialSkin.MouseState.HOVER;
            this.medicalStaff_labelNODATA.Name = "medicalStaff_labelNODATA";
            this.medicalStaff_labelNODATA.Size = new System.Drawing.Size(216, 19);
            this.medicalStaff_labelNODATA.TabIndex = 19;
            this.medicalStaff_labelNODATA.Text = "There are no medical staff yet.";
            this.medicalStaff_labelNODATA.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Last name";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First name";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Speciality";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone number";
            this.columnHeader4.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 455);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Medical Cabinet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.AddMedicalStaff.ResumeLayout(false);
            this.AddMedicalStaff.PerformLayout();
            this.AddMedication.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage AddPatient;
        private System.Windows.Forms.TabPage AddMedicalStaff;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage AddMedication;
        private System.Windows.Forms.TabPage AddConsultation;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialListView medicalStaff_listView;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox MSlastName_txtBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox MSfirstName_txtBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialMaskedTextBox MSphoneNo_txtBox;
        private MaterialSkin.Controls.MaterialComboBox MSspeciality_comboBox;
        private MaterialSkin.Controls.MaterialButton MSremove_btn;
        private MaterialSkin.Controls.MaterialLabel medicalStaff_labelNODATA;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

