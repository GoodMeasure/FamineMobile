using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public AudioSource click;
    public string scene;

    // Use this for initialization
    public void LoadLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
