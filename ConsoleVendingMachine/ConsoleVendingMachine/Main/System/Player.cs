using System;
using System.Collections.Generic;

public class Player
{
    private static Player instance = null;
    public static Player Get
    {
        get
        {
            if (instance == null) instance = new Player();
            return instance;
        }
    }

    public int money = 10000;
    public List<string> inv = new List<string>();
    public Dictionary<string, int> beverage = new Dictionary<string, int>
    {
        {"Coke",1000 },
        {"OrangeJuice", 1500 },
        {"Coffee",2000 },
        {"Monster",3000 }
    };

}

