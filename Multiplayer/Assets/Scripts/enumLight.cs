using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enumLight : MonoBehaviour
{
    public float speed = 1;
    public Color startColor;
    public Color endColor;
    float startTime;
    bool isfading;
    // Start is called before the first frame update
    Renderer rend;
    public Color invisible = Color.white;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        invisible.a = 0.0f;
        rend.material.color = invisible;
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Color.Lerp(startColor, endColor, t));
        //Debug.Log(hit.transform.name);
        if (isfading)
        {
            HitByray();
        }
    }
    public void HitByray()
    {
        Debug.Log("I was hit");
        //RaycastHit hit;
        float t = (Time.time - startTime) * speed;
        GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
    }

    public void startLerp()
    {
        if (isfading == false)
        {
            isfading = true;
            startTime = Time.time;
        }
    }
}
