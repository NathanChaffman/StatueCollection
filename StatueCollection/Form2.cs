using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace StatueCollection
{
    public partial class Form2 : Form
    {
        StatueDepot statue;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)  //new instance of statue, populates combo-boxes
        {
            statue = new StatueDepot();
            Clear();
            cmbAddCapeStyle.Items.AddRange(new string[] { "Sculpted", "Fabric", "None" });
            cmbAddExclusive.Items.AddRange(new string[] { "Yes", "No" });
            cmbAddHairType.Items.AddRange(new string[] { "Sculpted", "Rooted", "N/A" });
            cmbAddKit.Items.AddRange(new string[] { "Yes", "No" });
            cmbAddOwned.Items.AddRange(new string[] { "Yes", "No" });
            cmbAddPaidFor.Items.AddRange(new string[] { "Yes", "No" });
            cmbAddScale.Items.AddRange(new string[] { "Lifesize", "Half", "OneThird", "OneFourth", "OneFifth", "OneSixth", "OneEighth", "OneTenth", "Other" });
            
        }
        private void Clear()  //clears all fields
        {
            txtAddStatueNumber.ReadOnly = true;
            txtAddBoxes.Clear();
            txtAddCharacter.Clear();
            txtAddCost.Clear();
            txtAddDepth.Clear();
            txtAddEditionSize.Clear();
            txtAddHeight.Clear();
            txtAddManufacturer.Clear();
            txtAddMaterial.Clear();
            txtAddMonthlyPayment.Clear();
            txtAddNRD.Clear();
            txtAddOrderNumber.Clear();
            txtAddPaymentPlan.Clear();
            txtAddQuantity.Clear();
            txtAddRetailer.Clear();
            txtAddStatueNumber.Text = (statue.Read().Max(p => p.Statue_Number) + 1).ToString(); //read only, populates the next number in sequence
            txtAddWeight.Clear();
            txtAddWidth.Clear();
            cmbAddCapeStyle.SelectedIndex = -1;
            cmbAddExclusive.SelectedIndex = -1;
            cmbAddHairType.SelectedIndex = -1;
            cmbAddKit.SelectedIndex = -1;
            cmbAddOwned.SelectedIndex = -1;
            //dateTimePickerAddNew.Value is null;                        //Todo: How do I clear the date?
            cmbAddScale.SelectedIndex = -1;
            cmbAddPaidFor.SelectedIndex = -1;
        }
        private void Form2_VisibleChanged(object sender, EventArgs e)  //date format
        {
            dateTimePickerAddNew.CustomFormat = "MM/dd/yyyy";
        }

        private void btnAddtoCollection_Click(object sender, EventArgs e) //Add Statue to Database
        {
            var obj = new Statue();
            obj.Statue_Number = Convert.ToDecimal(txtAddStatueNumber.Text);  //read only, auto populates
            if (cmbAddCapeStyle.SelectedIndex >= 0)    //mandatory category                       
            {
                obj.Cape_Style = cmbAddCapeStyle.SelectedItem.ToString();
            }
            if (!string.IsNullOrWhiteSpace(txtAddCharacter.Text)) //mandatory category
            {
                obj.Character = txtAddCharacter.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtAddCost.Text)) //optional category
            {
                obj.Cost = Convert.ToDecimal(txtAddCost.Text);
            }
            else
            {
                obj.Cost = null;
            }
            if (!string.IsNullOrWhiteSpace(txtAddDepth.Text)) //optional category
            {
                obj.Depth = Convert.ToDecimal(txtAddDepth.Text);
            }
            else
            {
                obj.Depth = null;
            }
            if (!string.IsNullOrWhiteSpace(txtAddEditionSize.Text)) //optional category
            {
                obj.Edition_Size = Convert.ToDecimal(txtAddEditionSize.Text);
            }
            else
            {
                obj.Edition_Size = null;
            }
            if (cmbAddExclusive.SelectedIndex == 0) //optional category
            {
                obj.Exclusive = true;
            }
            else if (cmbAddExclusive.SelectedIndex == 1)
            {
                obj.Exclusive = false;
            }
            else
            {
                obj.Exclusive = null;
            }
            if (cmbAddHairType.SelectedIndex >= 0) //mandatory category
            {
                obj.Hair_Type = cmbAddHairType.SelectedItem.ToString();
            }
            if (!string.IsNullOrWhiteSpace(txtAddHeight.Text)) //optional category
            {
                obj.Height = Convert.ToDecimal(txtAddHeight.Text);
            }
            else
            {
                obj.Height = null;
            }
            if (cmbAddKit.SelectedIndex == 0) //mandatory category
            {
                obj.Kit = true;
            }
            else if (cmbAddKit.SelectedIndex == 1)
            {
                obj.Kit = false;
            }
            if (!string.IsNullOrWhiteSpace(txtAddManufacturer.Text)) //mandatory category
            {
                obj.Manufacturer = txtAddManufacturer.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtAddMaterial.Text)) //mandatory category
            {
                obj.Material = txtAddMaterial.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtAddNRD.Text)) //optional category
            {
                obj.Non_Refundable_Deposit = Convert.ToDecimal(txtAddNRD.Text);
            }
            else
            {
                obj.Non_Refundable_Deposit = null;
            }
            if (!string.IsNullOrWhiteSpace(txtAddBoxes.Text)) //optional category
            {
                obj.Number_Of_Boxes = Convert.ToDecimal(txtAddBoxes.Text);
            }
            else
            {
                obj.Number_Of_Boxes = null;
            }
            if (dateTimePickerAddNew != null) //optional category
            {
                obj.Order_Date = dateTimePickerAddNew.Value;
            }
            else
            {
                obj.Order_Date = null;
            }
            if (!string.IsNullOrWhiteSpace(txtAddOrderNumber.Text)) //optional category
            {
                obj.Order_Number = Convert.ToDecimal(txtAddOrderNumber.Text);
            }
            else
            {
                obj.Order_Number = null;
            }
            if (cmbAddOwned.SelectedIndex == 0) //mandatory category
            {
                obj.Owned = true;
            }
            else if (cmbAddOwned.SelectedIndex == 1)
            {
                obj.Owned = false;
            }
            if (cmbAddPaidFor.SelectedIndex == 0) //optional category
            {
                obj.Paid = true;
            }
            else if (cmbAddPaidFor.SelectedIndex == 1)
            {
                obj.Paid = false;
            }
            else
            {
                obj.Paid = null;
            }
            if (!string.IsNullOrWhiteSpace(txtAddMonthlyPayment.Text)) //optional category
            {
                obj.Payment_Cost = Convert.ToDecimal(txtAddMonthlyPayment.Text);
            }
            else
            {
                obj.Payment_Cost = null;
            }
            if (!string.IsNullOrWhiteSpace(txtAddPaymentPlan.Text)) //optional category
            {
                obj.Payment_Length = Convert.ToDecimal(txtAddPaymentPlan.Text);
            }
            else
            {
                obj.Payment_Length = null;
            }
            if (!string.IsNullOrWhiteSpace(txtAddWidth.Text)) //optional category
            {
                obj.Width = Convert.ToDecimal(txtAddWidth.Text);
            }
            else
            {
                obj.Width = null;
            }
            if (!string.IsNullOrWhiteSpace(txtAddWeight.Text)) //optional category
            {
                obj.Weight = Convert.ToDecimal(txtAddWeight.Text);
            }
            else
            {
                obj.Weight = null;
            }
            if (cmbAddScale.SelectedIndex >= 0) //only adds value if a item is selected
            {
                obj.Scale = cmbAddScale.SelectedItem.ToString();
            }
            if (cmbAddHairType.SelectedIndex >= 0) //only adds value if a item is selected
            {
                obj.Hair_Type = cmbAddHairType.SelectedItem.ToString();
            }
            if (!string.IsNullOrWhiteSpace(txtAddRetailer.Text)) //ensures there's no empty space
            {
                obj.Retailer = txtAddRetailer.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtAddQuantity.Text)) //ensures there's no empty space
            {
                obj.Quantity = Convert.ToDecimal(txtAddQuantity.Text);
            }
            if ((cmbAddScale.SelectedIndex > -1) && (cmbAddOwned.SelectedIndex>-1) && cmbAddCapeStyle.SelectedIndex>-1 && (cmbAddHairType.SelectedIndex>-1) && (cmbAddKit.SelectedIndex>-1))
                //ensures required combo boxes are filled
            {
                statue.Create(obj);
                Clear();
            }
            else
            {
                MessageBox.Show("Please ensure you've completed all required fields denoted with an asterisk.");
            }
        }

        private void txtAddCost_Leave(object sender, EventArgs e)   //optional  field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddCost.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddCost.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Cost or leave it empty.");
                    txtAddCost.Clear();
                }
            }
        }

        private void txtAddEditionSize_Leave(object sender, EventArgs e)  //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddEditionSize.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddEditionSize.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Edition Size or leave it empty.");
                    txtAddEditionSize.Clear();
                }
            }
        }

        private void txtAddQuantity_Leave(object sender, EventArgs e)  //mandatory field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddQuantity.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddQuantity.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Quantity.");
                    txtAddQuantity.Clear();
                    txtAddQuantity.Focus();
                }
            }
        }

        private void txtAddHeight_Leave(object sender, EventArgs e)  //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddHeight.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddHeight.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Height or leave it empty.");
                    txtAddHeight.Clear();
                }
            }
        }

        private void txtAddWidth_Leave(object sender, EventArgs e)  //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddWidth.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddWidth.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Width or leave it empty.");
                    txtAddWidth.Clear();
                }
            }
        }

        private void txtAddDepth_Leave(object sender, EventArgs e)  //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddDepth.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddDepth.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Depth or leave it empty.");
                    txtAddDepth.Clear();
                }
            }
        }

        private void txtAddWeight_Leave(object sender, EventArgs e)  //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddWeight.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddWeight.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Weight or leave it empty.");
                    txtAddWeight.Clear();
                }
            }
        }

        private void txtAddBoxes_Leave(object sender, EventArgs e)  //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddBoxes.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddBoxes.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the number of boxes or leave it empty.");
                    txtAddBoxes.Clear();
                }
            }
        }

        private void txtAddOrderNumber_Leave(object sender, EventArgs e)  //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddOrderNumber.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddOrderNumber.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Order Number or leave it empty.");
                    txtAddOrderNumber.Clear();
                }
            }
        }

        private void txtAddPaymentPlan_Leave(object sender, EventArgs e) //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddPaymentPlan.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddPaymentPlan.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Payment Plan length or leave it empty.");
                    txtAddPaymentPlan.Clear();
                }
            }
        }

        private void txtAddMonthlyPayment_Leave(object sender, EventArgs e)  //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddMonthlyPayment.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddMonthlyPayment.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Monthly Payment Cost or leave it empty.");
                    txtAddMonthlyPayment.Clear();
                }
            }
        }

        private void txtAddNRD_Leave(object sender, EventArgs e)  //optional field, validates use of numerical values
        {
            if (!string.IsNullOrWhiteSpace(txtAddNRD.Text))
            {
                decimal test;
                if (decimal.TryParse(txtAddNRD.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Non-Refundable Deposit or leave it empty.");
                    txtAddNRD.Clear();
                }
            }
        }

        private void txtAddCharacter_Leave(object sender, EventArgs e)  //mandatory field, ensures information of some sort is in the text box
        {
            if (string.IsNullOrWhiteSpace(txtAddCharacter.Text)) 
            {
                MessageBox.Show("Please enter Character Information.");
                txtAddCharacter.Clear();
                txtAddCharacter.Focus();
            }
        }

        private void txtAddManufacturer_Leave(object sender, EventArgs e)  //mandatory field, ensures information of some sort is in the text box
        {
            if (string.IsNullOrWhiteSpace(txtAddManufacturer.Text)) 
            {
                MessageBox.Show("Please enter Manufacturer Information.");
                txtAddManufacturer.Clear();
                txtAddManufacturer.Focus();
            }
        }

        private void txtAddMaterial_Leave(object sender, EventArgs e)  //mandatory field, ensures information of some sort is in the text box
        {
            if (string.IsNullOrWhiteSpace(txtAddMaterial.Text)) 
            {
                MessageBox.Show("Please enter Material Information.");
                txtAddMaterial.Clear();
                txtAddMaterial.Focus();
            }
        }

        private void txtAddRetailer_Leave(object sender, EventArgs e)  //mandatory field, ensures information of some sort is in the text box
        {
            if (string.IsNullOrWhiteSpace(txtAddRetailer.Text)) 
            {
                MessageBox.Show("Please enter Retailer Information.");
                txtAddRetailer.Clear();
                txtAddRetailer.Focus();
            }
        }

        private void cmbAddScale_Leave(object sender, EventArgs e)  //mandatory field, ensures a valid index is chosen
        {
            if (cmbAddScale.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select a Scale from the drop down.");
                cmbAddScale.Focus();
            }
        }

        private void cmbAddOwned_Leave(object sender, EventArgs e)  //mandatory field, ensures a valid index is chosen
        {
            if (cmbAddOwned.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select whether or not the statue is currently in your collection from the drop down.");
                cmbAddOwned.Focus();
            }
        }

        private void cmbAddKit_Leave(object sender, EventArgs e)  //mandatory field, ensures a valid index is chosen
        {
            if (cmbAddKit.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select whether or not the statue is a kit from the drop down.");
                cmbAddKit.Focus();
            }
        }

        private void cmbAddCapeStyle_Leave(object sender, EventArgs e)  //mandatory field, ensures a valid index is chosen
        {
            if (cmbAddCapeStyle.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select the cape style from the drop down.");
                cmbAddCapeStyle.Focus();
            }
        }

        private void cmbAddHairType_Leave(object sender, EventArgs e)  //mandatory field, ensures a valid index is chosen
        {
            if (cmbAddHairType.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select the hair style from the drop down.");
                cmbAddHairType.Focus();
            }
        }
    }
}
