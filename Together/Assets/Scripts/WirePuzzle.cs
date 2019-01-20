using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WirePuzzle : MonoBehaviour
{

    public bool nowWirePuzzle = false;
    public bool finishedWirePuzzle;
    public Light terminalLight;

    public GameObject redTrigger;
    private SphereCollider redSphereCollider;

    public GameObject greenTrigger;
    private SphereCollider greenSphereCollider;

    public GameObject blueTrigger;
    private SphereCollider blueSphereCollider;


    // Start is called before the first frame update
    void Start()
    {
        terminalLight.enabled = false;


        redSphereCollider = redTrigger.GetComponent<Collider>() as SphereCollider;
        greenSphereCollider = greenTrigger.GetComponent<Collider>() as SphereCollider;
        blueSphereCollider = blueTrigger.GetComponent<Collider>() as SphereCollider;

        redSphereCollider.enabled = false;
        greenSphereCollider.enabled = false;
        blueSphereCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (nowWirePuzzle)
        {
            redSphereCollider.enabled = true;
            greenSphereCollider.enabled = true;
            blueSphereCollider.enabled = true;


            if (redTrigger.GetComponent<WireConnected>().active == true 
                    && blueTrigger.GetComponent<WireConnected>().active == true
                    && greenTrigger.GetComponent<WireConnected>().active == true)
            {
                Debug.Log("got all the wires!");
                finishedWirePuzzle = true;
                nowWirePuzzle = false;
                terminalLight.enabled = true; //terminal powers on
            }
        }

    }
    
}
