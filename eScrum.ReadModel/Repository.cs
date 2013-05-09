using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eScrum.ReadModel
{
    public class Repository
    {
        public IEnumerable<BacklogItemDto> GetAllBacklogItem()
        {
            return DB.BacklogItems;
        }
    }
}
