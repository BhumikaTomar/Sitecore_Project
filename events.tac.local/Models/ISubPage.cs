using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events.tac.local.Models
{
    public interface ISubPage
    {
        string name { get; set; }
        int price { get; set; }
    }
}
