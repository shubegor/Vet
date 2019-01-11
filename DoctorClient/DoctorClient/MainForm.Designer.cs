namespace DoctorClient
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ServiceGrid = new System.Windows.Forms.DataGridView();
            this.DateTimeService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonServ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.DocName = new System.Windows.Forms.Label();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ServiceGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Записи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ServiceGrid
            // 
            this.ServiceGrid.AutoGenerateColumns = false;
            this.ServiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIdDataGridViewTextBoxColumn,
            this.DateTimeService,
            this.doctorNameDataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn,
            this.Date,
            this.Time,
            this.petNameDataGridViewTextBoxColumn,
            this.ButtonServ});
            this.ServiceGrid.DataSource = this.serviceModelBindingSource;
            this.ServiceGrid.Location = new System.Drawing.Point(6, 6);
            this.ServiceGrid.Name = "ServiceGrid";
            this.ServiceGrid.RowTemplate.Height = 24;
            this.ServiceGrid.Size = new System.Drawing.Size(768, 409);
            this.ServiceGrid.TabIndex = 0;
            this.ServiceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DateTimeService
            // 
            this.DateTimeService.DataPropertyName = "DateTimeService";
            this.DateTimeService.HeaderText = "DateTimeService";
            this.DateTimeService.Name = "DateTimeService";
            this.DateTimeService.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ButtonServ
            // 
            this.ButtonServ.HeaderText = "Действие";
            this.ButtonServ.Name = "ButtonServ";
            this.ButtonServ.Text = "Оказать услугу";
            this.ButtonServ.UseColumnTextForButtonValue = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClientsGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пациенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.AutoGenerateColumns = false;
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petIdDataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.ownerIdDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.Action});
            this.ClientsGrid.DataSource = this.petModelBindingSource;
            this.ClientsGrid.Location = new System.Drawing.Point(6, 15);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.RowTemplate.Height = 24;
            this.ClientsGrid.Size = new System.Drawing.Size(764, 400);
            this.ClientsGrid.TabIndex = 0;
            this.ClientsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocName
            // 
            this.DocName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocName.Location = new System.Drawing.Point(332, 9);
            this.DocName.Name = "DocName";
            this.DocName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DocName.Size = new System.Drawing.Size(466, 27);
            this.DocName.TabIndex = 2;
            this.DocName.Text = "label1";
            this.DocName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            this.ownerNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerName";
            this.ownerNameDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            this.ownerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petNameDataGridViewTextBoxColumn
            // 
            this.petNameDataGridViewTextBoxColumn.DataPropertyName = "PetName";
            this.petNameDataGridViewTextBoxColumn.HeaderText = "Питомец";
            this.petNameDataGridViewTextBoxColumn.Name = "petNameDataGridViewTextBoxColumn";
            this.petNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceModelBindingSource
            // 
            this.serviceModelBindingSource.DataSource = typeof(DoctorClient.ServiceWebModel);
            // 
            // petModelBindingSource
            // 
            this.petModelBindingSource.DataSource = typeof(DoctorClient.PetModel);
            // 
            // authBindingSource
            // 
            this.authBindingSource.DataSource = typeof(DoctorClient.Auth);
            // 
            // petIdDataGridViewTextBoxColumn
            // 
            this.petIdDataGridViewTextBoxColumn.DataPropertyName = "PetId";
            this.petIdDataGridViewTextBoxColumn.HeaderText = "PetId";
            this.petIdDataGridViewTextBoxColumn.Name = "petIdDataGridViewTextBoxColumn";
            this.petIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ownerNameDataGridViewTextBoxColumn1
            // 
            this.ownerNameDataGridViewTextBoxColumn1.DataPropertyName = "OwnerName";
            this.ownerNameDataGridViewTextBoxColumn1.HeaderText = "Клиент";
            this.ownerNameDataGridViewTextBoxColumn1.Name = "ownerNameDataGridViewTextBoxColumn1";
            this.ownerNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Питомец";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.Visible = false;
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            this.breedDataGridViewTextBoxColumn.Visible = false;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            this.genderDataGridViewCheckBoxColumn.Visible = false;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Visible = false;
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            this.colourDataGridViewTextBoxColumn.Visible = false;
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            this.ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.HeaderText = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            this.ownerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Visible = false;
            // 
            // Action
            // 
            this.Action.HeaderText = "Действие";
            this.Action.Name = "Action";
            this.Action.Text = "Открыть карточку";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 535);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource authBindingSource;
        private System.Windows.Forms.DataGridView ServiceGrid;
        private System.Windows.Forms.BindingSource serviceModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeService;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonServ;
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.BindingSource petModelBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn petIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}