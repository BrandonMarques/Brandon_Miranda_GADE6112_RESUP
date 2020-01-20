using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum WizardType
    {
    WIZARD
}
class MagesBuilding : Building

{
    private WizardType type; //using an int or string is also fine
    private int productionSpeed;
    private int spawnY;
    private int spawnCost;
    private int lastProducedRound = 0;

    public MagesBuilding(int x, int y, string faction, int mapHeight) : base(x, y, 100, faction, '~')
    {
        if (y >= mapHeight - 1)
        {
            spawnY = y - 1;
        }
        else
        {
            spawnY = y + 1;
        }
        type = (WizardType)Random.Range(0, 0);
        productionSpeed = Random.Range(3, 7);
        spawnCost = Random.Range(15, 25);
    }

    public MagesBuilding(string values)
    {
        string[] parameters = values.Split(',');

        x = int.Parse(parameters[1]);
        y = int.Parse(parameters[2]);
        health = int.Parse(parameters[3]);
        maxHealth = int.Parse(parameters[4]);
        type = (WizardType)int.Parse(parameters[5]);
        productionSpeed = int.Parse(parameters[6]);
        spawnY = int.Parse(parameters[7]);
        faction = parameters[8];
        symbol = parameters[9][0];
        isDestroyed = parameters[10] == "True" ? true : false;
    }

    public int ProductionSpeed
    {
        get { return productionSpeed; }
    }

    public int SpawnCost
    {
        get { return spawnCost; }
    }

    public bool CanProduce(int round)
    {
        int roundsSinceProduced = round - lastProducedRound;
        return roundsSinceProduced >= productionSpeed;
    }

    public override void Destroy()
    {
        isDestroyed = true;
        symbol = '_';
    }
}
