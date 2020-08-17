using DgBar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DgBar.Domain.ViewModels
{
    public class SheetOrderViewModel
    {
        public int? IdOrder { get; set; }
        public int? IdMenu { get; set; }
        public int Amount { get; set; }

        public SheetOrderViewModel()
        {
        }

        public SheetOrderViewModel(SheetOrder _sheetOrder)
        {
            IdOrder = _sheetOrder.IdOrder;
            IdMenu = _sheetOrder.IdMenu;
            Amount = _sheetOrder.Amount;
        }

    }
}
