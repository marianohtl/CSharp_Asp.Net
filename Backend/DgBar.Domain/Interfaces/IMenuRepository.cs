using DgBar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DgBar.Domain.Interfaces
{
    public interface IMenuRepository
    {
        Menu GetById(int? Id);
        List<Menu> GetAllItems();
   
    }
}
