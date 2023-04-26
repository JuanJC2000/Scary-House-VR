using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooting : MonoBehaviour
{
    public Transform outRay;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        

    }

    public void ShootOn()
    {
        RaycastHit hit;
        Debug.DrawRay(outRay.position, outRay.forward, Color.red);
        if (Physics.Raycast(outRay.position, outRay.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            if (hit.collider.CompareTag("RedBalls"))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }


}
