using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRayitoos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Cleeek");
            //Create a ray that comes from the position of the mouse
            Ray rayito = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //if the ray hits anything
            if (Physics.Raycast(rayito,out hit))
            {
                //do magic
                Debug.Log( hit.transform.name);
                //I destroy what I toucj
                Destroy(hit.transform.gameObject);
            }

        }
    }
}
