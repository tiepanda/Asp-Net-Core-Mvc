using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ProductRepository : Repository<Product> , IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) :base(db) 
        {
            _db = db;

        }



        //public void Update(Product obj)
        //{
        //    _db.Products.Update(obj);
        //}



        //this is explisit implementation to keep the last data which has not been updated when editing.
        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.TicketTitle = obj.TicketTitle;
                objFromDb.Description = obj.Description;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Publisher = obj.Publisher;
                objFromDb.TicketPrice = obj.TicketPrice;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Location = obj.Location;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }

        }

    }
}
