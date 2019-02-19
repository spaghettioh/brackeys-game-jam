using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinText : MonoBehaviour
{
    public TextMeshProUGUI winText;
    public TextMeshProUGUI blueGoalText;
    public TextMeshProUGUI orangeGoalText;

    // Use this for initialization
    void Start ()
    {
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (orangeGoalText.text == "Orange is in!" && blueGoalText.text == "Blue is in!")
        {
            winText.text = "Nice!";
            StartCoroutine(LoadNextLevel());
        }
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
