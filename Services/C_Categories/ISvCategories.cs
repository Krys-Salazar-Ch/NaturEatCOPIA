﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services.C_Categories
{
    public interface ISvCategories
    {
        public Categories Add_Categories();

        List<Product> Products();
    }
}
