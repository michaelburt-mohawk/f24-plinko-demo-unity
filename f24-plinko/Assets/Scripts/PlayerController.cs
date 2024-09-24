using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 movement = Vector3.zero;

        float displacement = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            movement.x -= displacement;

        if (Input.GetKey(KeyCode.D))
            movement.x += displacement;

        transform.position += movement;
    }
}
