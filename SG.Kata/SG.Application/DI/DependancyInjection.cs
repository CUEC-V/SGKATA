using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SG.Application.DI
{
    public class DependancyInjection
    {
        public static void IServices(IServiceCollection services)
        {
            services.AddTransient(typeof(IRecetteService), typeof(RecetteService));
            services.AddTransient(typeof(IIngredientService), typeof(IngredientService));

            DEPOT.DI.DenpendancyInjection.IServices(services);
        }
    }
}
