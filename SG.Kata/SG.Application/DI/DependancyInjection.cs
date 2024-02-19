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
            services.AddTransient(typeof(IRecipeService), typeof(RecipeService));
            services.AddTransient(typeof(IIngredientService), typeof(IngredientService));
            services.AddLogging();

            DEPOT.DI.DenpendancyInjection.IServices(services);
        }
    }
}
