using AutoMapper;
using CableManager.Data;
using CableManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableManager
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mapper = ConfigureAutoMapper();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using(CableManagerDbContext db = new CableManagerDbContext())
            {
                var cableService = new CableService(db);
                var carreraService = new CarreraService(db);

                Application.Run(new MainPage(cableService, carreraService, mapper));
            }
        }

        private static IMapper ConfigureAutoMapper() 
        {
            var mapper = new MapperConfiguration(cfg => 
            { 
                cfg.AddMaps(Assembly.GetAssembly(typeof(Program))); 
            }).CreateMapper();

            return mapper;
        }
    }
}
