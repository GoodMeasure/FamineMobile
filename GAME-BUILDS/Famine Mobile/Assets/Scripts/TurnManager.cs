using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public GameObject player;
    public bool playerTurn;
    GameObject[] Creatures;

    private void Start()
    {
        Creatures = new GameObject[transform.childCount]; 
    }

    void beginBattle(bool ambushed)
    {
        if(ambushed)
        {
            EnemyTurn();
            playerTurn = true;
        }
        else
        {
            PlayerTurn();
            playerTurn = false;
        }
    }

    private void PlayerTurn()
    {
        player = GameObject.Find("Player");
        //player.takeTurn();
    }
    private void EnemyTurn()
    {
        foreach (GameObject c in Creatures)
        {
            if (c != player)
            {
                //c.takeTurn();
            }
        }
    }
    private void addCreature(GameObject newCreature)
    {
        for(int i = 0; i < Creatures.Length; i++)
        {
            if(!Creatures[i])
            {
                Creatures[i] = newCreature;
            }
            else
            {
                Debug.Log("Creature Array full.");
            }
        }
    }
}
