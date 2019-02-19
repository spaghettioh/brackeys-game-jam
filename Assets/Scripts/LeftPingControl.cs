﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeftPingControl : MonoBehaviour
{
    public GameObject pingLight;
    public bool canPing = true;
    public UnityEvent pingOn;
    public UnityEvent pingOff;

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
            GameObject pingLightClone = (GameObject)Instantiate(pingLight, transform.position, transform.rotation);
        }
    }

    private IEnumerator DisableLight()
    {
        yield return new WaitForSeconds(3);
        pingOff.Invoke();
        canPing = true;
    }
}
