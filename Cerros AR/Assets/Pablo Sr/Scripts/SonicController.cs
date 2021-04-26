using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicController : MonoBehaviour
{
    // Start is called before the first frame update
    float speed;
    Vector3 Direction;
    void Start()
    {
     
        speed = Random.Range(-10, 10);

        Direction = new Vector3();
        Direction.x = Random.Range(-10, 10);
        Direction.z = Random.Range(-10, 10);
        Direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("in");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("out");
    }
}
