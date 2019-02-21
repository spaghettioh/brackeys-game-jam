﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlueGoal : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject bluePlayer;

	// Use this for initialization
	void Start()
    {
        text.text = "";
	}
	
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == bluePlayer)
        {
            text.text = "Blue is in!";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.text = "";
    }
}
