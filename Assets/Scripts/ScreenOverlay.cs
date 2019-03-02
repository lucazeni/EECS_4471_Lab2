using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOverlay : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    bool x = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) // set HMD aim
        {
            if(x)
            {
                gameObject.GetComponent<Canvas>().enabled = true;
                x = false;

            }
            else if(!x)
            {
                gameObject.GetComponent<Canvas>().enabled = false;
                x = true;
            }
          
        }
      
    }
}
