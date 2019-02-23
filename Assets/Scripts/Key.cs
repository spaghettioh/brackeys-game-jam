using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject unlocks;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<SpriteRenderer>().maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
        unlocks.GetComponent<SpriteRenderer>().maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // disable the gate and add a flourish
        unlocks.GetComponent<Collider2D>().enabled = false;
        unlocks.GetComponent<SpriteRenderer>().enabled = false;
        unlocks.GetComponent<ParticleSystem>().Play();

        // disable the gate and add a flourish
        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<ParticleSystem>().Play();

        // cleanup the stuff soon
        StartCoroutine(CleanUp());
    }

    IEnumerator CleanUp()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject); 
        Destroy(unlocks);
    }
}
