using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trades.Model.Interfaces;

namespace Trades.Services.Interfaces
{
    public interface ITradeService
    {
        string GetCategory(ITrade trade);
    }
}
