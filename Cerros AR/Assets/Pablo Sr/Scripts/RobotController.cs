using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    //float robotSpeed = 1;
    enum Steps { Forward, Left, Right};
                            //0,1,2
    Queue<Steps> Pasitos;
    AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        Pasitos = new Queue<Steps>();
        AS = GetComponent<AudioSource>();
    }

    public void EnqueueForward()
    {
        Pasitos.Enqueue(Steps.Forward);
    }
    public void EnqueueLeft()
    {
        Pasitos.Enqueue(Steps.Left);
    }
    private void MoveLeft()
    {
        StartCoroutine(L());
    }
    private IEnumerator L()
    {

        //I need to do this for 1 second.
        for (float elaspedTime = 0; elaspedTime < 1f; elaspedTime += Time.deltaTime)
        {
            transform.Rotate(0, -90 * Time.deltaTime, 0);
            yield return null;
        }
    }
    public void EnqueueRight()
    {
        Pasitos.Enqueue(Steps.Right);
    }

    private void MoveRight()
    {
        StartCoroutine(R());
    }
    private IEnumerator R()
    {
     
        //I need to do this for 1 second.
        for (float elaspedTime = 0; elaspedTime < 1f; elaspedTime += Time.deltaTime)
        {
            transform.Rotate(0, 90*Time.deltaTime, 0);
            yield return null;
        }
    }

    public void Execute()
    {
        StartCoroutine(ExecuteCommands());
    }
    private void MoveForward()
    {
        StartCoroutine(FW());
    }

    private IEnumerator FW()
    {
        //I need to do this for 1 second.
        for (float elaspedTime = 0; elaspedTime <= 1f; elaspedTime += Time.deltaTime)
        {
            transform.position += (transform.forward * Time.deltaTime);
            yield return null;
        }
    }

    private IEnumerator ExecuteCommands()
    {
        while (Pasitos.Count > 0)
        {
            AS.Play();
            Steps s = Pasitos.Peek();

            switch (s)
            {
                case Steps.Forward:
                    MoveForward();
                    break;
                case Steps.Left:
                    MoveLeft();
                    break;
                case Steps.Right:
                    MoveRight();
                    break;
            }

            Pasitos.Dequeue();
            yield return new WaitForSeconds(1);
           
        }
    }
}
