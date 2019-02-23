using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour {
    public GameObject playerLeft;
    public GameObject playerRight;
    public float strengthOfAttraction;
    public float radius;

    public GameObject label;
    public TextMeshProUGUI leftText;
    public string leftMessage;
    public TextMeshProUGUI rightText;
    public string rightMessage;
    public TextMeshProUGUI winText;
    public string winMessage;
    public RawImage scrim;


    bool left = false;
    bool right = false;



    //private Rigidbody2D rigid;
    //[SerializeField]
    //Transform planet;

    //[SerializeField]
    //float acceleration = 0.81f;


    // Use this for initialization
    void Start () {
        Destroy(label);
        //leftText.text = "";
        //rightText.text = "";
        winText.text = "";
        //rigid = GetComponent<Rigidbody2D>();

        // this is a fix for crossfade
        Color fixedColor = scrim.color;
        fixedColor.a = 1;
        scrim.color = fixedColor;
        scrim.CrossFadeAlpha(0f, 0f, true);
    }

    // Update is called once per frame
    void Update ()
    {
        GravityWell(playerLeft.GetComponent<Rigidbody2D>());
        GravityWell(playerRight.GetComponent<Rigidbody2D>());

        //if (left)
        //    leftText.text = leftMessage;

        //if (right)
        //rightText.text = rightMessage;


        if (left && right)
        {
            scrim.CrossFadeAlpha(.7f, 1, false);
            //Destroy(playerLeft);
            //Destroy(playerRight);
            playerLeft.transform.localPosition = transform.localPosition;
            playerRight.transform.localPosition = transform.localPosition;
            winText.text = winMessage;
            StartCoroutine(LoadNextLevel());
        }
    }

    private void GravityWell(Rigidbody2D p)
    {
        Vector3 offset = p.transform.position - transform.position;

        //we're doing 2d physics, so don't want to try and apply z forces!
        offset.z = 0;

        if (offset.x < radius && offset.y < radius)
        {
            p.AddForce(strengthOfAttraction * offset.normalized, ForceMode2D.Force);
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
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
