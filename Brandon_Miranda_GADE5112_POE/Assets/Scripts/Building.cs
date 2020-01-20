﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Building : Target
{
    protected char symbol;

    public Building(int x, int y, int health, string faction, char symbol)
    {
        this.x = x;
        this.y = y;
        this.health = health;
        this.maxHealth = health;
        this.faction = faction;
        this.symbol = symbol;
    }

    public Building() { }

    public char Symbol
    {
        get { return symbol; }
    }

    public override void Destroy()
    {
        isDestroyed = true;
        symbol = 'X';
    }

    //public abstract string Save();

    //public override string ToString()
    //{
    //    return
    //        "Faction: " + faction + Environment.NewLine +
    //        "Position: " + x + ", " + y + Environment.NewLine +
    //        "Health: " + health + " / " + maxHealth + Environment.NewLine;
    //}
}

