using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Debugger : MonoBehaviour
{
    public TextMeshProUGUI debug;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        debug.text = Screen.width.ToString() + "x" + Screen.height.ToString();
	}
}
