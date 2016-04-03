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
              List<Store_Info> StoreInforamtion = dbContext.Store_Info.Include("Store_Branches").Include("Store_Sale").Where(x => x.Utility_ID == UtilityID).ToList();
              return StoreInforamtion;
              
          }
        }

        public List<Store_Branches> GetBranchByStoreID(int Store_Info_ID)
        {
            using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
            {

                List<Store_Branches> Branches = dbContext.Store_Branches.Where(x => x.Store_Info_ID == Store_Info_ID).ToList();
                return Branches;

            }
        }

        public List<City> GetAllCities()
        {
            using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
            {
                return dbContext.Cities.ToList();
            }


        }

        public List<Store_Sale> GetStoreSaleInfo(int Store_Info_ID)
        {
            using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
            {

                List<Store_Sale> storesale = dbContext.Store_Sale.Where(x => x.Store_Info_ID == Store_Info_ID).ToList();
                return storesale;

            }
        }

        public Utility.Data.Utility GetUtilityByID(int UtilityID)
        {
            using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
            {
               return  dbContext.Utilities.Where(x => x.Utility_ID == UtilityID).FirstOrDefault();

            }
        }

        public Store_Info GetStoreInfoByStoreInfoID(int StoreInfoID)
        {
            using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
            {
                return dbContext.Store_Info.Where(x => x.Store_Info_ID == StoreInfoID).FirstOrDefault();

            }
        }
      
        public Store_Sale GetSaleInfoBySaleID(int SaleID)
        {
            using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
            {
                return dbContext.Store_Sale.Where(x => x.Store_Sale_ID == SaleID).FirstOrDefault();

            }
        }
        public Store_Branches GetBranchByBranchID(int BranchID)
        {
            using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
            {
                return dbContext.Store_Branches.Where(x => x.Store_Branch_ID == BranchID).FirstOrDefault();

            }
        }

    } 
}
