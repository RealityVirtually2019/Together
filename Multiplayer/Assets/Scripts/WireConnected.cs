using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireConnected : MonoBehaviour
{
    public bool active;
    public GameObject correctMissingComponent;

    private HTC.UnityPlugin.Vive.BasicGrabbable grabbingScript;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
        grabbingScript = correctMissingComponent.GetComponent<HTC.UnityPlugin.Vive.BasicGrabbable>();
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
            correctMissingComponent.transform.parent = this.transform;
            correctMissingComponent.transform.parent.rotation = this.transform.rotation;
            correctMissingComponent.transform.localPosition = Vector3.zero;
            correctMissingComponent.GetComponent<Rigidbody>().detectCollisions = false;
            grabbingScript.enabled = false;
        }

    }
}