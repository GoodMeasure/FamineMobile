using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string filePath;

    string GenInfo;
    string StatInfo;
    string CurrencyInfo;

    string ActionsInfo;
    string AbilityInfo;

    string EqpInfo;
    string InvInfo;

    string WorldInfo;
    string LineageInfo;

	// Use this for initialization
	void Start ()
    {
        List<string> lines = File.ReadAllLines(filePath).ToList();

        GenInfo = lines[0];
        StatInfo = lines[1];
        CurrencyInfo = lines[2];

        ActionsInfo = lines[3];
        AbilityInfo = lines[4];

        EqpInfo = lines[5];
        InvInfo = lines[6];

        WorldInfo = lines[7];
        LineageInfo = lines[8];
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void takeTurn()
    {
       // GameObject slots = GameObject.Find <'ActionsUI'> ();
       // slots.GetComponent < "ActionsController" > ().newTurn();
    }
}
