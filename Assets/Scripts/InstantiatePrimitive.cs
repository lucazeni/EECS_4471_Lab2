using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrimitive : MonoBehaviour
{
    [SerializeField] GameObject cube;

    public void instantiateCube()
    {
        // Quaternion.Euler(rot);
        Vector3 w = new Vector3(Random.Range(0.0f, 180.0f), Random.Range(0.0f, 180.0f), Random.Range(0.0f, 180.0f));
        Vector3 q = new Vector3(Random.Range(100.0f, 400.6f), Random.Range(0.0f, 200.3f), Random.Range(100.00f, 300.5f));
        Instantiate(cube, q, Quaternion.Euler(w));
            
    }

}
