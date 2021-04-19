using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Kenny;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Kenny!= null)
        transform.LookAt(Kenny);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click");
            RaycastHit hit;
            Ray rayito = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayito, out hit))
            {
                Debug.Log(hit.collider.name);
                RayForItem RF = hit.transform.GetComponent<RayForItem>();
                if (RF != null)
                    RF.HitByRay();
                
            }
        }
    }
}
