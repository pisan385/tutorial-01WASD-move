using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircle4 : MonoBehaviour
{
    private float rotationSpeed = 2f;
    private float radius = 3f;

    public Transform Target;

    private float angle;

    private void Start()
    {

    }

    private void Update()
    {
        Vector3 pos = transform.position;
        Vector3 targetPos = Target.position;

        angle += rotationSpeed * Time.deltaTime;

        pos.x = targetPos.x - (Mathf.Sin(angle) * radius);

        pos.y = targetPos.y + (Mathf.Cos(angle) * radius);

        transform.position = pos;
    }
}