using UnityEngine;

public class PlayerRight : Player
{
	// Update is called once per frame
	new void Update ()
    {
        base.Update();
        body.velocity = new Vector2(Input.GetAxis("RHorizontal") * moveSpeed, Input.GetAxis("RVertical") * moveSpeed);
        if (Input.GetButtonDown("RPing") && canPing)
        {
            StartCoroutine(SendPing(transform));
        }
    }
}
