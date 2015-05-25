namespace TrainSimulator
{
    partial class FormStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbStations = new System.Windows.Forms.ComboBox();
            this.gbStations = new System.Windows.Forms.GroupBox();
            this.lbPassengers = new System.Windows.Forms.ListBox();
            this.tbStatistics = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgPassengers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelStats = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTypeSum = new System.Windows.Forms.TextBox();
            this.Disabled = new System.Windows.Forms.RadioButton();
            this.Retired = new System.Windows.Forms.RadioButton();
            this.Officer = new System.Windows.Forms.RadioButton();
            this.Employee = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.chkActivateTypeStats = new System.Windows.Forms.CheckBox();
            this.lblPassCount = new System.Windows.Forms.Label();
            this.lblPerLess = new System.Windows.Forms.Label();
            this.tbEstacionMenosConc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEstacionMasConc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStretch = new System.Windows.Forms.Label();
            this.tbStretch = new System.Windows.Forms.TextBox();
            this.gbStations.SuspendLayout();
            this.tbStatistics.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassengers)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una estacion";
            // 
            // cbStations
            // 
            this.cbStations.FormattingEnabled = true;
            this.cbStations.Location = new System.Drawing.Point(18, 65);
            this.cbStations.Name = "cbStations";
            this.cbStations.Size = new System.Drawing.Size(121, 21);
            this.cbStations.TabIndex = 1;
            this.cbStations.SelectedIndexChanged += new System.EventHandler(this.cbStations_SelectedIndexChanged);
            // 
            // gbStations
            // 
            this.gbStations.Controls.Add(this.label1);
            this.gbStations.Controls.Add(this.cbStations);
            this.gbStations.Location = new System.Drawing.Point(35, 44);
            this.gbStations.Name = "gbStations";
            this.gbStations.Size = new System.Drawing.Size(166, 124);
            this.gbStations.TabIndex = 2;
            this.gbStations.TabStop = false;
            this.gbStations.Text = "Estaciones";
            // 
            // lbPassengers
            // 
            this.lbPassengers.FormattingEnabled = true;
            this.lbPassengers.Location = new System.Drawing.Point(235, 47);
            this.lbPassengers.Name = "lbPassengers";
            this.lbPassengers.Size = new System.Drawing.Size(145, 121);
            this.lbPassengers.TabIndex = 3;
            this.lbPassengers.SelectedIndexChanged += new System.EventHandler(this.lbPassengers_SelectedIndexChanged);
            // 
            // tbStatistics
            // 
            this.tbStatistics.Controls.Add(this.tabPage1);
            this.tbStatistics.Controls.Add(this.tabPage2);
            this.tbStatistics.Location = new System.Drawing.Point(1, 2);
            this.tbStatistics.Name = "tbStatistics";
            this.tbStatistics.SelectedIndex = 0;
            this.tbStatistics.Size = new System.Drawing.Size(677, 476);
            this.tbStatistics.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgPassengers);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.gbStations);
            this.tabPage1.Controls.Add(this.lbPassengers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgPassengers
            // 
            this.dgPassengers.AccessibleDescription = "";
            this.dgPassengers.AllowUserToAddRows = false;
            this.dgPassengers.AllowUserToDeleteRows = false;
            this.dgPassengers.AllowUserToOrderColumns = true;
            this.dgPassengers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPassengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.Birth,
            this.type,
            this.origin,
            this.destiny});
            this.dgPassengers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPassengers.Location = new System.Drawing.Point(7, 262);
            this.dgPassengers.Name = "dgPassengers";
            this.dgPassengers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgPassengers.Size = new System.Drawing.Size(635, 62);
            this.dgPassengers.TabIndex = 5;
            this.dgPassengers.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pasajeros";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbStretch);
            this.tabPage2.Controls.Add(this.lblStretch);
            this.tabPage2.Controls.Add(this.panelStats);
            this.tabPage2.Controls.Add(this.chkActivateTypeStats);
            this.tabPage2.Controls.Add(this.lblPassCount);
            this.tabPage2.Controls.Add(this.lblPerLess);
            this.tabPage2.Controls.Add(this.tbEstacionMenosConc);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblPercentage);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbEstacionMasConc);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.label6);
            this.panelStats.Controls.Add(this.tbTypeSum);
            this.panelStats.Controls.Add(this.Disabled);
            this.panelStats.Controls.Add(this.Retired);
            this.panelStats.Controls.Add(this.Officer);
            this.panelStats.Controls.Add(this.Employee);
            this.panelStats.Controls.Add(this.Student);
            this.panelStats.Location = new System.Drawing.Point(34, 210);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(444, 71);
            this.panelStats.TabIndex = 10;
            this.panelStats.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad:";
            // 
            // tbTypeSum
            // 
            this.tbTypeSum.Enabled = false;
            this.tbTypeSum.Location = new System.Drawing.Point(238, 46);
            this.tbTypeSum.Name = "tbTypeSum";
            this.tbTypeSum.Size = new System.Drawing.Size(23, 20);
            this.tbTypeSum.TabIndex = 11;
            // 
            // Disabled
            // 
            this.Disabled.AutoSize = true;
            this.Disabled.Location = new System.Drawing.Point(343, 14);
            this.Disabled.Name = "Disabled";
            this.Disabled.Size = new System.Drawing.Size(93, 17);
            this.Disabled.TabIndex = 4;
            this.Disabled.TabStop = true;
            this.Disabled.Text = "Discapacitado";
            this.Disabled.UseVisualStyleBackColor = true;
            this.Disabled.Click += new System.EventHandler(this.type_CheckedChanged);
            // 
            // Retired
            // 
            this.Retired.AutoSize = true;
            this.Retired.Location = new System.Drawing.Point(263, 14);
            this.Retired.Name = "Retired";
            this.Retired.Size = new System.Drawing.Size(64, 17);
            this.Retired.TabIndex = 3;
            this.Retired.TabStop = true;
            this.Retired.Text = "Jubilado";
            this.Retired.UseVisualStyleBackColor = true;
            this.Retired.Click += new System.EventHandler(this.type_CheckedChanged);
            // 
            // Officer
            // 
            this.Officer.AutoSize = true;
            this.Officer.Location = new System.Drawing.Point(185, 14);
            this.Officer.Name = "Officer";
            this.Officer.Size = new System.Drawing.Size(58, 17);
            this.Officer.TabIndex = 2;
            this.Officer.TabStop = true;
            this.Officer.Text = "Policía";
            this.Officer.UseVisualStyleBackColor = true;
            this.Officer.Click += new System.EventHandler(this.type_CheckedChanged);
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Location = new System.Drawing.Point(94, 14);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(72, 17);
            this.Employee.TabIndex = 1;
            this.Employee.TabStop = true;
            this.Employee.Text = "Empleado";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.Click += new System.EventHandler(this.type_CheckedChanged);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(3, 14);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(75, 17);
            this.Student.TabIndex = 0;
            this.Student.TabStop = true;
            this.Student.Text = "Estudiante";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.Click += new System.EventHandler(this.type_CheckedChanged);
            // 
            // chkActivateTypeStats
            // 
            this.chkActivateTypeStats.AutoSize = true;
            this.chkActivateTypeStats.Location = new System.Drawing.Point(34, 176);
            this.chkActivateTypeStats.Name = "chkActivateTypeStats";
            this.chkActivateTypeStats.Size = new System.Drawing.Size(215, 17);
            this.chkActivateTypeStats.TabIndex = 9;
            this.chkActivateTypeStats.Text = "Activar estadísticas por tipo de pasajero";
            this.chkActivateTypeStats.UseVisualStyleBackColor = true;
            this.chkActivateTypeStats.CheckedChanged += new System.EventHandler(this.chkActivateTypeStats_CheckedChanged);
            // 
            // lblPassCount
            // 
            this.lblPassCount.AutoSize = true;
            this.lblPassCount.Location = new System.Drawing.Point(282, 48);
            this.lblPassCount.Name = "lblPassCount";
            this.lblPassCount.Size = new System.Drawing.Size(35, 13);
            this.lblPassCount.TabIndex = 7;
            this.lblPassCount.Text = "label6";
            // 
            // lblPerLess
            // 
            this.lblPerLess.AutoSize = true;
            this.lblPerLess.Location = new System.Drawing.Point(281, 88);
            this.lblPerLess.Name = "lblPerLess";
            this.lblPerLess.Size = new System.Drawing.Size(51, 13);
            this.lblPerLess.TabIndex = 6;
            this.lblPerLess.Text = "labelLess";
            // 
            // tbEstacionMenosConc
            // 
            this.tbEstacionMenosConc.Enabled = false;
            this.tbEstacionMenosConc.Location = new System.Drawing.Point(167, 85);
            this.tbEstacionMenosConc.Name = "tbEstacionMenosConc";
            this.tbEstacionMenosConc.Size = new System.Drawing.Size(108, 20);
            this.tbEstacionMenosConc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estación menos concurrida:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Enabled = false;
            this.lblPercentage.Location = new System.Drawing.Point(344, 48);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(47, 13);
            this.lblPercentage.TabIndex = 3;
            this.lblPercentage.Text = "lessPerc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(281, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // tbEstacionMasConc
            // 
            this.tbEstacionMasConc.Location = new System.Drawing.Point(167, 45);
            this.tbEstacionMasConc.Name = "tbEstacionMasConc";
            this.tbEstacionMasConc.ReadOnly = true;
            this.tbEstacionMasConc.Size = new System.Drawing.Size(108, 20);
            this.tbEstacionMasConc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estación más concurrida: ";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Nombre";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Apellido";
            this.lastName.Name = "lastName";
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Fecha Nac.";
            this.Birth.Name = "Birth";
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // origin
            // 
            this.origin.HeaderText = "Origen";
            this.origin.Name = "origin";
            // 
            // destiny
            // 
            this.destiny.HeaderText = "Destino";
            this.destiny.Name = "destiny";
            // 
            // lblStretch
            // 
            this.lblStretch.AutoSize = true;
            this.lblStretch.Location = new System.Drawing.Point(31, 133);
            this.lblStretch.Name = "lblStretch";
            this.lblStretch.Size = new System.Drawing.Size(125, 13);
            this.lblStretch.TabIndex = 11;
            this.lblStretch.Text = "Tramo con mayor carga: ";
            // 
            // tbStretch
            // 
            this.tbStretch.Enabled = false;
            this.tbStretch.Location = new System.Drawing.Point(167, 130);
            this.tbStretch.Name = "tbStretch";
            this.tbStretch.Size = new System.Drawing.Size(165, 20);
            this.tbStretch.TabIndex = 12;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 476);
            this.Controls.Add(this.tbStatistics);
            this.Name = "FormStatistics";
            this.Text = "Estadísticas";
            this.gbStations.ResumeLayout(false);
            this.gbStations.PerformLayout();
            this.tbStatistics.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassengers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStations;
        private System.Windows.Forms.GroupBox gbStations;
        private System.Windows.Forms.ListBox lbPassengers;
        private System.Windows.Forms.TabControl tbStatistics;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgPassengers;
        private System.Windows.Forms.TextBox tbEstacionMasConc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPerLess;
        private System.Windows.Forms.TextBox tbEstacionMenosConc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPassCount;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.RadioButton Disabled;
        private System.Windows.Forms.RadioButton Retired;
        private System.Windows.Forms.RadioButton Officer;
        private System.Windows.Forms.RadioButton Employee;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.CheckBox chkActivateTypeStats;
        private System.Windows.Forms.TextBox tbTypeSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn destiny;
        private System.Windows.Forms.TextBox tbStretch;
        private System.Windows.Forms.Label lblStretch;
    }
}