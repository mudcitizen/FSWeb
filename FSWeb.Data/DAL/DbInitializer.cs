using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using FSWeb.Data.Models;


namespace FSWeb.Data.DAL
{
    public static class DbInitializer
    {
        private static int FindCount = 0; 

        public static void Initialize(FSContext context)
        {
            FindCount = 0; 
            Category mushrooms = new Category() { Name = DbInitializerStrings.CategoryNameMushrooms };
            context.Add(mushrooms);

            Category wildFlowers = new Category() { Name = DbInitializerStrings.CategoryNameWildflowers };
            context.Add(wildFlowers);

            Item chantrelle = new Item() { Name = DbInitializerStrings.ItemNameChantrelle, CategoryId = mushrooms.Id };
            context.Add(chantrelle);
            Item blackTrumpet= new Item() { Name = DbInitializerStrings.ItemNameBlackTrumpet, CategoryId = mushrooms.Id };
            context.Add(blackTrumpet);
            Item trillium = new Item() { Name = DbInitializerStrings.ItemNameTrillium, CategoryId = wildFlowers.Id };
            context.Add(trillium);
            Item ladySlipper = new Item() { Name = DbInitializerStrings.ItemNameLadySlipper, CategoryId = wildFlowers.Id };
            context.Add(ladySlipper);

            // Chantrelle 
            AddFind(context, DbInitializerStrings.FindNameChantrelle1, chantrelle.Id);
            AddFind(context, DbInitializerStrings.FindNameChantrelle2, chantrelle.Id);


            // Black Trumpet
            AddFind(context, DbInitializerStrings.FindNameBlackTrumpet1, blackTrumpet.Id);
            AddFind(context, DbInitializerStrings.FindNameBlackTrumpet2, blackTrumpet.Id);

            // Trillium
            AddFind(context, DbInitializerStrings.FindNameTrillium1, trillium.Id);
            AddFind(context, DbInitializerStrings.FindNameTrillium2, trillium.Id);

            // LadySlipper
            AddFind(context, DbInitializerStrings.FindNameLadySlipper1, ladySlipper.Id);
            AddFind(context, DbInitializerStrings.FindNameLadySlipper2, ladySlipper.Id);

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
