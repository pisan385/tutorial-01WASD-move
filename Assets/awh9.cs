using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awh9 : MonoBehaviour {
    // Start is called before the first frame update
    private bool rotating = false;
    public float rotSpeed;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            rotating = !rotating;
        }
        if (rotating)
            transform.Rotate(Vector3.forward * -rotSpeed * Time.deltaTime);
    }
}
