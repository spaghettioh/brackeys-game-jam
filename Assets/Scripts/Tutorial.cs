using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

// This script is gross.
public class Tutorial : MonoBehaviour
{
    public TextMeshProUGUI hintText;
    public Image leftHintImg;
    public Image rightHintImg;

    readonly float hintTime = 2.0f;
    float startTime;
    float min;
    float max;

    IEnumerator Start()
    {
        // hide the hints
        if (hintText != null)
            hintText.alpha = 0;

        Color a = new Color(1, 1, 1, 0);
        if (leftHintImg != null)
            leftHintImg.color = a;

        if (rightHintImg != null)
            rightHintImg.color = a;

        // wait to show the text
        yield return new WaitForSeconds(hintTime);

        // trigger the fade in
        startTime = Time.time;
        min = 0;
        max = 1;

        // show the text for a bit
        yield return new WaitForSeconds(startTime + hintTime);

        // trigger the fade out
        startTime = Time.time;
        min = 1;
        max = 0;
    }

    void Update ()
    {
        float t = (Time.time - startTime) / hintTime;

        if (hintText != null)
            hintText.alpha = Mathf.SmoothStep(min, max, t);

        if (leftHintImg != null)
            leftHintImg.color = new Color(1, 1, 1, Mathf.SmoothStep(min, max, t));

        if (rightHintImg != null)
            rightHintImg.color = new Color(1, 1, 1, Mathf.SmoothStep(min, max, t));
    }
}
