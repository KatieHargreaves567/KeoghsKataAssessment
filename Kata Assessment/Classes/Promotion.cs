using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Assessment.Classes
{
    public class Promotion
    {
        int promotionID { get; set; }
        string promotionDisplayName { get; set; }

        //Note: Promotions are typically time-sensitive so for scalability, it would be wise to include this field
        bool promotionActive { get; set; }

        public Promotion (int promotionID, string promotionDisplayName, bool promotionActive)
        {
            this.promotionID = promotionID;
            this.promotionDisplayName = promotionDisplayName;
            this.promotionActive = promotionActive;
        }
        
        //Note: in a database-driven application, the below method would be a database call
        public static Promotion getPromotionByID(int promotionID)
        {
            if (promotionID == 1)
            {
                return new Promotion(1, "3 for £40", true);
            }
            else if (promotionID == 2)
            {
                return new Promotion(2, "25% off for every 2 purchased together", true);
            }
            else
            {
                return null;    
            }
        }
    }
}
