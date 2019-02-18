using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeftPing : MonoBehaviour {
    public UnityEvent pingOn;
    public UnityEvent pingOff;
    public bool canPing = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("LeftPing") && canPing)
        {
            canPing = false; 
            pingOn.Invoke();
            StartCoroutine(DisableLight());
        }
    }

    private IEnumerator DisableLight()
    {
        yield return new WaitForSeconds(1);
        pingOff.Invoke();
        canPing = true;
    }
}
