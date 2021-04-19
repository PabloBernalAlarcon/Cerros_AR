using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayForItem : MonoBehaviour
{
    Vector3 direction;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1, 5);
        direction = Vector3.zero;
        direction.x = Random.Range(-10, 10);
        direction.z = Random.Range(-10, 10);

        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction*Time.deltaTime*speed;
    }

    public void HitByRay()
    {
        Debug.Log(transform.name + " has been hit y duele musho.");
        Destroy(this.gameObject);
    }
}
