using System;
using System.Collections.Generic;

namespace Skeleton.DAL.Models
{
    public partial class TestTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OrderNumber { get; set; }
    }
}
