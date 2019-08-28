using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move: MonoBehaviour
{
    public Vector3 initVel;
    public KeyCode leftKey;
    public KeyCode downKey;
    public KeyCode rightKey;

	public AudioSource bounceSound;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = initVel;
    }

    void Update()
    {
        Vector3 currentVel = this.GetComponent<Rigidbody2D>().velocity;

        if (Input.GetKey(leftKey))
        {
            currentVel.x -= 0.05f;
        }

        if (Input.GetKey(rightKey))
        {
            currentVel.x += 0.05f;
        }

        if (Input.GetKey(downKey))
        {
            if (currentVel.y < 0)
            {
                currentVel.y -= 0.5f;
            }
        }

        this.GetComponent<Rigidbody2D>().velocity = currentVel;
    }

	void OnCollisionEnter2D(Collision2D target) {
			bounceSound.Play();
	}
}
