using System;
using System.Collections.Generic;

namespace DgBar.Domain.Entities
{
    public partial class SheetOrder
    {
        public int Id { get; set; }
        public int? IdOrder { get; set; }
        public int? IdMenu { get; set; }
        public int Amount { get; set; }
        public decimal? Discount { get; set; }

        public virtual Menu IdMenuNavigation { get; set; }
    }
}
