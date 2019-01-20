using UnityEngine;

public class RedLight : MonoBehaviour
{
    // Interpolate light color between two colors back and forth
    Color color0 = Color.red;
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
