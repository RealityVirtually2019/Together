
using UnityEngine;

public class RayCast : MonoBehaviour
{ 
    //hold the camera
    public Camera lightRay;
    //camera range for raycast
    public float lightRange = 7f;
    //reference the puzzle
    public GameObject LightBox;
    LightPuzzle lightPuzzle;
    


    // Start is called before the first frame update
    void Start()
    {
        lightPuzzle = LightBox.GetComponent<LightPuzzle>();
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        
    }

    void shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
            hit.transform.SendMessage("hitByRay");
        }

        if (Physics.Raycast(lightRay.transform.position, lightRay.transform.forward, out hit, lightRange))
        {
           Debug.Log(hit.transform.name);
            if (hit.distance < lightRange)
            {

            }
        }
    }
}
