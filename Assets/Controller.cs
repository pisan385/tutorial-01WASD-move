using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// For Scene Management
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    public static Controller Instance;
    private static System.Random rand = new System.Random();
    private int numberOfScenes;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        numberOfScenes = SceneManager.sceneCountInBuildSettings;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N)) {
            int randomScene = rand.Next(numberOfScenes);
            Debug.Log("Switching to scene: " + randomScene);
            SceneManager.LoadScene(randomScene);
        }

        if (Input.GetKey(KeyCode.Escape)) {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
            Application.Quit();
        }
    }
}
