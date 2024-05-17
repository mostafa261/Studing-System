using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studing_entity.models
{
    internal class HeaderBlog
    {
        public int Id { get; set; }
        public int BlogId { get; set; }

        public Blog Blog { get; set; } = null!;
    }
}
