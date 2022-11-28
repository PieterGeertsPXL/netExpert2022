using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.Domain
{
    public class Beer
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        public string? Description { get; set; }

        public BeerType? Type { get; set; }
        public int BrewerId { get; set; }
        public Brewer? Brewer { get; set; }
    }
}
