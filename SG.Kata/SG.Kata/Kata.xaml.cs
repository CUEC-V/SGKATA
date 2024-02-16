using Microsoft.Extensions.DependencyInjection;
using SG.Application;
using SG.Kata.Models;
using SG.Kata.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SG.Kata
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Kata : Window
    {
        private IRecetteService _recetteService;
        public Kata()
        {
            InitializeComponent();
        }

        private void KTLoaded(object sender, RoutedEventArgs e)
        {
            _recetteService = App.ServiceProvider.GetRequiredService<IRecetteService>();

            var recettes = _recetteService.GetAll();

            if (recettes.Any())
            {
                RecetteLab.ItemsSource = recettes
                    .OrderBy(x => x.Nom)
                    .Select(x => new RecetteDto { Id = x.Id, Nom = $"o - {x.Nom}" })
                    .ToList();

                RecetteLab.DisplayMemberPath = "Nom";
                RecetteLab.SelectedValuePath = "Id";
            }
            else
            {
                RecetteLab.ItemsSource = new List<RecetteDto>();
            }

        }

        private void RecetteSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RecetteLab.SelectedIndex < 0)
            {
                return;
            }

            var recetteId = ((RecetteDto)RecetteLab.SelectedItem).Id;

            var recette = _recetteService.FindById(recetteId);
            if (recette == null)
            {
                return;
            }
            var somme = "";
            decimal prix = 0;

            if (recette.Ingredients.Any())
            {
                prix = recette.Ingredients.Sum(x => Convert.ToDecimal(x.Prix) * x.Dose);
                var tt = 1.3m * prix;
                somme = (tt).ToString();
            }
            else
            {
                return;
            }

            PrixVente.Text = $"Prix de vente : {somme} €\n _________________\n";

            var items = "";
            var order = 0;
            items += $"{recette.Nom}\n\n";
            foreach (var item in recette.Ingredients.OrderBy(x=>x.Nom))
            {
                ++order;
                items += $"{order} - {item.Nom} {item.Prix} € x {item.Dose}\n";
            }

            PrixVente.Text += items;
            PrixVente.Text += "\n\nNB : Prix de vente : prix coûtant des recettes + marge de 30% ";
        }
    }
}
