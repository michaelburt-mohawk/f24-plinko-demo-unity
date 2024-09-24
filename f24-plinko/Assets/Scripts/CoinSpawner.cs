using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject coin;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            Instantiate(coin, position, rotation);
        }
    }
}
