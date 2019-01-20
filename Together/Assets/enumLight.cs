using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enumLight : MonoBehaviour
{
    public float speed = 1;
    public Color startColor;
    public Color endColor;
    float startTime;
    // Start is called before the first frame update
    
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        float t = (Time.time - startTime) * speed;
        GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        //Debug.Log(Color.Lerp(startColor, endColor, t));
        //Debug.Log(hit.transform.name);
        
        //hitByray();
    }
    void hitByray()
    {
        Debug.Log("I was hit");
    }
}
