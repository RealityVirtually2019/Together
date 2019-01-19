using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    private WirePuzzle wireFun;
    public Rigidbody cyrochamber;
    // Start is called before the first frame update
    void Start()
    {
        wireFun = GetComponent<WirePuzzle>();
        Begin();
        
    }

    // Update is called once per frame
    void Update()
    {
        //IntroPuzzle();

        if (wireFun.finishedWirePuzzle)
        {
            //start outro
        }
        
        
        //Outro();
    }

    private void Begin()
    {
        //TODO: tube reads "on standby"
        cyrochamber.useGravity = false; //start cyrochamber around player
        //wait for phones to press button at same time

        cyrochamber.useGravity = true; //tube goes away
        //Destroy(cyrochamber, 2); TODO breaks it
        //start storm

        //starts wire puzzle
        wireFun.nowWirePuzzle = true;

    }

    private void IntroPuzzle()
    {

    }

    private void WirePuzzle()
    {
        //redMissingPiece = GameObject.FindWithTag("MissingWireComponent");
    }

    private void Outro()
    {
        
    }
}
