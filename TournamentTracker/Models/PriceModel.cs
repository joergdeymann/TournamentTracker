using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    public class PriceModel
    {
        /// <summary>
        /// Id for the Price
        /// </summary>
        public int Id {  get; set; }
        public int PlaceNumber{get;set;}
	    public string PlaceName { get; set; }
        public decimal PriceAmount { get; set; }
        public double PricePercentage { get; set; }

        public PriceModel()
        {

        }
        public PriceModel(string placeName, string placeNumber,string priceAmount, string pricePercentage)
        {
            PlaceName = placeName;

            int.TryParse(placeNumber, out int placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal.TryParse(priceAmount, out decimal priceAmountValue);
            PriceAmount = priceAmountValue;

            double.TryParse(pricePercentage, out double pricePercentageValue);
            PricePercentage = pricePercentageValue;



        }

    }
}
