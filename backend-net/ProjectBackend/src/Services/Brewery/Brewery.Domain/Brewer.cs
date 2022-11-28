using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.Domain
{
    public class Brewer
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public List<Beer>? Beers { get; set; }
    }
}
