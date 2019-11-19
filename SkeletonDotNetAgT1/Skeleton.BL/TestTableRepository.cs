using Skeleton.DAL;
using Skeleton.DAL.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Skeleton.BL
{
    public class TestTableRepository
    {
        public List<TestTable> Get()
        {
            using (var context = new SkeletonDatabaseContext())
            {
                return (from d in context.TestTable
                        select new TestTable()
                        {
                            Id = d.Id,
                            Name = d.Name,
                            OrderNumber = d.OrderNumber
                        }).ToList();
            }
        }
    }
}
