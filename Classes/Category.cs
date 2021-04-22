using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Category
    {
        private string CategoryID { get; set; }
        private string Name { get; set; }
        private List<Card> CardsList { get; set; }
    }
}
