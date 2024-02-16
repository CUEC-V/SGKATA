using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using SG.DEPOT.Parametre;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SG.DEPOT.DI
{
    public class DenpendancyInjection
    {
        public static void IServices(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IRecetteDepot), typeof(RecetteDepot));
            services.AddTransient(typeof(IIngredientDepot), typeof(IngredientDepot));

            services.AddDbContext<SGDbContext>(options => options.UseSqlServer(SGConfiguration.ConnectingString));
        }
    }
}
