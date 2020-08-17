using System;
using System.Collections.Generic;

namespace DgBar.Domain.Entities
{
    public partial class Menu
    {
        public Menu()
        {
            SheetOrder = new HashSet<SheetOrder>();
        }

        public int Id { get; set; }
        public string Item { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<SheetOrder> SheetOrder { get; set; }
    }
}
