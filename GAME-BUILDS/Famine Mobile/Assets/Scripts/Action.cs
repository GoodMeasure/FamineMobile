using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : MonoBehaviour
{
    public abstract void Execute();
    public bool Targeted;
    public bool Numeric;
    public bool isString;
    public GameObject pc;
    public void Start()
    {
        pc = GameObject.Find("PlayerCharacter");
    }

    public RangeCheck()
}
