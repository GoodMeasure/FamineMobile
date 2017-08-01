using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CharacterController character;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoveTwelve()
    {
        character.xPos = character.xPos + 1;
        character.yPos = character.yPos + 2;
    } 

    public void MoveOneThirty()
    {
        character.xPos = character.xPos + 1;
        character.yPos = character.yPos + 1;
    }

    public void MoveFourThirty()
    {
        character.xPos = character.xPos + 1;
        character.yPos = character.yPos - 1;
    }

    public void MoveSix()
    {
        character.xPos = character.xPos - 1;
        character.yPos = character.yPos -2 ;
    } 

    public void MoveSevenThirty()
    {
        character.xPos = character.xPos - 1;
        character.yPos = character.yPos - 1;
    }

    public void MoveTenThirty()
    {
        character.xPos = character.xPos - 1;
        character.yPos = character.yPos + 1;
    }

    public void AbilityOne(int num)
    {
        character.UseAbility(num);
    }
}
