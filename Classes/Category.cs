﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Category
    {
        public string CategoryID { get; set; }
        public string Name { get; set; }
        public List<Card> CardsList { get; set; }

        private static Random random = new Random();

        public Category GetFilteredCategory(List<Card> i_CardHistory)
        {
            Category newCategory = new Category();
            newCategory.CategoryID = this.CategoryID;
            newCategory.Name = this.Name;
            newCategory.CardsList = GetFilterCards(i_CardHistory);

            return newCategory;
        }

        private List<Card> GetFilterCards(List<Card> i_CardHistory)
        {
            List<Card> filterCards = new List<Card>(5);
            for (int i = 0; i < 5 ; i++)
            {
                Boolean legal = true;
                while (legal)
                {
                    int times = 0;
                    int index = random.Next(CardsList.Count);
                    if (!filterCards.Contains(CardsList[index]) && i_CardHistory.Contains(CardsList[index]))
                    {
                        filterCards.Add(CardsList[index]);
                        legal = false;
                    }

                    times++;
                    if (times == 100)
                    {
                        throw (new Exception("We can't get filter cards"));
                    }
                }
            }

            return filterCards;
        }

        

    
    }
}
