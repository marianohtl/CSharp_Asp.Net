using DgBar.Domain.Entities;
using DgBar.Domain.Interfaces;
using DgBar.Domain.ViewModels;
using System;
using System.Collections.Generic;

namespace DgBar.Domain.Services
{
    public class OrderManageService : IOrderManageService
    {
        private readonly IOrderSheetRepository _repositoryOrder;
        private readonly IMenuRepository _repositoryMenu;

        public OrderManageService(IOrderSheetRepository repositoryOrder, IMenuRepository repositoryMenu)
        {
            _repositoryOrder = repositoryOrder;
            _repositoryMenu = repositoryMenu;
        }

        public SheetOrder RegistryOrder(int? idSheetOrder, int? idItem)
        {
            try
            {

                //SheetOrder sheetOrder = _repositoryOrder.GetOrderById(idSheetOrder);
                SheetOrder sheetOrderItem = _repositoryOrder.GetItemByIdAndOrder(idItem, idSheetOrder);
                Menu menu = _repositoryMenu.GetById(idItem);
                SheetOrder newOrderSheet = new SheetOrder();

                if (menu != null)
                {
                    if(sheetOrderItem != null)
                    {
                        sheetOrderItem.Amount += 1;
                        _repositoryOrder.Update(sheetOrderItem);
                        return sheetOrderItem;
                    } else {
                        newOrderSheet.IdOrder = idSheetOrder;
                        newOrderSheet.IdMenu = idItem;
                        newOrderSheet.Amount = 1;
                        _repositoryOrder.Save(newOrderSheet);
                    }
                }

                return newOrderSheet;
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public OrderViewModel GenerateNote(int id)
        {
            List<SheetOrder> orders = _repositoryOrder.GetAllOrdersById(id);
            OrderViewModel note = new OrderViewModel();

            foreach (SheetOrder details in orders)
            {
                var item = _repositoryMenu.GetById(details.IdMenu);
                note.Items.Add(item);

                int freeWatter = 0;
                int amoutBeer = 0;

                switch (details.IdMenu)
                {
                    case 1:
                        amoutBeer = details.Amount;
                        int amoutDesc = amoutBeer % 5;
                        var descountBeer = amoutDesc * item.Price;
                        note.Discount = descountBeer;
                        note.TotalDiscount += note.Discount;
                        break;
                    case 2:
                        if (amoutBeer >= 2 && details.Amount >= 3)
                        {
                            freeWatter = 1;
                        }
                        break;
                    case 4:
                        if (freeWatter == 1)
                        {
                            note.Discount = -50;
                            note.TotalDiscount += note.Discount;
                            details.Amount += 1;
                        }
                        break;
                }
                note.TotalPrice += details.Amount * item.Price;
                note.TotalDiscount += details.Discount;
            }

            return note;
        }


        public bool ResetOrder(int id)
        {
            try
            {
                var orders = _repositoryOrder.GetAllOrdersById(id);
                foreach (SheetOrder details in orders)
                {
                    var result = _repositoryOrder.Delete(details.IdOrder);
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }
   
    }
}
