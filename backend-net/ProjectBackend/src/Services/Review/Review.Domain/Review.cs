using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public Rating Rating { get; set; }
        public string Description { get; set; }
    }
}
