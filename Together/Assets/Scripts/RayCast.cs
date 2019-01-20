
using UnityEngine;

public class RayCast : MonoBehaviour
{ 
    //hold the camera
    public Camera lightRay;
    //camera range for raycast
    public float lightRange = 7f;
    //reference the puzzle
    //public GameObject LightBox;
   // LightPuzzle lightPuzzle;
    enumLight hitByRay;
    


    // Start is called before the first frame update
    void Start()
    {
        //lightPuzzle = LightBox.GetComponent<LightPuzzle>();
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
       // if ((hitByRay == null) && (GetComponent<enumLight>() != null))
       // {
         //   hitByRay = GetComponent<enumLight>();
          //  Debug.Log("got component");
       // }
       // else
       // {
         //   Debug.LogWarning("Missing hitByRay_script component. Please add one");
       // }

    }

   public void shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
           // hit.transform.SendMessage("hitByRay");
        }

        if (Physics.Raycast(lightRay.transform.position, lightRay.transform.forward, out hit, lightRange))
        {
            //Debug.Log(hit.transform.name);
            Debug.DrawRay(lightRay.transform.position, lightRay.transform.forward);

            hitByRay = hit.collider.GetComponent<enumLight>();
            if (hit.distance < lightRange)
            {
                Debug.Log(hit.transform.name);
                //hit.collider.gameObject.GetComponent<enumLight>().HitByray();
                hitByRay.startLerp();
            }
        }
    }
}
