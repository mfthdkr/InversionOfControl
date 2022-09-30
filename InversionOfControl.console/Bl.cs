using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl.console
{
    public class Bl
    {
        private IDal Dal { get; set; }

        public Bl(IDal dal)
        {
            Dal = dal;
        }

        public List<Product> GetProducts()
        {
            return Dal.GetProducts();
        }
    }
}
