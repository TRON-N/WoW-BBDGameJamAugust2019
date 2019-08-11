using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    public Vector3 initVel;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = initVel;
    }

    void Update()
    {
        Vector3 currentVel = this.GetComponent<Rigidbody2D>().velocity;

        if (Input.GetKey(KeyCode.A))
        {
            currentVel.x -= 0.05f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            currentVel.x += 0.05f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (currentVel.y < 0)
            {
                currentVel.y -= 0.5f;
            }
        }

        this.GetComponent<Rigidbody2D>().velocity = currentVel;
    }
}
