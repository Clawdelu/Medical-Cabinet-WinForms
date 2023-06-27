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
            this.AddPatient = new System.Windows.Forms.TabPage();
            this.AddConsultation = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // AddPatient
            // 
            this.AddPatient.BackColor = System.Drawing.Color.White;
            this.AddPatient.ImageKey = "patient.png";
            this.AddPatient.Location = new System.Drawing.Point(4, 39);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Padding = new System.Windows.Forms.Padding(3);
            this.AddPatient.Size = new System.Drawing.Size(786, 340);
            this.AddPatient.TabIndex = 0;
            this.AddPatient.Text = "Add Patient";
            // 
            // AddConsultation
            // 
            this.AddConsultation.BackColor = System.Drawing.Color.White;
            this.AddConsultation.ImageKey = "consultation_32px.png";
            this.AddConsultation.Location = new System.Drawing.Point(4, 39);
            this.AddConsultation.Name = "AddConsultation";
            this.AddConsultation.Size = new System.Drawing.Size(786, 340);
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
            this.materialListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
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
            this.materialListView1.Location = new System.Drawing.Point(6, 6);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(676, 345);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 338;
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
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

