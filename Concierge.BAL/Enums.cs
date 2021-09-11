using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.BAL
{
    public class Enums
    {
        public enum SalesOrderTypeEnum
        {
            Room = 1,
            Resturant = 2,
            Bar = 3,
            Ammentites = 4

        }

        //This should match the table StandardLookup.

        public enum StandardLookupGroup
        {
            SaleOrderCategories=1,

        }

        public enum StockItemTypeEnum
        {
            Room = 1,
            Resturant = 2,
            Bar = 3,
            Ammentites = 4

        }

        public enum BedTypeEnum
        {
            Single=1,
            DualSingle=2,
            Double=3,
            DoubleQueen=4,
            DoubleKing=5,
            InfantBed=6,
            InfantCot =7
        }
        public enum SaleOrderStatus
        {
            Submitted = 1,
            PartPaid = 2,
            PaidFull = 3,
            Completed = 4

        }
        public enum SaleOrderFoodDrinkOrderStatus
        {
            HouseOrder = 0,
            TakeAwayOrder=1,
            Kitchen = 2,
            SendToTable = 3,
            Completed=4

        }


        public enum ContactTypeEnum
        {
            Mobile=1,
            LandLine=2,
            Email=3
        }

        public enum DrinkTypeEnum
        {
            Soda=1,
            Water=2,
            Wine=3,
            Cocktail=4,
            Bear=5,
            Other=6

        }
    }
}
