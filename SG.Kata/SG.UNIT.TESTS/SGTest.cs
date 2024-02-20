using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using SG.Application;
using SG.REPOSITORY;
using SG.REPOSITORY.Parameter;
using SG.ENTITY;
using SG.UNIT.TESTS.Models;
using System;
using System.Linq;

namespace SG.UNIT.TESTS
{
    [TestFixture]
    public class SGT
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }


        [SetUp]
        public void Setup()
        {
            SGConfiguration.ConnectingString = "Server=[XXXX]\\SQLEXPRESS;Database=SG;Integrated Security=True;";
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        [Test]
        public void Test_Has_Some_Recipes()
        {
            var recipeProvider = ServiceProvider.GetRequiredService<IRecipeService>();
            var recipes = recipeProvider.GetAll();
            Assert.That(recipes.Any(), Is.True);
        }

        [Test]
        public void Test_Has_Some_Ingredients()
        {
            var ingredientProvider = ServiceProvider.GetRequiredService<IIngredientService>();
            var ingredients = ingredientProvider.GetAll();
            Assert.That(ingredients.Any(), Is.True);
        }

        [Test]
        public void Test_Can_Add_Recipe()
        {
            bool can_Add_Recipe = false;
            var recipeProvider = ServiceProvider.GetRequiredService<IRecipeService>();
            var recipe = new RecipeDto { Name = "Malongo" };
            try
            {
                recipeProvider.Add(new Recipe { Name = recipe.Name });
                can_Add_Recipe = true;
            }
            catch (Exception ex)
            {
            }

            Assert.IsTrue(can_Add_Recipe);
        }


        [Test]
        public void Test_Can_Add_Ingredient()
        {
            bool can_Add_Ingredient = false;

            var ingredientProvider = ServiceProvider.GetRequiredService<IIngredientService>();
            var ingredient = new IngredientDto { Name = "Malongo" };
            try
            {
                ingredientProvider.Add(new Ingredient { Name = ingredient.Name });
                can_Add_Ingredient = true;
            }
            catch (Exception ex)
            {
            }

            Assert.IsTrue(can_Add_Ingredient);
        }

        [Test]
        public void Test_Recipe_Has_Ingredients()
        {
            var recipeId = "05f106ee-028e-4d37-bd7a-5c96e149a854";

            var recipeProvider = ServiceProvider.GetRequiredService<IRecipeService>();

            var recipe = recipeProvider.GetAll().FirstOrDefault(x => x.Id == recipeId);

            Assert.IsNotNull(recipe);
            Assert.That(recipe.Ingredients.Any());
        }

        private void ConfigureServices(IServiceCollection services)
        {
            IServices(services);
            services.AddDbContext<SGDbContext>(options =>
            {
                var connectionString = SGConfiguration.ConnectingString;
                options.UseSqlServer(connectionString);
            });
        }

        private void IServices(IServiceCollection services)
        {
            Application.DI.DependancyInjection.IServices(services);
        }
    }
}