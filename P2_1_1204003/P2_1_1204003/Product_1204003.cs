﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204003
{
    public class Product_1204003
    {
        private string myType;
        private string myTitle;

        public Product_1204003()
        {

        }

        public Product_1204003(string mytype, string mytitle)
        {
            this.myType = mytype;
            this.myTitle = mytitle;
        }


        public string MyType
        {
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }

        public string MyTitle
        {
            get
            {
                return myTitle;
            }

            set
            {
                myTitle = value;
            }
        }
    }
}