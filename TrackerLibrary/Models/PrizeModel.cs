using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }


        public PrizeModel()
        {
            
        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizepercentage)
        {
            //prizeNumber
            int placeNumberValue = 0;
            int.TryParse(placeNumber,out placeNumberValue);
            PlaceNumber = placeNumberValue;

            PlaceName = placeName;

            //prizeAmount
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            // prize Percentage
            double prizepercentageValue = 0;
            double.TryParse(prizepercentage, out prizepercentageValue);
            PrizePercentage = prizepercentageValue;



        }


    }
}
