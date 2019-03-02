using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyCube : MonoBehaviour
{
    [SerializeField] GameObject cube;
    int q = 50;
    public void SliderChangedCubeScale()
    {
        Vector3 x = new Vector3(5.0f, 0.0f, 0.0f);
        cube.transform.localScale += x;
        
    }

    public void SliderChangedCubeRotate()
    {
        // camera.transform.rotation = Quaternion.Euler(cameraXR, cameraYR, cameraZR);
        
        cube.transform.rotation = Quaternion.Euler(q, 0, 0);
        q = q + 50;

    }

}
