using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed;
    public Rigidbody2D myRigidBody;

    public float jumpSpeed;
    // Start is called before the first frame update
    void Start () {
        myRigidBody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetAxisRaw ("Horizontal") > 0f) {
            myRigidBody.velocity = new Vector3 (moveSpeed, myRigidBody.velocity.y, 0f);
        } else if (Input.GetAxisRaw ("Horizontal") < 0f) {
            myRigidBody.velocity = new Vector3 (-moveSpeed, myRigidBody.velocity.y, 0f);
        } else {
            myRigidBody.velocity = new Vector3 (0f, myRigidBody.velocity.y, 0f);
        }

        if (Input.GetButtonDown("Jump")) 
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, jumpSpeed, 0f);
        }
    }
}