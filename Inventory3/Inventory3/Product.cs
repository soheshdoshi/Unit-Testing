using System;

namespace Inventory3
{
        public class item
        {
            string _productname;
            double _productprice;
            int _produtquantity;
            string _producttype;
            public int Quantity
            {
                get { return _produtquantity; }
                set { _produtquantity = value; }
            }

            public string Name
            {
                get { return _productname; }
                set { _productname = value; }
            }
            public double Price
            {
                get { return _productprice; }
                set { _productprice = value; }
            }
            public string Type
            {
                get { return _producttype; }
                set { _producttype = value; }
            }
            public override string ToString()
            {
                return "ProductName:-" + Name + " " + "ProductPrice:-" + Price + " RS" + " " + "ProdctQuantity:-" + Quantity + " " + "ProductType:-" + Type;
            }

        }
    }
