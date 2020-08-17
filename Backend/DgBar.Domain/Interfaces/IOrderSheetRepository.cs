using DgBar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DgBar.Domain.Interfaces
{
    public interface IOrderSheetRepository
    {
        SheetOrder GetOrderById(int Id);

        SheetOrder GetItemByIdAndOrder(int? IdItem,int? IdSheetOrder);

        List<SheetOrder> GetAllOrdersById(int Id);

        SheetOrder Save(SheetOrder sheetOrder);

        SheetOrder Update(SheetOrder sheetOrder);

        bool Delete(int? idSheetOrder);

    }
}
