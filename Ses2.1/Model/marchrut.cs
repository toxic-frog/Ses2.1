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
    
    public partial class marchrut
    {
        public marchrut()
        {
            this.avtobus = new HashSet<avtobus>();
        }
    
        public int id_marchrut { get; set; }
        public int id_poezdki { get; set; }
        public string nomer { get; set; }
        public string names { get; set; }
        public string nachalnaia_ostanovka { get; set; }
        public string konecnaia_ostanovka { get; set; }
        public string vipolnena_marshrut { get; set; }
    
        public virtual ICollection<avtobus> avtobus { get; set; }
        public virtual poezdki poezdki { get; set; }
    }
}
