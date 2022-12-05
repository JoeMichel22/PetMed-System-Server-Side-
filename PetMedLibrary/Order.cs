using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PetMedLibrary
{
    public class Order
    {
        ArrayList orderList = new ArrayList();

        public Order()
        {

        }

        public ArrayList List
        {
            get { return orderList; }
            set { orderList = value; }
        }

    }
}
