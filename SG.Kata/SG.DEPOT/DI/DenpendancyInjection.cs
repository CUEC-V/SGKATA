using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using SG.REPOSITORY.Parameter;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SG.REPOSITORY.DI
{
    public class DenpendancyInjection
    {
        public static void IServices(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IRecipeRepository), typeof(RecipeRepository));
            services.AddTransient(typeof(IIngredientRepository), typeof(IngredientRepository));

            services.AddDbContext<SGDbContext>(options => options.UseSqlServer(SGConfiguration.ConnectingString));
        }
    }
}
