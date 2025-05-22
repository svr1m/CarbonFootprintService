using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CarbonFootprintService
{
  
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class CarbonService : System.Web.Services.WebService
    {
        [WebMethod]
        public double CalculateEnergyFootprint(double energyKWh, double emissionFactor)
        {
            return energyKWh * emissionFactor;
        }

        [WebMethod]
        public double CalculateTransportFootprint(double distanceKm, double emissionFactor)
        {
            return distanceKm * emissionFactor;
        }

        [WebMethod]
        public double CalculateWasteFootprint(double wasteTonnes, double emissionFactor)
        {
            return wasteTonnes * emissionFactor;
        }

        [WebMethod]
        public double CalculateTotalFootprint(double energyFootprint, double transportFootprint, double wasteFootprint)
        {
            return energyFootprint + transportFootprint + wasteFootprint;
        }
    }
}
