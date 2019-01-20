using UnityEngine;

public class GreenLight : MonoBehaviour
{
    // Interpolate light color between two colors back and forth
    Color color0 = Color.green;
    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
        lt.color = color0;
    }

    void Update()
    {
    }
}
