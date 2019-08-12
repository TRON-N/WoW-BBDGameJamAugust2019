using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBallController : MonoBehaviour
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
        Vector2 rbVelocity = rb.position;
        // setVelocity(rbVelocity);
        addForce();
        // addRelativeForce(rbVelocity);
    }

    void setVelocity(Vector2 rbVelocity)
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity = new Vector2 (-5f, rbVelocity.y);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rb.velocity = new Vector2 (5f, rbVelocity.y);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            rb.velocity = new Vector2 (rbVelocity.x, -5f);
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            rb.velocity = new Vector2 (rbVelocity.x, 5f);
        }
    }

    void addForce()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(new Vector2(-5f, 0));
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(new Vector2(5f, 0));
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            rb.AddForce(new Vector2(0, -15f));
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(new Vector2(0, 5f));
        }
    }

    void addRelativeForce(Vector2 rbVelocity)
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddRelativeForce(new Vector2(-5f, rbVelocity.y));
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddRelativeForce(new Vector2(5f, rbVelocity.y));
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            rb.AddRelativeForce(new Vector2(rbVelocity.x, -5f));
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddRelativeForce(new Vector2(rbVelocity.x, 5f));
        }
    }
}
