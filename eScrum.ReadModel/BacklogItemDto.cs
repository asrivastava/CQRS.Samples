using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eScrum.ReadModel
{
    public class BacklogItemDto
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Point { get; set; }
    }
}
