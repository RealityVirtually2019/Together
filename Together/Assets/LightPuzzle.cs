using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzle : MonoBehaviour
{
    public GameObject puzzle;
   // objectWithScript.GetComponent<ReferencedScript>();

        //setting color
    public Color color = Color.white;
    private Color solid = Color.white;
    Renderer rend;
    private float sec = 2f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        //setting opacity of color
        color.a = 0f;
        rend.material.color = color;
        solid.a = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
        fadeIn();
    }
   
    void fadeIn()
    {
        // float startOpacity = 0.0f;
        //float endOpacity = 1f;
        Color inv = Color.white;
        inv.a = 0f;

        Color full = Color.white;
        full.a = 1f;
        
        
            rend.material.color = Color.Lerp(inv, full, Time.deltaTime * sec);
        
    }
}
