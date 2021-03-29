using SimpleInjector;
using SimpleInjector.Diagnostics;
using System;
using System.Windows.Forms;
using Trades.Services;
using Trades.Services.Interfaces;

namespace Trades
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = Configure();

            Application.Run(container.GetInstance<Form1>());            
        }

        private static Container Configure()
        {
            var container = new Container();

            ConfigureServices(container);
            AutoRegisterWindowsForms(container);
            container.Verify();

            return container;
        }

        private static void ConfigureServices(Container container)
        {
            container.Register<ITradeService, TradeService>();
        }

        private static void AutoRegisterWindowsForms(Container container)
        {
            var types = container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration =
                    Lifestyle.Transient.CreateRegistration(type, container);

                registration.SuppressDiagnosticWarning(
                    DiagnosticType.DisposableTransientComponent,
                    "Forms should be disposed by app code; not by the container.");

                container.AddRegistration(type, registration);
            }
        }
    }
}
