﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class PackageProductSupplier
    {
        public int PackageId { get; set; }
        public int ProductSupplierId { get; set; }

        public PackageProductSupplier(int packageId, int productSupplierId)
        {
            PackageId = packageId;
            ProductSupplierId = productSupplierId;
        }
    }
}
