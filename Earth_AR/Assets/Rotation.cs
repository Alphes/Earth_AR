using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Rotate(0, -0.75f, 0);
    }
}
