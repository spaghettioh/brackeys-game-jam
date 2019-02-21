using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingScaler : MonoBehaviour
{
    public float timing = 2;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(Kill());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = transform.localScale;

        scale.x += .1f;
        scale.y += .1f;

        transform.localScale = scale;
    }

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(timing);
        Destroy(gameObject);
    }
}
