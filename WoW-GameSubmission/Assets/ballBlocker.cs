using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBlocker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;

        Debug.Log("Collision");

        if (gameObject.tag == "blue")
        {
            Physics2D.IgnoreCollision(collisionObject.GetComponent<Collider2D>(), this.GetComponent<Collider2D>());
        }
    }
}
