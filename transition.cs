using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transition : MonoBehaviour
{
    public GameObject Square;
    public GameObject NetID;
    public GameObject Video;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        Video.gameObject.SetActive(false);
        StartCoroutine("StartDelay");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 5f;
        while (Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0;
        }
        Square.gameObject.SetActive(false);
        NetID.gameObject.SetActive(false);
        Video.gameObject.SetActive(true);
        Time.timeScale = 1;
    }
}