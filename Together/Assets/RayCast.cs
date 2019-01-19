
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public Camera lightRay;
    public float lightRange = 7f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        
    }

    void shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(lightRay.transform.position, lightRay.transform.forward, out hit, lightRange))
        {
            Debug.Log(hit.transform.name);
            if (hit < lightRange)
            {

            }
        }
    }
}
