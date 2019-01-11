namespace DoctorClient
{
    partial class PetForm
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
            this.Note = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.colour = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.Label();
            this.petname = new System.Windows.Forms.Label();
            this.breed = new System.Windows.Forms.Label();
            this.species = new System.Windows.Forms.Label();
            this.CardId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ServicesTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.VaccineGrid = new System.Windows.Forms.DataGridView();
            this.vaccinationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfVaccinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isVaccinatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vaccinationModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VaccineGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinationModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Note);
            this.tabPage1.Controls.Add(this.adress);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.tel);
            this.tabPage1.Controls.Add(this.FIO);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.colour);
            this.tabPage1.Controls.Add(this.male);
            this.tabPage1.Controls.Add(this.weight);
            this.tabPage1.Controls.Add(this.birth);
            this.tabPage1.Controls.Add(this.petname);
            this.tabPage1.Controls.Add(this.breed);
            this.tabPage1.Controls.Add(this.species);
            this.tabPage1.Controls.Add(this.CardId);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личная карточка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Location = new System.Drawing.Point(442, 243);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(91, 17);
            this.Note.TabIndex = 27;
            this.Note.Text = "№ карточки:";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(398, 205);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(91, 17);
            this.adress.TabIndex = 26;
            this.adress.Text = "№ карточки:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(398, 167);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(91, 17);
            this.email.TabIndex = 25;
            this.email.Text = "№ карточки:";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(393, 129);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(91, 17);
            this.tel.TabIndex = 24;
            this.tel.Text = "№ карточки:";
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Location = new System.Drawing.Point(393, 91);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(91, 17);
            this.FIO.TabIndex = 23;
            this.FIO.Text = "№ карточки:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(341, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "E-mail:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(341, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "Адрес:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(341, 243);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "Примечание:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(341, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 17);
            this.label19.TabIndex = 19;
            this.label19.Text = "№ тел:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(341, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 17);
            this.label20.TabIndex = 18;
            this.label20.Text = "ФИО:";
            // 
            // colour
            // 
            this.colour.AutoSize = true;
            this.colour.Location = new System.Drawing.Point(87, 357);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(91, 17);
            this.colour.TabIndex = 17;
            this.colour.Text = "№ карточки:";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(72, 319);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(91, 17);
            this.male.TabIndex = 16;
            this.male.Text = "№ карточки:";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(70, 281);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(91, 17);
            this.weight.TabIndex = 15;
            this.weight.Text = "№ карточки:";
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Location = new System.Drawing.Point(96, 243);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(91, 17);
            this.birth.TabIndex = 14;
            this.birth.Text = "№ карточки:";
            // 
            // petname
            // 
            this.petname.AutoSize = true;
            this.petname.Location = new System.Drawing.Point(94, 205);
            this.petname.Name = "petname";
            this.petname.Size = new System.Drawing.Size(91, 17);
            this.petname.TabIndex = 13;
            this.petname.Text = "№ карточки:";
            // 
            // breed
            // 
            this.breed.AutoSize = true;
            this.breed.Location = new System.Drawing.Point(96, 167);
            this.breed.Name = "breed";
            this.breed.Size = new System.Drawing.Size(91, 17);
            this.breed.TabIndex = 12;
            this.breed.Text = "№ карточки:";
            // 
            // species
            // 
            this.species.AutoSize = true;
            this.species.Location = new System.Drawing.Point(71, 129);
            this.species.Name = "species";
            this.species.Size = new System.Drawing.Size(91, 17);
            this.species.TabIndex = 11;
            this.species.Text = "№ карточки:";
            // 
            // CardId
            // 
            this.CardId.AutoSize = true;
            this.CardId.Location = new System.Drawing.Point(125, 91);
            this.CardId.Name = "CardId";
            this.CardId.Size = new System.Drawing.Size(91, 17);
            this.CardId.TabIndex = 10;
            this.CardId.Text = "№ карточки:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Порода:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Кличка:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Возраст";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Вес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пол:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Окрас:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вид:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "№ карточки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(339, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Питомец";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ServicesTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "История болезни";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ServicesTextBox
            // 
            this.ServicesTextBox.Location = new System.Drawing.Point(19, 20);
            this.ServicesTextBox.Multiline = true;
            this.ServicesTextBox.Name = "ServicesTextBox";
            this.ServicesTextBox.Size = new System.Drawing.Size(684, 445);
            this.ServicesTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.VaccineGrid);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(728, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вакцинации";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // VaccineGrid
            // 
            this.VaccineGrid.AutoGenerateColumns = false;
            this.VaccineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VaccineGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccinationIdDataGridViewTextBoxColumn,
            this.iDPetDataGridViewTextBoxColumn,
            this.petDataGridViewTextBoxColumn,
            this.vaccineNameDataGridViewTextBoxColumn,
            this.dateOfVaccinationDataGridViewTextBoxColumn,
            this.expiredDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.isVaccinatedDataGridViewCheckBoxColumn});
            this.VaccineGrid.DataSource = this.vaccinationModelBindingSource;
            this.VaccineGrid.Location = new System.Drawing.Point(4, 76);
            this.VaccineGrid.Name = "VaccineGrid";
            this.VaccineGrid.RowTemplate.Height = 24;
            this.VaccineGrid.Size = new System.Drawing.Size(721, 349);
            this.VaccineGrid.TabIndex = 2;
            // 
            // vaccinationIdDataGridViewTextBoxColumn
            // 
            this.vaccinationIdDataGridViewTextBoxColumn.DataPropertyName = "VaccinationId";
            this.vaccinationIdDataGridViewTextBoxColumn.HeaderText = "VaccinationId";
            this.vaccinationIdDataGridViewTextBoxColumn.Name = "vaccinationIdDataGridViewTextBoxColumn";
            this.vaccinationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPetDataGridViewTextBoxColumn
            // 
            this.iDPetDataGridViewTextBoxColumn.DataPropertyName = "IDPet";
            this.iDPetDataGridViewTextBoxColumn.HeaderText = "IDPet";
            this.iDPetDataGridViewTextBoxColumn.Name = "iDPetDataGridViewTextBoxColumn";
            this.iDPetDataGridViewTextBoxColumn.Visible = false;
            // 
            // petDataGridViewTextBoxColumn
            // 
            this.petDataGridViewTextBoxColumn.DataPropertyName = "Pet";
            this.petDataGridViewTextBoxColumn.HeaderText = "Pet";
            this.petDataGridViewTextBoxColumn.Name = "petDataGridViewTextBoxColumn";
            this.petDataGridViewTextBoxColumn.Visible = false;
            // 
            // vaccineNameDataGridViewTextBoxColumn
            // 
            this.vaccineNameDataGridViewTextBoxColumn.DataPropertyName = "VaccineName";
            this.vaccineNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.vaccineNameDataGridViewTextBoxColumn.Name = "vaccineNameDataGridViewTextBoxColumn";
            this.vaccineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfVaccinationDataGridViewTextBoxColumn
            // 
            this.dateOfVaccinationDataGridViewTextBoxColumn.DataPropertyName = "DateOfVaccination";
            this.dateOfVaccinationDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateOfVaccinationDataGridViewTextBoxColumn.Name = "dateOfVaccinationDataGridViewTextBoxColumn";
            this.dateOfVaccinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiredDateDataGridViewTextBoxColumn
            // 
            this.expiredDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiredDate";
            this.expiredDateDataGridViewTextBoxColumn.HeaderText = "Действует до";
            this.expiredDateDataGridViewTextBoxColumn.Name = "expiredDateDataGridViewTextBoxColumn";
            this.expiredDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isVaccinatedDataGridViewCheckBoxColumn
            // 
            this.isVaccinatedDataGridViewCheckBoxColumn.DataPropertyName = "IsVaccinated";
            this.isVaccinatedDataGridViewCheckBoxColumn.HeaderText = "Отметка";
            this.isVaccinatedDataGridViewCheckBoxColumn.Name = "isVaccinatedDataGridViewCheckBoxColumn";
            // 
            // vaccinationModelBindingSource
            // 
            this.vaccinationModelBindingSource.DataSource = typeof(DoctorClient.VaccinationModel);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "PetForm";
            this.Text = "PetForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VaccineGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinationModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label colour;
        private System.Windows.Forms.Label male;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.Label petname;
        private System.Windows.Forms.Label breed;
        private System.Windows.Forms.Label species;
        private System.Windows.Forms.Label CardId;
        private System.Windows.Forms.TextBox ServicesTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView VaccineGrid;
        private System.Windows.Forms.BindingSource vaccinationModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfVaccinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isVaccinatedDataGridViewCheckBoxColumn;
    }
}