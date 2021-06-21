using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Merceria4.Models
{
    public class ProdCarro
    {
        private contextMerceria2 db = new contextMerceria2();
        private List<Productos> products;
        public ProdCarro()
        {
            products = db.Productos.ToList();

        }

        public List<Productos> findAll()
        {
            return this.products;
        }

        public Productos find(int id)
        {
            Productos pp = this.products.Single(p => p.Id.Equals(id));
            return pp;
        }
    }
}