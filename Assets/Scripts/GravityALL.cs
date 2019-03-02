using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GravityALL : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 gravity = new Vector3(0, -9.81f, 0);
    [SerializeField] Text gravityText;
    public void applyGravityToAll()
    {
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("cube");

        int z = allObjects.Length;
        for(int x = 0; x < z; x++)
        {
            allObjects[x].GetComponent<Rigidbody>().useGravity = true;
        }
    }

    public void adjustGravity()
    {

        Physics.gravity = gravity * (gameObject.GetComponent<Slider>().value * 100);
        Debug.Log(Physics.gravity);
        gravityText.text = "gravity: " + Physics.gravity.y.ToString("F2");
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("cube");

        int z = allObjects.Length;
        for (int x = 0; x < z; x++)
        {
            if (gameObject.GetComponent<Slider>().value == 0.0f)
            {
                allObjects[x].GetComponent<Rigidbody>().isKinematic = true;
                
            }
            else
                allObjects[x].GetComponent<Rigidbody>().isKinematic = false;
           
        }
    }

    public void impulseForce()
    {

        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("cube");

        int z = allObjects.Length;
        for (int x = 0; x < z; x++)
        {
            int u = Random.Range(0, 100);
            float xval = Random.Range(-2000, 2000);
            float yval = Random.Range(-2000, 2000);
            float zval = Random.Range(-2000, 2000);
            allObjects[x].GetComponent<Rigidbody>().mass = u;
            Vector3 q = new Vector3(xval, yval, zval);
            allObjects[x].GetComponent<Rigidbody>().AddForce(q, ForceMode.Impulse);
        }
    }


}