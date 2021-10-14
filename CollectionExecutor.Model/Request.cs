using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExecutor.Model
{
    public  class Request
    {
        public int RequestId { get; set; }
        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; }
    }
}
