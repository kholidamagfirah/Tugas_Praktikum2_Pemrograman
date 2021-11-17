using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204003
{
    public class Book_1204003 : Product_1204003
    {
        protected string pageCount;

        public Book_1204003(string mytype, string mytitle, string pagecount) : base(mytype, mytitle)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get

            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }
            
     }
}