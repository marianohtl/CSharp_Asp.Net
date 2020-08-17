using DgBar.Domain.Entities;
using DgBar.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DgBar.Domain.Interfaces
{
    public interface IOrderManageService 
    {
        SheetOrder RegistryOrder(int? idSheetOrder, int? idItem);
        OrderViewModel GenerateNote(int id);
        bool ResetOrder(int id);
    }
}
