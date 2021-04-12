using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShitpostCube : MonoBehaviour
{

    public float RotationSpeed;

    public Slider SpeedSlider;
    Vector3 RotateBy;
    // Start is called before the first frame update
    void Start()
    {
        RotateBy = new Vector3(0,RotationSpeed*Time.deltaTime,0);
    }

    // Update is called once per frame
    void Update()
    {
      RotateBy = new Vector3(0, RotationSpeed * Time.deltaTime, 0);
        transform.Rotate(RotateBy);
    }

    public void SetSpeed()
    {
        RotationSpeed = SpeedSlider.value;
    }
}
