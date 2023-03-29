using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour

{
    public Rigidbody2D pb2d;
    public bool playerIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {

    }
    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        Vector3 rb2d = transform.position;
        if (Input.GetKey(KeyCode.W) && (playerIsAlive == true))
        {
            rb2d.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) && (playerIsAlive == true))
        {
            rb2d.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && (playerIsAlive == true))
        {
            rb2d.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) && (playerIsAlive == true))
        {
            rb2d.x -= speed * Time.deltaTime;
        }


        transform.position = rb2d;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player dead");
        playerIsAlive = false;

    }
}
