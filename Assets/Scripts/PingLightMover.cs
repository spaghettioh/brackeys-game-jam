using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingLightMover : MonoBehaviour {
    public float timing = 2;

	// Use this for initialization
	void Start () {
        StartCoroutine(Kill());
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = transform.localPosition;

        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
    }

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(timing);
        Destroy(gameObject);
    }
}
