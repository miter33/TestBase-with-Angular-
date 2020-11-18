using System;
using System.Collections.Generic;
using System.Text;

namespace TestBase.Common.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Test> Tests { get; set; }
    }
}
