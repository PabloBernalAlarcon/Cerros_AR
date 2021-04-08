using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PabloSr_Patrick_Movement : MonoBehaviour
{
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //When I press left arrow
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Delta time
            //60fps -> 1/60 frame = 0.016
            //30 fps -> 1/30 frame = 0.3333
            //3 units per second.
            Vector3 newPos = new Vector3(-speed*Time.deltaTime, 0, 0);
            transform.position = transform.position + newPos;
        }
        //When I press left arrow
       else if (Input.GetKey(KeyCode.RightArrow))
        {
            //Delta time
            //60fps -> 1/60 frame = 0.016
            //30 fps -> 1/30 frame = 0.3333
            //3 units per second.
            Vector3 newPos = new Vector3(speed * Time.deltaTime, 0, 0);
            transform.position = transform.position + newPos;
        }
    }
}
