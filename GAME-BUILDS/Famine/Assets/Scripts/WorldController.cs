using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public int longitude;
    public int latitude;

    public void exitTile(int deltaLong, int deltaLat)
    {
        longitude += deltaLong;
        latitude += deltaLat;
        newTile();
    }

    public void newTile()
    {

    }
}
