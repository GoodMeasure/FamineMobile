using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedController : MonoBehaviour
{
    public int[] Adj;
    public Material[] Imgs;
    public int[] CharSeed;
    public string[] PicPaths;

	// Use this for initialization
	void Start ()
    {
        Adj = new int[6];
        
        Adj[0] = 2;
        Adj[1] = 2;
        Adj[2] = 1;
        Adj[3] = 2;
        Adj[4] = 3;
        Adj[5] = 1;

        CharSeed = new int[10];
        CharSeed[0] = (int) Random.Range(0f, 9999f) % 6;

        //Component image = GetComponent<RawImage>();
        // = Imgs[CharSeed[0]];

        for(int i = 1; i <= 6; i++)
        {
            CharSeed[i] = ((int)(Random.Range(0f, 9999f) % 3) + Adj[CharSeed[0] % 6]);
        }

        for(int j = 7; j <= 9; j++)
        {
            CharSeed[j] = (int) Random.Range(20f, 80f);
        }

        foreach (int n in CharSeed)
        {
            Debug.Log(n);
        }
	}
    private void Update()
    {
        var img = this.GetComponent<RawImage>();
        img.material = Imgs[CharSeed[0]];
    }
}
