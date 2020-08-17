using DgBar.Domain.Entities;
using DgBar.Domain.Interfaces;
using DgBar.InfraData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DgBar.InfraData.Repository
{
    public class MenuRepository : IMenuRepository
    {

        private readonly BarDGContext _context;

        public MenuRepository(BarDGContext context)
        {
            this._context = context;
        }

        public Menu GetById(int? Id)
        {
            if(Id != null)
            {
                return _context.Menu.Where(x => x.Id == Id).FirstOrDefault();
            }
            return null;
        }

        public List<Menu> GetAllItems() { 
            return _context.Menu.ToList();
        }

}
}
