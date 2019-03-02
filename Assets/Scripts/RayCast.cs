using UnityEngine;
using UnityEngine.UI;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Canvas cubeCanvas;
    [SerializeField] Canvas cabinetCanvas;
    [SerializeField] Slider LampScale;
    [SerializeField] Slider LampRotate;
    [SerializeField] Slider cubeScale;
    [SerializeField] Slider cubeRotate;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {

            Ray ray = new Ray();
            RaycastHit hit;
            ray.direction = Camera.main.transform.forward;
            ray.origin = Camera.main.transform.position;



            if (Physics.Raycast(ray, out hit))
            {

                Debug.DrawLine(transform.position, hit.point, Color.red);
                if (hit.collider.gameObject.name == "Cube")
                    {
                        cubeCanvas.enabled = true;
                     }
                else if (hit.collider.gameObject.name == "Cabinet")
                {
                    cabinetCanvas.enabled = true;
                }

                if (hit.collider.gameObject.name == "Scale Handle Cube")
                {
                    Debug.Log("SHC");
                    cubeScale.value = cubeScale.value + 0.1f;

                }
                if (hit.collider.gameObject.name == "Rotate Handle Cube")
                {
                    Debug.Log("RHC");
                    cubeRotate.value = cubeRotate.value + 0.1f;
                }

                if (hit.collider.gameObject.name == "Rotate Handle Lamp")
                {
                    Debug.Log("RHL");
                    LampRotate.value = LampRotate.value + 0.1f;
                }
                if (hit.collider.gameObject.name == "Scale Handle Lamp")
                {
                    Debug.Log("SHL");
                    LampScale.value = LampScale.value + 0.1f;
                }
                


            }
        }
    }


}

