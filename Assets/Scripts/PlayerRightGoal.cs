using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerRightGoal : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject orangePlayer;

    // Use this for initialization
    void Start()
    {
        text.text = "";
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == orangePlayer)
        {
            text.text = "Orange is in!";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.text = "";
    }
}
