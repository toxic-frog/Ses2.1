//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ses2._1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class poezdki
    {
        public poezdki()
        {
            this.marchrut = new HashSet<marchrut>();
        }
    
        public int id_poezdki { get; set; }
        public Nullable<System.TimeSpan> vremu_nahala { get; set; }
        public Nullable<System.TimeSpan> vremu_okonhana { get; set; }
        public Nullable<System.DateTime> data_poezdki { get; set; }
        public string prodolchitelnost { get; set; }
    
        public virtual ICollection<marchrut> marchrut { get; set; }
    }
}