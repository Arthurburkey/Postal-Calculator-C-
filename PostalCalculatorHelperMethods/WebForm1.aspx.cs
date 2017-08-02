using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostalCalculatorHelperMethods
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        private void performChanged()
        {
            //throw new NotImplementedException();
            if (!valuesExist()) return;
            int volume = 0;
            if (!tryGetVolume(out volume)) return;
            double postageMultiplier = getPostageMultiplier();
            double cost = volume * postageMultiplier;
            resultLabel.Text = String.Format("Your parcel will cost {0} to ship.", cost);

        }

        private double getPostageMultiplier()
        {
            if (groundButton.Checked) return .15;
            else if (airButton.Checked) return .25;
            else if (nextDayButton.Checked) return .45;
            else return 0; 
        }

        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;
            return true;
        }

        private bool valuesExist()
        {
            if (!airButton.Checked
                && !groundButton.Checked
                && !nextDayButton.Checked)
                return false;

            if (widthTextBox.Text.Trim().Length == 0
                || heightTextBox.Text.Trim().Length == 0)
                return false;
            return true; 

        }
        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void groundButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void airButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void nextDayButton_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }
    }
}