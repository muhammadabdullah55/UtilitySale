using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Data;



namespace Utility.BLL.Setup
{
    public class UtilityData
    {
        public List<Utility.Data.Utility> GetAllUtilities()
        {
            List<Utility.Data.Utility> Utility;
            using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
            {
                Utility = dbContext.Utilities.OrderBy(x=>x.Utility_Name).ToList();
                return Utility;
            }
           
          
        }


        public List<Store_Info> GetStoreInfoByUtilityID(int UtilityID)
        {
          using( UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
          {
              List<Store_Info> StoreInforamtion = dbContext.Store_Info.Where(x => x.Utility_ID == UtilityID).ToList();
              return StoreInforamtion;

          }
        }

    } 
}
