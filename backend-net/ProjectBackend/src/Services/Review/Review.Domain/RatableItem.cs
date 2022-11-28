using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Domain
{
    public class RatableItem
    {
        public int Id { get; set; }
        public List<Review> Reviews { get; set; }
       
    }
}
