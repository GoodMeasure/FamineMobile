using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public int[] gridPosition = new int[2];
    public int moveActions;
    public int auxAction;
    public string creatureName;
    public int currentHP;
    public int maxHP;
    public int baseATK;
    public int baseSwings;
    public int speed;
    public int range;
    public Item[] inv = new Item[100];
    public int count = 0;

    public Creature()
    {
        creatureName = "Creature" + count.ToString();
        currentHP = 100;
        maxHP = 100;
        baseATK = 25;
        baseSwings = 1;
        speed = 3;
        count++;
    }

    public Creature(string inName, int gridX, int gridY, int inHP, int inATK, int inSwings, int inSpeed)
    {
        creatureName = inName;
        gridPosition[0] = gridX;
        gridPosition[1] = gridY;
        currentHP = inHP;
        maxHP = inHP;
        baseATK = inATK;
        baseSwings = inSwings;
        speed = inSpeed;
    }

    public void Attack(Creature target)
    {
        target.currentHP -= baseATK;
    }
}
