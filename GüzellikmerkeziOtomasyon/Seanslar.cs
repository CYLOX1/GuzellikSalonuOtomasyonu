//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GüzellikmerkeziOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seanslar
    {
        public int SeansID { get; set; }
        public Nullable<int> musteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<int> hizmetID { get; set; }
        public string VerilenHizmet { get; set; }
        public System.DateTime Tarih { get; set; }
        public System.TimeSpan Saat { get; set; }
        public Nullable<int> kazanc { get; set; }
    
        public virtual hizmetler hizmetler { get; set; }
        public virtual müşteriler müşteriler { get; set; }
    }
}
