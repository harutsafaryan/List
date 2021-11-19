using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementation
{
    class ListofMonths<Int32>
    {
        private int[] _items = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        public int this[string index]
        {
            get
            {
                switch (index)
                {
                    case "January": return _items[0];
                    case "February": return _items[1];
                    case "March": return _items[2]; ;
                    case "April": return _items[3]; ;
                    case "May": return _items[4];
                    case "June": return _items[5];
                    case "July": return _items[6];
                    case "August": return _items[7];
                    case "September": return _items[8];
                    case "October": return _items[9];
                    case "November": return _items[10];
                    case "December": return _items[11];
                    default: throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case "January":
                        _items[0] = value;
                        break;
                    case "February":
                        _items[1] = value;
                        break;
                    case "March":
                        _items[2] = value;
                        break;
                    case "April":
                        _items[3] = value;
                        break;
                    case "May":
                        _items[4] = value;
                        break;
                    case "June":
                        _items[5] = value;
                        break;
                    case "July":
                        _items[6] = value;
                        break;
                    case "August":
                        _items[7] = value;
                        break;
                    case "September":
                        _items[8] = value;
                        break;
                    case "October":
                        _items[9] = value;
                        break;
                    case "December":
                        _items[11] = value;
                        break;
                    case "November":
                        _items[10] = value;
                        break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
