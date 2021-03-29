using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trades.Model.Interfaces;

namespace Trades.Model
{
    public class Trade : ITrade
    {
        public double Value { get; set; }

        public string ClientSector { get; set; }
    }
}
