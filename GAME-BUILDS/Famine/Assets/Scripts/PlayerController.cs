using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Player
{
    int[] GridPosition;
    GameObject HexA;
    GameObject HexB;
    public string currentHexName;
    public bool activeUI;
    public int actions = 2;

    //GameObject world;
    Component worldScript;
    public int longitude;
    public int latitude;

    void Start()
    {
        //world = GameObject.Find("WorldController");
        GridPosition = new int[2] {0, 0};
    }

    void takeActions()
    {
        toggleActionUI();

    }

    void toggleActionUI()
    {
        
    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GridPositionAlter(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GridPositionAlter(0, 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GridPositionAlter(1, 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GridPositionAlter(-1, -1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))  
        {
            GridPositionAlter(0,-1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            GridPositionAlter(1, 0);
        }
    }
    public void GridPositionAlter(int x, int y)
    {
        int xVal = GridPosition[0];
        int yVal = GridPosition[1];
        int nextXVal = GridPosition[0] + x;
        int nextYVal = GridPosition[1] + y;

        if (nextXVal == -6) // mid-left side
        {
            if (nextYVal > -3)
                ExitTile(1, xVal, yVal);
            if (nextYVal < -3)
                ExitTile(4, xVal, yVal);
            else
            {
                if (yVal == -2)
                    ExitTile(1, xVal, yVal);
                else
                    ExitTile(4, xVal, yVal);
            }
        }

        else if (nextXVal == 6) // mid-right side
        {
            if (nextYVal > 3)
                ExitTile(3, xVal, yVal);
            if (nextYVal < 3)
                ExitTile(6, xVal, yVal);
            else
            {
                if (yVal == 3)
                    ExitTile(3, xVal, yVal);
                else
                    ExitTile(6, xVal, yVal);
            }
        }

        else if (nextYVal == -6) // bot-left side
        {
            if (nextXVal < -3)
                ExitTile(4, xVal, yVal);
            if (nextXVal > -3)
                ExitTile(5, xVal, yVal);
            else
            {
                if (xVal == -3)
                    ExitTile(4, xVal, yVal);
                else
                    ExitTile(5, xVal, yVal);
            }
        }

        else if (nextYVal == 6) // top-right side
        {
            if (nextXVal < 3)
                ExitTile(2, xVal, yVal);
            if (nextXVal > 3)
                ExitTile(3, xVal, yVal);
            else
            {
                if (xVal == -3)
                    ExitTile(2, xVal, yVal);
                else
                    ExitTile(3, xVal, yVal);
            }
        }

        else if (Mathf.Abs(nextXVal) + Mathf.Abs(nextYVal) == 6 && (nextXVal > 0 || nextYVal > 0) && (nextXVal < 0 || nextYVal < 0)) // top-left and bot ride sides
        {
            if(nextXVal <= 0 && nextYVal >= 0) // top-left side
            {
                if (nextXVal < -3)
                    ExitTile(1, xVal, yVal);
                if (nextXVal > -3)
                    ExitTile(2, xVal, yVal);
                else
                {
                    if (xVal == -3)
                        ExitTile(1, xVal, yVal);
                    else
                        ExitTile(2, xVal, yVal);
                }
            }
            else                               // bot-right side
            {
                if (nextXVal < 3)
                    ExitTile(5, xVal, yVal);
                if (nextXVal > 3)
                    ExitTile(6, xVal, yVal);
                else
                {
                    if (xVal == 2)
                        ExitTile(5, xVal, yVal);
                    else
                        ExitTile(6, xVal, yVal);
                }
            }
        }

        //if

        else
        {
            string xCoord = GridPosition[0].ToString();
            string yCoord = GridPosition[1].ToString();
            currentHexName = "(" + xCoord + "," + yCoord + ")";
            HexA = GameObject.Find(currentHexName);
            Debug.Log("Pre Hex: " + HexA.name);

            xCoord = (GridPosition[0] + x).ToString();
            yCoord = (GridPosition[1] + y).ToString();
            string nextHexName = "(" + xCoord + "," + yCoord + ")";
            HexB = GameObject.Find(nextHexName);
            Debug.Log("Post Hex: " + HexB.name);

            // if able to be moved to:
            transform.position = Vector3.Lerp(HexA.transform.position, HexB.transform.position, 1);
            GridPosition[0] = GridPosition[0] + x;
            GridPosition[1] = GridPosition[1] + y;
        }
    }
    public void ExitTile(int direction, int lastX, int lastY)
    {   
        lastX *= -1;
        lastY *= -1;
        string x = lastX.ToString();
        string y = lastY.ToString();

        changeLongLat(direction);
        string destHexName = "(" + x + "," + y + ")";
        GameObject destHex = GameObject.Find(destHexName);
        transform.position = Vector3.Lerp(HexA.transform.position, destHex.transform.position, 1);

        Debug.Log("Pre Hex: " + HexA.name);
        Debug.Log("Post Hex: " + destHex.name);

        GridPosition[0] = lastX;
        GridPosition[1] = lastY;
    }

    public void changeLongLat(int dir)
    {
        switch(dir)
        {
            case 1:
                longitude += -1;
                break;
            case 2:
                latitude += 1;
                break;
            case 3:
                longitude += 1;
                latitude += 1;
                break;
            case 4:
                longitude += -1;
                latitude += -1;
                break;
            case 5:
                latitude += -1;
                break;
            case 6:
                longitude += 1;
                break;
        }
    }

    public void spawnNextTile()
    {

    }


}
