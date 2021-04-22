using UnityEngine;

public class RC_S : MonoBehaviour
{
    public Camera mainCamara;
    Ray rallo = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;



    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            destroyBlock();
        }
    }

    void destroyBlock()
    {
        
        if (Physics.Raycast(rallo, out hit))
        {
            Debug.Log(hit.transform.name);

            Destroy(hit.transform.gameObject);
        }
    }
}
