using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Propellor : MonoBehaviour
{
    
    private float Speed =40f;

    void Update()
    {
        transform.Rotate(Vector3.forward, Speed);
    }
}
