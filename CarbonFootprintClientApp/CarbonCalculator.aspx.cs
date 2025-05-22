using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarbonFootprintClientApp.CarbonRef;

namespace CarbonFootprintClientApp
{
    public partial class CarbonCalculator : System.Web.UI.Page
    {
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double energy = double.Parse(txtEnergy.Text);
                double energyFactor = double.Parse(txtEnergyFactor.Text);

                double distance = double.Parse(txtDistance.Text);
                double transportFactor = double.Parse(txtTransportFactor.Text);

                double waste = double.Parse(txtWaste.Text);
                double wasteFactor = double.Parse(txtWasteFactor.Text);

                CarbonService service = new CarbonService();

                double energyCO2 = service.CalculateEnergyFootprint(energy, energyFactor);
                double transportCO2 = service.CalculateTransportFootprint(distance, transportFactor);
                double wasteCO2 = service.CalculateWasteFootprint(waste, wasteFactor);

                double total = service.CalculateTotalFootprint(energyCO2, transportCO2, wasteCO2);

                lblResult.Text = $"Energy: {energyCO2} kg CO2<br/>" +
                                 $"Transport: {transportCO2} kg CO2<br/>" +
                                 $"Waste: {wasteCO2} kg CO2<br/><br/>" +
                                 $"<strong>Total: {total} kg CO2</strong>";
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error: " + ex.Message;
            }
        }
    }
}
