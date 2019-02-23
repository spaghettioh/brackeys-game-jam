using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
    public GameObject label;
    public TextMeshProUGUI leftText;
    public string leftMessage;
    public TextMeshProUGUI rightText;
    public string rightMessage;
    public TextMeshProUGUI winText;
    public string winMessage;


    bool left = false;
    bool right = false;

	// Use this for initialization
	void Start () {
        Destroy(label);
        leftText.text = "";
        rightText.text = "";
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        if (left)
            leftText.text = leftMessage;

        if (right)
            rightText.text = rightMessage;

        if (left && right)
        {
            winText.text = winMessage;
            StartCoroutine(LoadNextLevel());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerLeft")
        {
            left = true;
        }

        if (collision.gameObject.name == "PlayerRight")
        {
            right = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerLeft")
        {
            left = false;
        }

        if (collision.gameObject.name == "PlayerRight")
        {
            right = false;
        }
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
