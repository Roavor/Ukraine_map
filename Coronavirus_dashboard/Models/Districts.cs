//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coronavirus_dashboard.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Districts
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Disease { get; set; }
        public Nullable<int> Recovered { get; set; }
        public Nullable<int> Died { get; set; }
        public Nullable<int> Sick { get; set; }
    }
}
