using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public int longitude;
    public int latitude;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void exitTile(int deltaLong, int deltaLat)
    {
        longitude += deltaLong;
        latitude += deltaLat;
    }
}
