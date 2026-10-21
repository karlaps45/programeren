using System;
using System.Collections.Generic;
using System.Diagnostics;
class Speler
{
    public string naam = "erwin";
    public int HP = 100;
    public int score = 3000;

    public void Vertel()
    {
        Console.WriteLine($"Ik ben {naam}, mijn HP is {HP} en mijn score is {score}.");
    }
}

class PROG_Les1
{
    static void Main(string[] args)
    {

        Speler[] spelers =
        {
            new Speler { naam = "Mario", HP = 10, score = 1000 },
            new Speler { naam = "Luigi", HP = 4, score = 500 },
            new Speler { naam = "Peach", HP = 8, score = 800 }
        };

        DrukSpelersAf(spelers);


        static void DrukSpelersAf(Speler[] spelers)
        {
            for (int i = 0; i < spelers.Length; i++)
            {
                spelers[i].Vertel();
            }
        }


        string naam = "erwin";
        int Score = 0;
        bool alive = true;

        Console.WriteLine(naam + " " + Score + " " + alive.ToString());
        Console.WriteLine("Result : " + Max(20, 40));
        Console.WriteLine("Result : " + Max(60, 30));
        Console.WriteLine("schade : " + BerekenSchade(1200, 200));
        int HP = 100;



        HP = HP - 35;
        Console.WriteLine("HP: " + HP);


        if (HP > 0)
        {
            Console.WriteLine("Speler leeft nog!");
        }
        else
        {
            Console.WriteLine("Speler is dood!");
        }

        //opdracht 2
        HP = HP - 80;
        Console.WriteLine("HP: " + HP);

        if (HP > 0)
        {
            Console.WriteLine("Speler leeft nog!");
        }
        else
        {
            Console.WriteLine("Speler is dood!");
        }


        //opdracht 3
        Console.WriteLine("welkom!" + naam);

        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int BerekenSchade(int aanval, int verdediging)
        {
            int schade = aanval - verdediging;

            if (schade < 0)
            {
                return 0;
            }
            else
            {
                return schade;
            }
        }

        string[] vijanden = { "Orc", "Knight", "Wizard", "Ogre", "Dragon" };

        for (int i = 0; i < vijanden.Length; i++)
        {
            Console.WriteLine(vijanden[i]);
        }


        List<string> vijandens = new List<string>();


        vijandens.Add("Orc");
        vijandens.Add("Knight");
        vijandens.Add("Wizard");
        vijandens.Add("Ogre");
        vijandens.Add("Dragon");


        vijandens.Remove("Ogre");


        foreach (string vijand in vijanden)
        {
            Console.WriteLine(vijand);
        }

        Console.WriteLine("Aantal vijanden: " + vijandens.Count);
    }




}