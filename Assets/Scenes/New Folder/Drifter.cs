using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drifter : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rgbd;
    public int speed = 1;
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();    
    }
    
    // Update is called once per frame
    void Update()
    {
        int range = 14;
        if (transform.position.x < -range)
        {
            Vector3 pos = transform.position;
            pos += new Vector3(range*2, 0, 0);
            transform.position = pos;
        }
        if (transform.position.y < -range/2)
        {
            Vector3 pos = transform.position;
            pos += new Vector3(0, range, 0);
            transform.position = pos;
        }
        if (transform.position.y > range/2)
        {
            Vector3 pos = transform.position;
            pos += new Vector3(0, -range, 0);
            transform.position = pos;
        }
        
        rgbd.AddForce(new Vector2(-speed, 0));
    }
}
