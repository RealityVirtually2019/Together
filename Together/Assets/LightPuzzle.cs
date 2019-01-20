using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzle : MonoBehaviour
{
    public GameObject puzzle;
   // objectWithScript.GetComponent<ReferencedScript>();

        //setting color
    public Color color = Color.white;
    private Color red = Color.red;
    Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        //setting opacity of color
        color.a = 0f;
        rend.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        red.a = .1f;
        rend.material.color = red;
    }
    IEnumerator FadeIn()
    {
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            Color color = rend.material.color;
            color.a = f;
            rend.material.color = color;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
