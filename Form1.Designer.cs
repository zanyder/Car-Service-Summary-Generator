namespace Assignment3_Byfielda
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
            this.lblCustInfo = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.chkTransmissionOil = new System.Windows.Forms.CheckBox();
            this.chkAirFilter = new System.Windows.Forms.CheckBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblServiceSum = new System.Windows.Forms.Label();
            this.listSummaryList = new System.Windows.Forms.ListView();
            this.HeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderMake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderColour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblCustInfo
            // 
            this.lblCustInfo.AutoSize = true;
            this.lblCustInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustInfo.Location = new System.Drawing.Point(56, 31);
            this.lblCustInfo.Name = "lblCustInfo";
            this.lblCustInfo.Size = new System.Drawing.Size(152, 16);
            this.lblCustInfo.TabIndex = 0;
            this.lblCustInfo.Text = "Customer Information";
            this.lblCustInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(60, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(60, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(60, 121);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 16);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(161, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(112, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(161, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(112, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(161, 123);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(112, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.AutoSize = true;
            this.lblCarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarInfo.Location = new System.Drawing.Point(56, 167);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(111, 16);
            this.lblCarInfo.TabIndex = 7;
            this.lblCarInfo.Text = "Car Information";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(60, 196);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(49, 16);
            this.lblMake.TabIndex = 8;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(60, 227);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 16);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(60, 256);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 16);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year:";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(60, 287);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(56, 16);
            this.lblColour.TabIndex = 9;
            this.lblColour.Text = "Colour:";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(60, 319);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(72, 16);
            this.lblServices.TabIndex = 9;
            this.lblServices.Text = "Services:";
            // 
            // cboMake
            // 
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Items.AddRange(new object[] {
            "Honda",
            "Toyoto",
            "Volvo",
            "Hyundai",
            "BMW",
            "Ferrari"});
            this.cboMake.Location = new System.Drawing.Point(161, 196);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(121, 24);
            this.cboMake.TabIndex = 10;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(161, 227);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 11;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000"});
            this.cboYear.Location = new System.Drawing.Point(161, 256);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 24);
            this.cboYear.TabIndex = 12;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(161, 287);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(100, 22);
            this.txtColour.TabIndex = 13;
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(161, 319);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(157, 20);
            this.chkOilChange.TabIndex = 14;
            this.chkOilChange.Text = "Engine Oil Change";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // chkTransmissionOil
            // 
            this.chkTransmissionOil.AutoSize = true;
            this.chkTransmissionOil.Location = new System.Drawing.Point(161, 346);
            this.chkTransmissionOil.Name = "chkTransmissionOil";
            this.chkTransmissionOil.Size = new System.Drawing.Size(202, 20);
            this.chkTransmissionOil.TabIndex = 15;
            this.chkTransmissionOil.Text = "Transmission Oil Change";
            this.chkTransmissionOil.UseVisualStyleBackColor = true;
            // 
            // chkAirFilter
            // 
            this.chkAirFilter.AutoSize = true;
            this.chkAirFilter.Location = new System.Drawing.Point(161, 373);
            this.chkAirFilter.Name = "chkAirFilter";
            this.chkAirFilter.Size = new System.Drawing.Size(144, 20);
            this.chkAirFilter.TabIndex = 16;
            this.chkAirFilter.Text = "Air Filter Change";
            this.chkAirFilter.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(63, 404);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(42, 16);
            this.lblCost.TabIndex = 17;
            this.lblCost.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(161, 404);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(100, 22);
            this.txtCost.TabIndex = 18;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(59, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNew.Location = new System.Drawing.Point(183, 465);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(108, 23);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Location = new System.Drawing.Point(309, 465);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Location = new System.Drawing.Point(438, 465);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 23);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoveAll.Location = new System.Drawing.Point(567, 465);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(108, 23);
            this.btnRemoveAll.TabIndex = 19;
            this.btnRemoveAll.Text = "Remo&ve all";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(691, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblServiceSum
            // 
            this.lblServiceSum.AutoSize = true;
            this.lblServiceSum.Location = new System.Drawing.Point(347, 30);
            this.lblServiceSum.Name = "lblServiceSum";
            this.lblServiceSum.Size = new System.Drawing.Size(156, 16);
            this.lblServiceSum.TabIndex = 20;
            this.lblServiceSum.Text = "Car Service Summary";
            // 
            // listSummaryList
            // 
            this.listSummaryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderNum,
            this.HeaderFirstName,
            this.HeaderLastName,
            this.HeaderPhone,
            this.HeaderMake,
            this.HeaderModel,
            this.HeaderYear,
            this.HeaderColour,
            this.HeaderCost});
            this.listSummaryList.FullRowSelect = true;
            this.listSummaryList.HideSelection = false;
            this.listSummaryList.Location = new System.Drawing.Point(350, 61);
            this.listSummaryList.Name = "listSummaryList";
            this.listSummaryList.Size = new System.Drawing.Size(526, 228);
            this.listSummaryList.TabIndex = 21;
            this.listSummaryList.UseCompatibleStateImageBehavior = false;
            this.listSummaryList.View = System.Windows.Forms.View.Details;
            this.listSummaryList.SelectedIndexChanged += new System.EventHandler(this.listSummaryList_SelectedIndexChanged);
            // 
            // HeaderNum
            // 
            this.HeaderNum.Text = "NO";
            this.HeaderNum.Width = 39;
            // 
            // HeaderFirstName
            // 
            this.HeaderFirstName.Text = "Firstname";
            this.HeaderFirstName.Width = 84;
            // 
            // HeaderLastName
            // 
            this.HeaderLastName.Text = "LastName";
            this.HeaderLastName.Width = 91;
            // 
            // HeaderPhone
            // 
            this.HeaderPhone.Text = "Phone";
            this.HeaderPhone.Width = 101;
            // 
            // HeaderMake
            // 
            this.HeaderMake.Text = "Make";
            this.HeaderMake.Width = 78;
            // 
            // HeaderModel
            // 
            this.HeaderModel.Text = "Model";
            this.HeaderModel.Width = 75;
            // 
            // HeaderYear
            // 
            this.HeaderYear.Text = "Year";
            // 
            // HeaderColour
            // 
            this.HeaderColour.Text = "Colour";
            // 
            // HeaderCost
            // 
            this.HeaderCost.Text = "Cost";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.listSummaryList);
            this.Controls.Add(this.lblServiceSum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.chkAirFilter);
            this.Controls.Add(this.chkTransmissionOil);
            this.Controls.Add(this.chkOilChange);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cboMake);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCustInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(918, 547);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(918, 547);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Service Summary Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustInfo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkTransmissionOil;
        private System.Windows.Forms.CheckBox chkAirFilter;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblServiceSum;
        private System.Windows.Forms.ListView listSummaryList;
        private System.Windows.Forms.ColumnHeader HeaderNum;
        private System.Windows.Forms.ColumnHeader HeaderFirstName;
        private System.Windows.Forms.ColumnHeader HeaderLastName;
        private System.Windows.Forms.ColumnHeader HeaderPhone;
        private System.Windows.Forms.ColumnHeader HeaderMake;
        private System.Windows.Forms.ColumnHeader HeaderModel;
        private System.Windows.Forms.ColumnHeader HeaderYear;
        private System.Windows.Forms.ColumnHeader HeaderColour;
        private System.Windows.Forms.ColumnHeader HeaderCost;
    }
}

