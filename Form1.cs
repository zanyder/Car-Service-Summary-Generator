using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Byfielda
{
    public partial class Form1 : Form
    {
        // VARIABLES
        #region 
        // Form Variables

        // CONSTANTS
        private const decimal ENGINE_OIL_CHANGE_PRICE = 67.8m;
        private const decimal TRANSMISSION_OIL_CHANGE_PRICE = 135.6m;
        private const decimal AIR_FILER_CHANGE_COST = 45.76m;
        // Collection of ServiceSummaries with int keys 
        private Dictionary<int, CarServiceSummary> carServiceSummaryList =
            new Dictionary<int, CarServiceSummary>();

        #endregion

        // FORM LOGIC
        #region
        // Add Functionality
        private void AddCarSummary()
        {
            // validate data
            if (
            ValidateForm(txtFirstName.Text, txtLastName.Text, txtPhone.Text, cboMake.Text,
                txtModel.Text, cboYear.Text, txtColour.Text)
              )
            {
                decimal costSum = 0;
                if (chkAirFilter.Checked) { costSum += AIR_FILER_CHANGE_COST; }
                if (chkOilChange.Checked) { costSum += ENGINE_OIL_CHANGE_PRICE;}
                if (chkTransmissionOil.Checked) { costSum += TRANSMISSION_OIL_CHANGE_PRICE; }

                txtCost.Text = costSum.ToString();

                // Check if something is selected in the listview
                if (listSummaryList.SelectedItems.Count > 0)
                {
                    // If it is an existing entry
                    // Get service object from the collection using 
                    ListViewItem selectedSummary = listSummaryList.SelectedItems[0];
                    int selectedID = int.Parse(selectedSummary.SubItems[0].Text);
                    CarServiceSummary selectedObject = carServiceSummaryList[selectedID];

                    selectedObject.FirstName = txtFirstName.Text;
                    selectedObject.LastName = txtLastName.Text;
                    selectedObject.Phone = txtPhone.Text;
                    selectedObject.Make = cboMake.Text;
                    selectedObject.Model = txtModel.Text;
                    selectedObject.Year = cboYear.Text;
                    selectedObject.Colour = txtColour.Text;
                    selectedObject.AirFilterChange = chkAirFilter.Checked;
                    selectedObject.TransOilChange = chkTransmissionOil.Checked;
                    selectedObject.EngOilChange = chkOilChange.Checked;
                    selectedObject.Price = decimal.Parse(txtCost.Text);

                    carServiceSummaryList[selectedID] = selectedObject;
                }
                // If nothing is selected
                else
                {
                    // Initiate new Service object
                    CarServiceSummary newSummary = new CarServiceSummary(txtFirstName.Text,
                        txtLastName.Text, txtPhone.Text, cboMake.Text, txtModel.Text,
                        cboYear.Text, txtColour.Text, decimal.Parse(txtCost.Text),
                        chkOilChange.Checked, chkTransmissionOil.Checked, chkAirFilter.Checked);
                    // Add to a collection of Services with IdentificationNumber
                    // as the list key
                    carServiceSummaryList.Add(newSummary.ID, newSummary);


                }
                // clear input fields
                ClearForm();
                // update ListView
                UpdateListView();
            }
        }

        private bool ValidateForm(string firstName, string lastName,
            string phone, string make, string model, string year,
            string colour)
        {
            bool valid = true;
            string errorMessage = "";
            List<string> emptyFields = new List<string>();

            if (String.IsNullOrWhiteSpace(firstName))
            {
                emptyFields.Add("First Name");
            }

            if (String.IsNullOrWhiteSpace(lastName))
            {
                emptyFields.Add("Last Name");
            }

            if (String.IsNullOrWhiteSpace(phone))
            {
                emptyFields.Add("Phone");
            }

            if (String.IsNullOrWhiteSpace(make))
            {
                emptyFields.Add("Make");
            }

            if (String.IsNullOrWhiteSpace(model))
            {
                emptyFields.Add("Model");
            }

            if (String.IsNullOrWhiteSpace(year))
            {
                emptyFields.Add("Year");
            }

            if (String.IsNullOrWhiteSpace(colour))
            {
                emptyFields.Add("Colour");
            }

            if (!(chkOilChange.Checked || chkAirFilter.Checked || chkTransmissionOil.Checked))
            {
                valid = false;
                emptyFields.Add("Select a service.");
            }

            if (emptyFields.Count > 0)
            {
                valid = false;
                errorMessage = "The following fields are blank: " + string.Join(", ", emptyFields) + ". Please make sure values are entered for each field.";
            }


            MessageBox.Show(errorMessage);

            // last name
            // phone number
            //make
            //model
            //year
            //colour
            //Services Selected

            return valid;
        }
        // Update ListView

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCost.Clear();
            txtColour.Clear();
            txtModel.Clear();
            txtPhone.Clear();
            cboMake.ResetText();
            cboYear.ResetText();
            chkAirFilter.Checked = false;
            chkOilChange.Checked = false;
            chkTransmissionOil.Checked = false;

        }
        private void UpdateListView()
        {
            // Clear the listView Items
            // Loop through Services list and add each to list view.
            listSummaryList.Items.Clear();

            foreach (KeyValuePair<int, CarServiceSummary> kvp in carServiceSummaryList)
            {
                ListViewItem item = new ListViewItem(kvp.Value.ID.ToString());
                item.SubItems.Add(kvp.Value.FirstName);
                item.SubItems.Add(kvp.Value.LastName);
                item.SubItems.Add(kvp.Value.Phone);
                item.SubItems.Add(kvp.Value.Make);
                item.SubItems.Add(kvp.Value.Model);
                item.SubItems.Add(kvp.Value.Year);
                item.SubItems.Add(kvp.Value.Colour);
                item.SubItems.Add(kvp.Value.Price.ToString());
                CheckBox chk = new CheckBox { Checked = kvp.Value.EngOilChange };
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, string.Empty) { Tag = chk, Text = "Active" });
                chk.Checked = kvp.Value.TransOilChange;
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, string.Empty) { Tag = chk, Text = "Active" });
                chk.Checked = kvp.Value.AirFilterChange;
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, string.Empty) { Tag = chk, Text = "Active" });
            }
        }

        private void RemoveSelectedSummary()
        {
            // Check if something is selected in the listview
            if (listSummaryList.SelectedItems.Count > 0)
            {
                listSummaryList.Items.Remove(listSummaryList.SelectedItems[0]);
            }
            else { MessageBox.Show("There is nothing selected to remove."); }

            UpdateListView();
        }

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCarSummary();
        }

        private void listSummaryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddCarSummary();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddCarSummary();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedSummary();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            listSummaryList.Items.Clear();
            carServiceSummaryList.Clear();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
