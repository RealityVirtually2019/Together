using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    //public GameObject box;
    public Material material;
    //public Material[] mat;
   // Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        //box.SetActive(false);
       material.DisableKeyword("_EMISSION");
        //rend = GetComponent<Renderer>();
        //rend.enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
