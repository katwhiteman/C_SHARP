﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck() //Constructor to assign value to an object upon creation. Name is same as class
        {
            
            Cards = new List<Card>();
           
            for (int i=0; i < 13; i++)
            {
                for (int j = 0; j< 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }                   
            }
        }
        public List<Card> Cards { get; set; }

        //class method - for shuffling the deck.
        public void Shuffle(int times = 1) //Method for shuffling the deck multi times w/o overload method
            {
                for (int i = 0; i < times; i++)
                {
                    List<Card> TempList = new List<Card>();
                    Random random = new Random();

                    while (Cards.Count > 0)
                    {
                        int randomIndex = random.Next(0, Cards.Count);
                        TempList.Add(Cards[randomIndex]);
                        Cards.RemoveAt(randomIndex);
                    }
                    this.Cards = TempList;
                }
            }
        }        
    }