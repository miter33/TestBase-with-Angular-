using System;
using System.Collections.Generic;
using System.Text;

namespace TestBase.Common.Entities
{
    public class Test
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
