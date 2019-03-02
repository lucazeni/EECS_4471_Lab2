using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lights : MonoBehaviour
{
    [SerializeField] Light backgroundlight;
    [SerializeField] Light spotlight;
 
    

    public void SliderChanged()
    {
        Debug.Log(gameObject.GetComponent<Slider>().value);
        backgroundlight.GetComponent<Light>().intensity = gameObject.GetComponent<Slider>().value * 100;
        spotlight.GetComponent<Light>().intensity = gameObject.GetComponent<Slider>().value * 100;
    }
   
}
