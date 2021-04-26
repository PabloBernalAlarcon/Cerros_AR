using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Soul_Controller : MonoBehaviour
{

    public Transform objetivo;
    private NavMeshAgent agente;
    Vector3 SpawnPosition = new Vector3(-15, 2, 18);
    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        //agente.destination = objetivo.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void act()
    {
        agente.isStopped = false;
        Debug.Log("AAAAAAAAAAAAAAAAAAAA");
        agente.destination = objetivo.position;

    }

    public void reestart()
    {
        Debug.Log("EEEEEEEEEEEEEEEEEEEE");
        agente.isStopped = true;
        transform.position = SpawnPosition;
    }

    public IEnumerator Uaredead()
    {
        GetComponent<SphereCollider>().enabled = false;
        Debug.Log("EEEEEEEEEEEEEEEEEEEE");
        agente.isStopped = true;
        GetComponent<NavMeshAgent>().enabled = false;
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(0, 99, 0);
        transform.position = SpawnPosition;
        GetComponent<NavMeshAgent>().enabled = true;
        GetComponent<SphereCollider>().enabled = true;

    }
}
