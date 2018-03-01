using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using FSWeb.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FSWeb.Data.DAL
{
    public static class DbInitializer
    {
        private static int FindCount = 0; 

        public static void Initialize(FSContext context)
        {
            context.Database.Migrate();

            if (context.Categories.Any())
                return; 

            FindCount = 0; 
            Category mushrooms = new Category() { Name = DbInitializerStrings.CategoryNameMushrooms };
            context.Add(mushrooms);
            // Chantrelle 
            Item chantrelle = new Item() { Name = DbInitializerStrings.ItemNameChantrelle, CategoryId = mushrooms.Id };
            context.Add(chantrelle);
            AddFind(context, DbInitializerStrings.FindNameChantrelle1, chantrelle.Id);
            AddFind(context, DbInitializerStrings.FindNameChantrelle2, chantrelle.Id);

            // Black Trumpet
            Item blackTrumpet = new Item() { Name = DbInitializerStrings.ItemNameBlackTrumpet, CategoryId = mushrooms.Id };
            context.Add(blackTrumpet);
            AddFind(context, DbInitializerStrings.FindNameBlackTrumpet1, blackTrumpet.Id);
            AddFind(context, DbInitializerStrings.FindNameBlackTrumpet2, blackTrumpet.Id);

            // Chicken of the wood
            Item chickenOfTheWood = new Item() { Name = DbInitializerStrings.ItemNameChickenOfTheWood, CategoryId = mushrooms.Id };
            context.Add(chickenOfTheWood);
            AddFind(context, DbInitializerStrings.FindNameChickenOfTheWood1, chickenOfTheWood.Id);
            AddFind(context, DbInitializerStrings.FindNameChickenOfTheWood2, chickenOfTheWood.Id);

            // Hen of the wood
            Item henOfTheWood = new Item() { Name = DbInitializerStrings.ItemNameHenOfTheWood, CategoryId = mushrooms.Id };
            context.Add(henOfTheWood);
            AddFind(context, DbInitializerStrings.FindNameHenOfTheWood1, henOfTheWood.Id);


            // Wildflowers
            Category wildFlowers = new Category() { Name = DbInitializerStrings.CategoryNameWildflowers };
            context.Add(wildFlowers);

            // Trillium
            Item trillium = new Item() { Name = DbInitializerStrings.ItemNameTrillium, CategoryId = wildFlowers.Id };
            context.Add(trillium);
            AddFind(context, DbInitializerStrings.FindNameTrillium1, trillium.Id);
            AddFind(context, DbInitializerStrings.FindNameTrillium2, trillium.Id);

            // LadySlipper
            Item ladySlipper = new Item() { Name = DbInitializerStrings.ItemNameLadySlipper, CategoryId = wildFlowers.Id };
            context.Add(ladySlipper);
            AddFind(context, DbInitializerStrings.FindNameLadySlipper1, ladySlipper.Id);
            AddFind(context, DbInitializerStrings.FindNameLadySlipper2, ladySlipper.Id);


            // Edibles 
            Category edibles = new Category() { Name = DbInitializerStrings.CategoryNameEdibles };
            context.Add(edibles);

            // Leek
            Item leek = new Item() { Name = DbInitializerStrings.ItemNameLeek, CategoryId = edibles.Id };
            context.Add(leek);
            AddFind(context, DbInitializerStrings.FindNameLeek1, leek.Id);
            AddFind(context, DbInitializerStrings.FindNameLeek2, leek.Id);

            context.SaveChanges();

        }

        static void AddFind(FSContext context, String name, int itemId)
        {
            FindCount++;
            DateTime date = DateTime.Now.AddMonths(-1 * (FindCount));
            context.Finds.Add(new Find() { Name = name, ItemId = itemId, Date = date });

        }
    }
}
