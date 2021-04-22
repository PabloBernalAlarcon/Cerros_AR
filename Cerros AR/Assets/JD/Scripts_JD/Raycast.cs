using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    private bool touching = false;
    private Soul_Controller SC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Debug.Log("Cleeek");
            //Create a ray that comes from the position of the mouse
            Ray rayito = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //if the ray hits anything
            if (Physics.Raycast(rayito, out hit))
            {
                if (hit.transform.name == "Soul")
                {
                    if (touching != true)
                    {
                        //do magic
                        Debug.Log(hit.transform.name);
                        SC = hit.transform.GetComponent<Soul_Controller>();
                        if (SC != null)
                        {
                            SC.act();
                        }
                        touching = true;
                    }

                }

                else if (hit.transform.name != "Soul" && touching == true)
                {
                    touching = false;
                    Debug.Log(hit.transform.name);
                    if (SC != null)
                    {
                        StartCoroutine(SC.Uaredead());
                    }
                }
                //I destroy what I toucj
                //Destroy(hit.transform.gameObject);
                //SC.reestart();
            }




        }
        if (Input.GetMouseButtonUp(0))
        {
            touching = false;
            if (SC != null)
            {
                StartCoroutine(SC.Uaredead());
            }
        }
    }
}
