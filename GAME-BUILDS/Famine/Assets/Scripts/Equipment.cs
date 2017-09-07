using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Equipment : Item
{
    public string slot;
    public Dictionary<string, int> stats;
    public int weight;
    public int levelReq;
}
