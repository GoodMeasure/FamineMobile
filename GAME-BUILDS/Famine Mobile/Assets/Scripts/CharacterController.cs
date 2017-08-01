using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public string Name;
    public string Family;
    public int Level;
    public string Race;
    public bool Sex;

    public int xPos;
    public int yPos;

    public int Health;
    public int Resource;
    public string ResourceName;

    public Action[] Actions;

    public int Vigor;
    public int Faith;
    public int Intellect;
    public int Dexterity;
    public int Strength;
    public int Wisdom;

    public float Fame;
    public float Divinity;
    public float Renown;

    public int GoldPieces;
    public int SilverPieces;
    public int CopperPieces;

    public GameObject[] Effects;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void UseAbility(int num)
    {
        Actions[num].Execute();
    }
}
