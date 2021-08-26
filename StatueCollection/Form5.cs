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
    public partial class Form5 : Form
    {
        StatueDepot statue;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e) //populates boxes on load
        {
            statue = new StatueDepot();
            var obj = statue.FindStatue(Global.IdtoUpdate);
            txtUpdateBoxes.Text = obj.Number_Of_Boxes.ToString();
            txtUpdateCharacter.Text = obj.Character.ToString();
            txtUpdateCost.Text = obj.Cost?.ToString("N");
            txtUpdateDepth.Text = obj.Depth?.ToString("N");
            txtUpdateEditionSize.Text = obj.Edition_Size.ToString();
            txtUpdateHeight.Text = obj.Height?.ToString("N");
            txtUpdateManufacturer.Text = obj.Manufacturer.ToString();
            txtUpdateMaterial.Text = obj.Material.ToString();
            txtUpdateMonthlyPayment.Text = obj.Payment_Cost?.ToString("N");
            txtUpdateNrd.Text = obj.Non_Refundable_Deposit?.ToString("N");
            txtUpdateOrderNumber.Text = obj.Order_Number.ToString();
            txtUpdatePaymentLength.Text = obj.Payment_Length.ToString();
            txtUpdateQuantity.Text = obj.Quantity.ToString();
            txtUpdateRetailer.Text = obj.Retailer.ToString();
            txtUpdateStatueNumber.Text = obj.Statue_Number.ToString();
            txtUpdateStatueNumber.ReadOnly = true; //statue number is read only
            txtUpdateWeight.Text = obj.Weight?.ToString("N");
            txtUpdateWidth.Text = obj.Width?.ToString("N");
            cmbUpdateCape.Items.AddRange(new string[] { "Sculpted", "Fabric", "None" });
            cmbUpdateCape.SelectedItem = obj.Cape_Style.ToString();
            cmbUpdateExclusive.Items.AddRange(new string[] { "Yes", "No" });
            cmbUpdateExclusive.Text = obj.Exclusive.ToString();
            cmbUpdateHair.Items.AddRange(new string[] { "Sculpted", "Rooted", "N/A" });
            cmbUpdateHair.Text = obj.Hair_Type.ToString();
            cmbUpdateKit.Items.AddRange(new string[] { "Yes", "No" });
            cmbUpdateKit.Text = obj.Kit.ToString();
            cmbUpdateOwned.Items.AddRange(new string[] { "Yes", "No" });
            cmbUpdateOwned.Text = obj.Owned.ToString();
            cmbUpdatePaidOff.Items.AddRange(new string[] { "Yes", "No" });
            cmbUpdatePaidOff.Text = obj.Paid.ToString();
            cmbUpdateScale.Items.AddRange(new string[] { "Lifesize", "Half", "OneThird", "OneFourth", "OneFifth", "OneSixth", "OneEighth", "OneTenth", "Other" });
            cmbUpdateScale.Text = obj.Scale.ToString();
            dateTimePicker2.Value = (DateTime)obj.Order_Date; //requires casting
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var obj = statue.FindStatue(Global.IdtoUpdate);
            obj.Statue_Number = Convert.ToDecimal(txtUpdateStatueNumber.Text); //read only
            if (cmbUpdateCape.SelectedIndex >= 0) //mandatory field
            {
                obj.Cape_Style = cmbUpdateCape.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a Cape Style");
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateCharacter.Text)) //mandatory field
            {
                obj.Character = txtUpdateCharacter.Text;
            }
            else
            {
                MessageBox.Show("Please Enter a Character name");
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateCost.Text)) //optional field
            {
                obj.Cost = Convert.ToDecimal(txtUpdateCost.Text);
            }
            else
            {
                obj.Cost = null;
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateDepth.Text)) //optional field
            {
                obj.Depth = Convert.ToDecimal(txtUpdateDepth.Text);
            }
            else
            {
                obj.Depth = null;
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateEditionSize.Text)) //optional field
            {
                obj.Edition_Size = Convert.ToDecimal(txtUpdateEditionSize.Text);
            }
            else
            {
                obj.Edition_Size = null;
            }
            if (cmbUpdateExclusive.SelectedIndex == 0) //optional field, accounts for population of values true and false
            {
                obj.Exclusive = true;
            }
            else if (cmbUpdateExclusive.Text == "True")
            {
                obj.Exclusive = true;
            }
            else if (cmbUpdateExclusive.SelectedIndex == 1)
            {
                obj.Exclusive = false;
            }
            else if (cmbUpdateExclusive.Text == "False")
            {
                obj.Exclusive = false;
            }
            else
            {
                obj.Exclusive = null;
            }
            if (cmbUpdateHair.SelectedIndex >= 0) //mandatory field
            {
                obj.Hair_Type = cmbUpdateHair.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please Select a Hair Type");
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateHeight.Text)) //optional field
            {
                obj.Height = Convert.ToDecimal(txtUpdateHeight.Text);
            }
            else
            {
                obj.Height = null;
            }
            if (cmbUpdateKit.SelectedIndex == 0) //mandatory field, accounts for population of values true and false
            {
                obj.Kit = true;
            }
            else if (cmbUpdateKit.Text == "True")
            {
                obj.Kit = true;
            }
            else if (cmbUpdateKit.SelectedIndex == 1)
            {
                obj.Kit = false;
            }
            else if (cmbUpdateKit.Text == "False")
            {
                obj.Kit = false;
            }
            else
            {
                MessageBox.Show("Please select whether or not the statue is a kit");
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateManufacturer.Text)) //mandatory field
            {
                obj.Manufacturer = txtUpdateManufacturer.Text;
            }
            else
            {
                MessageBox.Show("Please Enter a Manufacturer name");
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateMaterial.Text)) //mandatory field
            {
                obj.Material = txtUpdateMaterial.Text;
            }
            else
            {
                MessageBox.Show("Please Enter a Material type");
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateNrd.Text)) //optional field
            {
                obj.Non_Refundable_Deposit = Convert.ToDecimal(txtUpdateNrd.Text);
            }
            else
            {
                obj.Non_Refundable_Deposit = null;
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateBoxes.Text)) //optional field
            {
                obj.Number_Of_Boxes = Convert.ToDecimal(txtUpdateBoxes.Text);
            }
            else
            {
                obj.Number_Of_Boxes = null;
            }
            if (dateTimePicker2 != null) //optional field
            {
                obj.Order_Date = dateTimePicker2.Value;
            }
            else
            {
                obj.Order_Date = null;
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateOrderNumber.Text)) //optional field
            {
                obj.Order_Number = Convert.ToDecimal(txtUpdateOrderNumber.Text);
            }
            else
            {
                obj.Order_Number = null;
            }

            if (cmbUpdateOwned.SelectedIndex == 0) //mandatory field, accounts for population of values true and false
            {
                obj.Owned = true;
            }
            else if (cmbUpdateOwned.Text == "True")
            {
                obj.Owned = true;
            }
            else if (cmbUpdateOwned.SelectedIndex == 1)
            {
                obj.Owned = false;
            }
            else if (cmbUpdateOwned.Text == "False")
            {
                obj.Owned = false;
            }
            else
            {
                MessageBox.Show("Please enter whether or not you own this statue");
            }
            if (cmbUpdatePaidOff.SelectedIndex == 0) //optional field, accounts for population of values true and false
            {
                obj.Paid = true;
            }
            else if (cmbUpdatePaidOff.Text == "True")
            {
                obj.Paid = true;
            }
            else if (cmbUpdatePaidOff.SelectedIndex == 1)
            {
                obj.Paid = false;
            }
            else if (cmbUpdatePaidOff.Text == "False")
            {
                obj.Paid = false;
            }
            else
            {
                obj.Paid = null;
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateMonthlyPayment.Text)) //optional field
            {
                obj.Payment_Cost = Convert.ToDecimal(txtUpdateMonthlyPayment.Text);
            }
            else
            {
                obj.Payment_Cost = null;
            }
            if (!string.IsNullOrWhiteSpace(txtUpdatePaymentLength.Text)) //optional field
            {
                obj.Payment_Length = Convert.ToDecimal(txtUpdatePaymentLength.Text);
            }
            else
            {
                obj.Payment_Length = null;
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateWidth.Text)) //optional field
            {
                obj.Width = Convert.ToDecimal(txtUpdateWidth.Text);
            }
            else
            {
                obj.Width = null;
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateWeight.Text)) //optional field
            {
                obj.Weight = Convert.ToDecimal(txtUpdateWeight.Text);
            }
            else
            {
                obj.Weight = null;
            }
            if (cmbUpdateScale.SelectedIndex >= 0) //mandatory field
            {
                obj.Scale = cmbUpdateScale.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a scale");
            }
            if (cmbUpdateHair.SelectedIndex >= 0) //mandatory field
            {
                obj.Hair_Type = cmbUpdateHair.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a hair style");
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateRetailer.Text)) //mandatory field
            {
                obj.Retailer = txtUpdateRetailer.Text;
            }
            else
            {
                MessageBox.Show("Please enter a retailer or 'Private'");
            }
            if (!string.IsNullOrWhiteSpace(txtUpdateQuantity.Text)) //mandatory field
            {
                obj.Quantity = Convert.ToDecimal(txtUpdateQuantity.Text);
            }
            else
            {
                MessageBox.Show("Please enter the quantity owned or purchased");
            }
            //if ((cmbUpdateScale.SelectedIndex > -1) && (cmbUpdateOwned.SelectedIndex > -1) && cmbUpdateCape.SelectedIndex > -1 && (cmbUpdateHair.SelectedIndex > -1) && (cmbUpdateKit.SelectedIndex > -1))
            //{
                statue.Update(obj.Statue_Number, obj);
                Clear(); //is this necessary? 
                this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Please ensure you've selected a value for all required drop-down boxes denoted with an asterisk.");
            //}
        } //update button, add information + validation
        private void Clear()
        {
            txtUpdateStatueNumber.ReadOnly = true;
            txtUpdateBoxes.Clear();
            txtUpdateCharacter.Clear();
            txtUpdateCost.Clear();
            txtUpdateDepth.Clear();
            txtUpdateEditionSize.Clear();
            txtUpdateHeight.Clear();
            txtUpdateManufacturer.Clear();
            txtUpdateMaterial.Clear();
            txtUpdateMonthlyPayment.Clear();
            txtUpdateNrd.Clear();
            txtUpdateOrderNumber.Clear();
            txtUpdatePaymentLength.Clear();
            txtUpdateQuantity.Clear();
            txtUpdateRetailer.Clear();
            txtUpdateStatueNumber.Clear();
            txtUpdateWeight.Clear();
            txtUpdateWidth.Clear();
            cmbUpdateCape.SelectedIndex = -1;
            cmbUpdateExclusive.SelectedIndex = -1;
            cmbUpdateHair.SelectedIndex = -1;
            cmbUpdateKit.SelectedIndex = -1;
            cmbUpdateOwned.SelectedIndex = -1;
            //dateTimePickerAddNew.Value is null;
            cmbUpdateScale.SelectedIndex = -1;
            cmbUpdatePaidOff.SelectedIndex = -1;
        }

        private void txtUpdateCharacter_Leave(object sender, EventArgs e) //mandatory field, validates field content
        {
            if (string.IsNullOrWhiteSpace(txtUpdateCharacter.Text))
            {
                MessageBox.Show("Please enter Character Information.");
                txtUpdateCharacter.Focus();
            }
        }

        private void txtUpdateManufacturer_Leave(object sender, EventArgs e) //mandatory field, validates field content
        {
            if (string.IsNullOrWhiteSpace(txtUpdateManufacturer.Text))
            {
                MessageBox.Show("Please enter Manufacturer Information.");
                txtUpdateManufacturer.Focus();
            }
        }

        private void txtUpdateMaterial_Leave(object sender, EventArgs e) //mandatory field, validates field content
        {
            if (string.IsNullOrWhiteSpace(txtUpdateMaterial.Text))
            {
                MessageBox.Show("Please enter Material Information.");
                txtUpdateMaterial.Focus();
            }
        }

        private void txtUpdateRetailer_Leave(object sender, EventArgs e) //mandatory field, validates field content
        {
            if (string.IsNullOrWhiteSpace(txtUpdateRetailer.Text))
            {
                MessageBox.Show("Please enter Retailer Information or 'Private'.");
                txtUpdateRetailer.Focus();
            }
        }

        private void txtUpdateCost_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateCost.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateCost.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Cost or leave it empty.");
                    txtUpdateCost.Clear();
                }
            }
        }

        private void txtUpdateEditionSize_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateEditionSize.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateEditionSize.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Edition Size or leave it empty.");
                    txtUpdateEditionSize.Clear();
                }
            }
        }

        private void txtUpdateQuantity_Leave(object sender, EventArgs e)   //mandatory, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateQuantity.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateQuantity.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Quantity.");
                    txtUpdateQuantity.Focus();
                }
            }
        }

        private void txtUpdateHeight_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateHeight.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateHeight.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Height or leave it empty.");
                    txtUpdateHeight.Clear();
                }
            }
        }

        private void txtUpdateWidth_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateWidth.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateWidth.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Width or leave it empty.");
                    txtUpdateWidth.Clear();
                }
            }
        }

        private void txtUpdateDepth_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateDepth.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateDepth.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Depth or leave it empty.");
                    txtUpdateDepth.Clear();
                }
            }
        }

        private void txtUpdateWeight_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateWeight.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateWeight.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Weight or leave it empty.");
                    txtUpdateWeight.Clear();
                }
            }
        }

        private void txtUpdateBoxes_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateBoxes.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateBoxes.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the number of boxes or leave it empty.");
                    txtUpdateBoxes.Clear();
                }
            }
        }

        private void txtUpdateOrderNumber_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateOrderNumber.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateOrderNumber.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Order Number or leave it empty.");
                    txtUpdateOrderNumber.Clear();
                }
            }
        }

        private void txtUpdatePaymentLength_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdatePaymentLength.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdatePaymentLength.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Payment Plan Length in Months or leave it empty.");
                    txtUpdatePaymentLength.Clear();
                }
            }
        }

        private void txtUpdateMonthlyPayment_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateMonthlyPayment.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateMonthlyPayment.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Monthly Payment Amount or leave it empty.");
                    txtUpdateMonthlyPayment.Clear();
                }
            }
        }

        private void txtUpdateNrd_Leave(object sender, EventArgs e) //optional field, validates use of a numerical value
        {
            if (!string.IsNullOrWhiteSpace(txtUpdateNrd.Text))
            {
                decimal test;
                if (decimal.TryParse(txtUpdateNrd.Text, out test))
                {
                }
                else
                {
                    MessageBox.Show("Please enter a numerical value for the Non-Refundable Deposit or leave it empty.");
                    txtUpdateNrd.Clear();
                }
            }
        }

        private void cmbUpdateScale_Leave(object sender, EventArgs e) //mandatory field, validates whether a value is selected
        {
            if (cmbUpdateScale.SelectedIndex == -1||cmbUpdateScale.Text.Length ==0)
            {
                MessageBox.Show("Please select a Scale from the drop down.");
            }
        }

        private void cmbUpdateOwned_Leave(object sender, EventArgs e) //mandatory field, validates whether a value is selected
        {
            if (cmbUpdateOwned.SelectedIndex == -1||cmbUpdateOwned.Text.Length==0)
            {
                MessageBox.Show("Please select whether or not the statue is currently in your collection from the drop down.");
            }
        }

        private void cmbUpdateKit_Leave(object sender, EventArgs e) //mandatory field, validates whether a value is selected
        {
            if (cmbUpdateKit.SelectedIndex == -1||cmbUpdateKit.Text.Length==0)
            {
                MessageBox.Show("Please select whether or not the statue is a kit from the drop down.");
            }
        }

        private void cmbUpdateCape_Leave(object sender, EventArgs e) //mandatory field, validates whether a value is selected
        {
            if (cmbUpdateCape.SelectedIndex == -1||cmbUpdateCape.Text.Length==0)
            {
                MessageBox.Show("Please select the cape style from the drop down.");
            }
        }

        private void cmbUpdateHair_Leave(object sender, EventArgs e) //mandatory field, validates whether a value is selected
        {
            if (cmbUpdateHair.SelectedIndex == -1 || cmbUpdateHair.Text.Length==0)
            {
                MessageBox.Show("Please select the hair style from the drop down.");
            }
        }
    }
}
