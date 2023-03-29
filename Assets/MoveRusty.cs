using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRusty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 10f;
    public float sizeSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;

        // Size
        Vector3 size = transform.localScale;

        if (Input.GetKey(KeyCode.RightArrow)) {
            size.x += sizeSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            size.x -= sizeSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            size.y += sizeSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            size.y -= sizeSpeed * Time.deltaTime;
        }

        transform.localScale = size;
    }
}
