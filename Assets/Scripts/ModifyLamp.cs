using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyLamp : MonoBehaviour
{
    [SerializeField] GameObject lamp;
    int q = 50;
    public void SliderChangedLampScale()
    {
        Vector3 x = new Vector3(500f, 500f, 500f);
        lamp.transform.localScale += x;
       
    }

    public void SliderChangedLampRotate()
    {
        // camera.transform.rotation = Quaternion.Euler(cameraXR, cameraYR, cameraZR);

        lamp.transform.rotation = Quaternion.Euler(q, 0, 0);
        q = q + 50;

    }

}
