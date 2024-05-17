using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studing_entity.models
{
    internal class Post
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public int BlogId { get; set; }

        public Blog Blog { get; set; } = null! //refrencee navigation
        ;
    }
}
