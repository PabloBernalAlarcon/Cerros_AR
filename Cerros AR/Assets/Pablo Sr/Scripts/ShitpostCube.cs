using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShitpostCube : MonoBehaviour
{
    public float RotationSpeed;
    public Transform gameCam;

    public Slider SpeedSlider;
    Vector3 RotateBy;

    Vector3 Xtransition;
    // Start is called before the first frame update
    void Start()
    {
        RotateBy = new Vector3(0,RotationSpeed*Time.deltaTime,0);
        Xtransition = new Vector3(0, 0, -1);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(gameCam);
      RotateBy = new Vector3(0, RotationSpeed * Time.deltaTime, 0);
        transform.Rotate(RotateBy);
        Debug.Log("DT: "+Time.deltaTime);

        if (moving==true)
        {
            transform.position += (Xtransition * Time.deltaTime);
        }
    }

    public void SetSpeed()
    {
        RotationSpeed = SpeedSlider.value;
    }

    bool moving = false;
    public void MoveKenny()
    {
        moving = true;
    }
    public void StopKenny()
    {
        moving = false;
    }

}
