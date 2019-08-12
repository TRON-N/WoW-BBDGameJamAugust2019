using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBallController : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        addForce();
    }

    void addForce()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-5f, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(5f, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector2(0, -15f));
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, 5f));
        }
    }
    
}
