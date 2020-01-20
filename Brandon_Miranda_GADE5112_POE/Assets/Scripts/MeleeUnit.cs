using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class MeleeUnit : Unit
{
    public MeleeUnit(int x, int y, string faction) : base(x, y, 200, 1, 20, 1, faction, '#', "Swordsman") { }

    public MeleeUnit(string values) : base(values) { }

    //public override string Save()
    //{
    //    return string.Format(
    //        $"Melee,{x},{y},{health},{maxHealth},{speed},{attack},{attackRange}," +
    //        $"{faction},{symbol},{name},{isDestroyed}"
    //    );
    //}
}
