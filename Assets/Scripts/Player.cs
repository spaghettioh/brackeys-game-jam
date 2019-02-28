using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5;
    public Rigidbody2D body;
    protected bool canEcho = true;
    public GameObject echoEffect;
    public ParticleSystem echoParticle;
    public GameObject withEchoSprite;
    AudioSource echoSound;

    float scale;
    float startTime;
    readonly float echoWait = 3;

    // Use this for initialization
    void Start ()
    {
        echoSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    protected virtual void Update ()
    {
        if (!canEcho)
        {
            float t = (Time.time - startTime) / echoWait;
            scale = Mathf.SmoothStep(0, 1, t);
            withEchoSprite.transform.localScale = new Vector3(scale, scale, scale);
        }
    }

    public IEnumerator SendEcho(Transform p)
    {
        canEcho = false;
        // play the particle
        echoParticle.Play();
        // player the sound
        echoSound.Play();
        // spawn the echo effect
        GameObject echoLightClone = (GameObject)Instantiate(echoEffect, p.position, p.rotation);

        // reset the clock for charging the echo
        startTime = Time.time;
        scale = 0;

        yield return new WaitForSeconds(echoWait);
        echoParticle.Stop();
        canEcho = true;
    }
}
