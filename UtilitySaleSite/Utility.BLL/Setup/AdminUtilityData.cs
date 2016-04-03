using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Data;

namespace Utility.BLL.Setup
{
  public class AdminUtilityData
    {
        public List<Utility.Data.Utility> GetAllUtilities()
        {
            using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
            {
                List<Utility.Data.Utility> Utilities = dbContext.Utilities.ToList();
                return Utilities;

            }
             
            

        }
        public Boolean SaveUtility(Utility.Data.Utility utility)
        {
            if (string.IsNullOrEmpty(utility.Utility_ID.ToString()))  // New Record
            {
                using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
                {
                    dbContext.Utilities.Add(utility);
                    dbContext.SaveChanges();
                    return true;

                }

            }
            else  // Update Record
            {
                using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
                {
                    Utility.Data.Utility Utility = dbContext.Utilities.Where(x => x.Utility_ID == utility.Utility_ID).FirstOrDefault();
                    Utility.Utility_Name = utility.Utility_Name;
                    Utility.Is_Active = utility.Is_Active;
                    Utility.City_ID = utility.City_ID;
                    Utility.Updated_On = DateTime.Now;
                    Utility.Updated_By = "user";
                    return true;
                }

            }

        }
    }
}
