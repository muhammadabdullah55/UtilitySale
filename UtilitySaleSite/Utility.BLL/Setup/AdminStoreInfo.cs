using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Data;

namespace Utility.BLL.Setup
{
   public class AdminStoreInfo
    {
       public List<Store_Info> GetStoreByUtilityID(int UtilityID)
       {
           using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
           {
               return dbContext.Store_Info.Where(x => x.Utility_ID == UtilityID).ToList();

           }
       }

       public List<Store_Branches> GetStoreBranches(int StoreInfoID)
       {
           using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
           {
              return  dbContext.Store_Branches.Where(x => x.Store_Info_ID == StoreInfoID).ToList();

           }
           
       }

       public Store_Sale GetSaleInfoByStoreInfoID(int StoreInfoID)
       {

           using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
           {
               return dbContext.Store_Sale.Where(x => x.Store_Info_ID == StoreInfoID).FirstOrDefault();

           }
       }

       public Boolean SaveStore(Store_Info storeinfo)
       {
           if (string.IsNullOrEmpty(storeinfo.Store_Info_ID.ToString()))  // New Record
           {
               using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
               {
                   dbContext.Store_Info.Add(storeinfo);
                   dbContext.SaveChanges();
                   return true;

               }

           }
           else  // Update Record
           {
                   using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
                   {
                       Store_Info info = dbContext.Store_Info.Where(x => x.Store_Info_ID == storeinfo.Store_Info_ID).FirstOrDefault();
                       info.Store_Name = storeinfo.Store_Name;
                       info.Is_Active = storeinfo.Is_Active;
                       info.Updated_On = DateTime.Now;
                       info.Updated_By = "User";
                       dbContext.SaveChanges();
                       return true;
                   }
              
           }

       }


       public Boolean SaveStoreBranch(Store_Branches storeBranch)
       {
           if (string.IsNullOrEmpty(storeBranch.Store_Branch_ID.ToString()))  // New Record
           {
               using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
               {
                   dbContext.Store_Branches.Add(storeBranch);
                   dbContext.SaveChanges();
                   return true;

               }

           }
           else  // Update Record
           {
               using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
               {
                   Store_Branches branches = dbContext.Store_Branches.Where(x=>x.Store_Branch_ID == storeBranch.Store_Branch_ID).FirstOrDefault();
                   branches.Branch_Address = storeBranch.Branch_Address;
                   branches.Branch_Name = storeBranch.Branch_Name;
                   branches.Is_Active = storeBranch.Is_Active;
                   dbContext.SaveChanges();
                   return true;
               }

           }

       }

       public Boolean SaveSaleData(Store_Sale storeSale)
       {
           if (string.IsNullOrEmpty(storeSale.Store_Sale_ID.ToString()))  // New Record
           {
               using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
               {
                   dbContext.Store_Sale.Add(storeSale);
                   dbContext.SaveChanges();
                   return true;

               }

           }
           else  // Update Record
           {
               using (UtilitySaleDBContext dbContext = new UtilitySaleDBContext())
               {
                   Store_Sale storesale = dbContext.Store_Sale.Where(x => x.Store_Sale_ID == storeSale.Store_Sale_ID).FirstOrDefault();
                   dbContext.SaveChanges();
                   return true;
               }

           }

       }
      





    }
}
