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
            this.AddMedication = new System.Windows.Forms.TabPage();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddPatient = new System.Windows.Forms.TabPage();
            this.AddConsultation = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox3 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox4 = new MaterialSkin.Controls.MaterialMaskedTextBox();
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
            this.materialTabControl1.Size = new System.Drawing.Size(1093, 544);
            this.materialTabControl1.TabIndex = 1;
            // 
            // AddMedicalStaff
            // 
            this.AddMedicalStaff.BackColor = System.Drawing.Color.White;
            this.AddMedicalStaff.Controls.Add(this.materialMaskedTextBox4);
            this.AddMedicalStaff.Controls.Add(this.materialMaskedTextBox3);
            this.AddMedicalStaff.Controls.Add(this.materialMaskedTextBox2);
            this.AddMedicalStaff.Controls.Add(this.materialMaskedTextBox1);
            this.AddMedicalStaff.Controls.Add(this.materialButton1);
            this.AddMedicalStaff.Controls.Add(this.materialListView1);
            this.AddMedicalStaff.ImageKey = "medicalStaff_32px.png";
            this.AddMedicalStaff.Location = new System.Drawing.Point(4, 39);
            this.AddMedicalStaff.Name = "AddMedicalStaff";
            this.AddMedicalStaff.Padding = new System.Windows.Forms.Padding(3);
            this.AddMedicalStaff.Size = new System.Drawing.Size(1085, 501);
            this.AddMedicalStaff.TabIndex = 1;
            this.AddMedicalStaff.Text = "Add Medical Staff";
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
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(382, 33);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(544, 251);
            this.materialListView1.TabIndex = 4;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            this.columnHeader2.Width = 149;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Specialitatea";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Numar_telefon";
            this.columnHeader4.Width = 141;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(200, 177);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(84, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Refresh";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AccessibleName = "vbc";
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = null;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(17, 33);
            this.materialMaskedTextBox1.Mask = "";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(123, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 4;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialMaskedTextBox2
            // 
            this.materialMaskedTextBox2.AccessibleName = "vbc";
            this.materialMaskedTextBox2.AllowPromptAsInput = true;
            this.materialMaskedTextBox2.AnimateReadOnly = false;
            this.materialMaskedTextBox2.AsciiOnly = false;
            this.materialMaskedTextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox2.BeepOnError = false;
            this.materialMaskedTextBox2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox2.Depth = 0;
            this.materialMaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox2.HidePromptOnLeave = false;
            this.materialMaskedTextBox2.HideSelection = true;
            this.materialMaskedTextBox2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox2.LeadingIcon = null;
            this.materialMaskedTextBox2.Location = new System.Drawing.Point(161, 33);
            this.materialMaskedTextBox2.Mask = "";
            this.materialMaskedTextBox2.MaxLength = 32767;
            this.materialMaskedTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            this.materialMaskedTextBox2.PasswordChar = '\0';
            this.materialMaskedTextBox2.PrefixSuffixText = null;
            this.materialMaskedTextBox2.PromptChar = '_';
            this.materialMaskedTextBox2.ReadOnly = false;
            this.materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox2.ResetOnPrompt = true;
            this.materialMaskedTextBox2.ResetOnSpace = true;
            this.materialMaskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialMaskedTextBox2.SelectedText = "";
            this.materialMaskedTextBox2.SelectionLength = 0;
            this.materialMaskedTextBox2.SelectionStart = 0;
            this.materialMaskedTextBox2.ShortcutsEnabled = true;
            this.materialMaskedTextBox2.Size = new System.Drawing.Size(123, 48);
            this.materialMaskedTextBox2.SkipLiterals = true;
            this.materialMaskedTextBox2.TabIndex = 6;
            this.materialMaskedTextBox2.TabStop = false;
            this.materialMaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox2.TrailingIcon = null;
            this.materialMaskedTextBox2.UseSystemPasswordChar = false;
            this.materialMaskedTextBox2.ValidatingType = null;
            // 
            // materialMaskedTextBox3
            // 
            this.materialMaskedTextBox3.AccessibleName = "vbc";
            this.materialMaskedTextBox3.AllowPromptAsInput = true;
            this.materialMaskedTextBox3.AnimateReadOnly = false;
            this.materialMaskedTextBox3.AsciiOnly = false;
            this.materialMaskedTextBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox3.BeepOnError = false;
            this.materialMaskedTextBox3.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox3.Depth = 0;
            this.materialMaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox3.HidePromptOnLeave = false;
            this.materialMaskedTextBox3.HideSelection = true;
            this.materialMaskedTextBox3.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox3.LeadingIcon = null;
            this.materialMaskedTextBox3.Location = new System.Drawing.Point(17, 100);
            this.materialMaskedTextBox3.Mask = "";
            this.materialMaskedTextBox3.MaxLength = 32767;
            this.materialMaskedTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox3.Name = "materialMaskedTextBox3";
            this.materialMaskedTextBox3.PasswordChar = '\0';
            this.materialMaskedTextBox3.PrefixSuffixText = null;
            this.materialMaskedTextBox3.PromptChar = '_';
            this.materialMaskedTextBox3.ReadOnly = false;
            this.materialMaskedTextBox3.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox3.ResetOnPrompt = true;
            this.materialMaskedTextBox3.ResetOnSpace = true;
            this.materialMaskedTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialMaskedTextBox3.SelectedText = "";
            this.materialMaskedTextBox3.SelectionLength = 0;
            this.materialMaskedTextBox3.SelectionStart = 0;
            this.materialMaskedTextBox3.ShortcutsEnabled = true;
            this.materialMaskedTextBox3.Size = new System.Drawing.Size(123, 48);
            this.materialMaskedTextBox3.SkipLiterals = true;
            this.materialMaskedTextBox3.TabIndex = 7;
            this.materialMaskedTextBox3.TabStop = false;
            this.materialMaskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox3.TrailingIcon = null;
            this.materialMaskedTextBox3.UseSystemPasswordChar = false;
            this.materialMaskedTextBox3.ValidatingType = null;
            // 
            // materialMaskedTextBox4
            // 
            this.materialMaskedTextBox4.AccessibleName = "vbc";
            this.materialMaskedTextBox4.AllowPromptAsInput = true;
            this.materialMaskedTextBox4.AnimateReadOnly = false;
            this.materialMaskedTextBox4.AsciiOnly = false;
            this.materialMaskedTextBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox4.BeepOnError = false;
            this.materialMaskedTextBox4.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox4.Depth = 0;
            this.materialMaskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox4.HidePromptOnLeave = false;
            this.materialMaskedTextBox4.HideSelection = true;
            this.materialMaskedTextBox4.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox4.LeadingIcon = null;
            this.materialMaskedTextBox4.Location = new System.Drawing.Point(161, 100);
            this.materialMaskedTextBox4.Mask = "";
            this.materialMaskedTextBox4.MaxLength = 32767;
            this.materialMaskedTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox4.Name = "materialMaskedTextBox4";
            this.materialMaskedTextBox4.PasswordChar = '\0';
            this.materialMaskedTextBox4.PrefixSuffixText = null;
            this.materialMaskedTextBox4.PromptChar = '_';
            this.materialMaskedTextBox4.ReadOnly = false;
            this.materialMaskedTextBox4.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox4.ResetOnPrompt = true;
            this.materialMaskedTextBox4.ResetOnSpace = true;
            this.materialMaskedTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialMaskedTextBox4.SelectedText = "";
            this.materialMaskedTextBox4.SelectionLength = 0;
            this.materialMaskedTextBox4.SelectionStart = 0;
            this.materialMaskedTextBox4.ShortcutsEnabled = true;
            this.materialMaskedTextBox4.Size = new System.Drawing.Size(123, 48);
            this.materialMaskedTextBox4.SkipLiterals = true;
            this.materialMaskedTextBox4.TabIndex = 8;
            this.materialMaskedTextBox4.TabStop = false;
            this.materialMaskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox4.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox4.TrailingIcon = null;
            this.materialMaskedTextBox4.UseSystemPasswordChar = false;
            this.materialMaskedTextBox4.ValidatingType = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 611);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Medical Cabinet";
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
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox4;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox3;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
    }
}

