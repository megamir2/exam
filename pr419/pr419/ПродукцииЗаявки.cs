//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr419
{
    using System;
    using System.Collections.Generic;
    
    public partial class ПродукцииЗаявки
    {
        public int ид_заявки { get; set; }
        public string артикул_продукции { get; set; }
        public int количество { get; set; }
        public int партия { get; set; }
    
        public virtual Заявкт Заявкт { get; set; }
        public virtual Продукция Продукция { get; set; }
    }
}
