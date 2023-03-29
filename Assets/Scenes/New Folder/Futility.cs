using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// For Scene Management
using UnityEngine.SceneManagement;

public class Futility : MonoBehaviour
{
    // This place was supposed to trap you, then kick you out after 10 seconds and not let you back
    // but it was causing too much lag lol
    
    
    //public static Futility Instance;
    //public static bool active = true;
    //private static float delay = 10;
    private void Awake()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log(delay);
        if (active && SceneManager.GetActiveScene() != SceneManager.GetSceneByName("proxi@uw.edu")) {
            SceneManager.LoadScene("proxi@uw.edu");
            Debug.Log("Pulling back");
        }
        if (!active && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("proxi@uw.edu")) {
            SceneManager.LoadScene(0);
            Debug.Log("Kicking out");
        }
        if (active && delay > 0)
        {
            delay-=Time.deltaTime;
            if (delay < 0)
            {
                active = false;
            }
        }
        */
    }
}
