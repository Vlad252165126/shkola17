//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shkola17.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class sotr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sotr()
        {
            this.Invent = new HashSet<Invent>();
        }
    
        public int ID_sotr { get; set; }
        public string FIO_sotr { get; set; }
        public string teleph { get; set; }
        public string Doljnost { get; set; }
        public string organizaci { get; set; }
        public string oborud_use { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invent> Invent { get; set; }
    }
}
