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
    
    public partial class avtobus
    {
        public int id_aytobus { get; set; }
        public int id_voditela { get; set; }
        public int id_marchrut { get; set; }
        public string gosnomer { get; set; }
        public string marka { get; set; }
        public string vmestimast { get; set; }
    
        public virtual marchrut marchrut { get; set; }
        public virtual voditela voditela { get; set; }
    }
}
