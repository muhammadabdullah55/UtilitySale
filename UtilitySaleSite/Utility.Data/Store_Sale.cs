//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Utility.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Store_Sale
    {
        public int Store_Sale_ID { get; set; }
        public Nullable<int> Store_Info_ID { get; set; }
        public string Sale_Text { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Updated_On { get; set; }
        public string Updated_By { get; set; }
    
        public virtual Store_Info Store_Info { get; set; }
    }
}
