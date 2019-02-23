using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5;
    public Rigidbody2D body;
    public bool canPing = true;
    public GameObject pingLight;
    public ParticleSystem pingEffect;
    AudioSource pingSound;

    // Use this for initialization
    void Start ()
    {
        pingSound = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	protected virtual void Update ()
    {

    }

    public IEnumerator SendPing(Transform t)
    {
        canPing = false;
        pingEffect.Play();
        pingSound.Play();
        GameObject pingLightClone = (GameObject)Instantiate(pingLight, t.position, t.rotation);

        yield return new WaitForSeconds(3);
        pingEffect.Stop();
        canPing = true;
    }
}
