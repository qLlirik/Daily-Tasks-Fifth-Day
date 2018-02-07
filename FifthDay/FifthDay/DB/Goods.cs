//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FifthDay.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods()
        {
            this.GoodsBuy = new HashSet<GoodsBuy>();
        }
    
        public string ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int CountryID { get; set; }
        public int CompanyID { get; set; }
        public byte[] Picture { get; set; }
        public System.DateTime DateStart { get; set; }
        public short Period { get; set; }
        public decimal Cost { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Companies Companies { get; set; }
        public virtual Countries Countries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsBuy> GoodsBuy { get; set; }
    }
}
