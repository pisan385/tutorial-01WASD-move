using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDiamond : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }


    public float speed;
    public float rotateSpeed;
    private Rigidbody2D rb2d;

    public Vector2 movement;

    // Update is called once per frame
    void Update()
    {

        // Change direction
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0,0,rotateSpeed);
            rb2d.AddForce(-transform.right * rotateSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(0,0,-1 * rotateSpeed);
            rb2d.AddForce(transform.right * rotateSpeed);
        }

        // Change Speed
        if (Input.GetKey(KeyCode.UpArrow)) {
            moveCharacter(transform.up);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            moveCharacter(-transform.up);
        }
        
    }

    void moveCharacter(Vector3 direction) {
        rb2d.AddForce(direction * speed);
    }
}
