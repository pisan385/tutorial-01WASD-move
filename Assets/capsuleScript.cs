using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float speed = 20f;
    public int minLifetime = 120;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;

        minLifetime -= 1;
        /*
        if(minLifetime < -1000) //this is lazy af
        {
            Debug.Log("Deleting capsule.");
            Destroy(gameObject);
        }*/
    }

    void OnBecameInvisible()
    {
        if(minLifetime < 0)
        {
            Debug.Log("Deleting capsule.");
            Destroy(gameObject);
        }
    }
}
