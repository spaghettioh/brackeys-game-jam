using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float moveSpeed;
     
    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        body.velocity = new Vector2(Input.GetAxis("RightHorizontal") * moveSpeed, Input.GetAxis("RightVertical") * moveSpeed * -1); 
    }
}
