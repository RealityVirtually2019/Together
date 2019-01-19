using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireConnected : MonoBehaviour
{
    public bool active;
    public GameObject correctMissingComponent;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == correctMissingComponent)
        {
            active = true;
            //TODO: freeze the correctMissingComponent in place
        }

    }
}