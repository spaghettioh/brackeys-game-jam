using UnityEngine;

public class PlayerLeft : Player
{
	// Update is called once per frame
	new void Update ()
    {
        base.Update(); 
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, Input.GetAxis("Vertical") * moveSpeed);
        if (Input.GetButtonDown("LPing") && canPing)
        {
            StartCoroutine(SendPing(transform));
        }
    }
}
