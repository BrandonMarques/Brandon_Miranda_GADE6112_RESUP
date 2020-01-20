using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class WizardUnit : Unit
{
    public WizardUnit(int x, int y, string faction) : base(x, y, 100, 3, 10, 5, faction, '*', "Sorceress") { }

    public WizardUnit(string values) : base(values) { }

    //public override string Save()
    //{
    //    return string.Format(
    //        $"Wizard,{x},{y},{health},{maxHealth},{speed},{attack},{attackRange}," +
    //        $"{faction},{symbol},{name},{isDestroyed}"
    //    );
    //}
}

