using SimpleInjector;
using System;
using Trades.Services;
using Trades.Services.Interfaces;

namespace Trades.IoC
{
    public class ContainerBuilder
    {     
        public static Container Configure()
        {
            var container = new Container();
            
            ConfigureServices(container);        
            container.Verify();

            return container;
        }

        private static void ConfigureServices(Container container) {            
            container.Register<ITradeService, TradeService>();
        }

        
    }
}
