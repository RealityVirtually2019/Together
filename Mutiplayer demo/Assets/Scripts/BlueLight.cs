using UnityEngine;

public class BlueLight : MonoBehaviour
{
    // Interpolate light color between two colors back and forth
    Color color0 = Color.blue;
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
