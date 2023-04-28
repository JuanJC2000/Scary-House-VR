using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaycastShooting : MonoBehaviour
{
    public Transform outRay;
    [SerializeField] private float shotPower = 500f;
    [SerializeField] private Transform bulletLeave;
    public GameObject bulletPrefab;

    public Rigidbody rb;
    
    

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

    public void Shoot()
    {
       // Instantiate(bulletPrefab, bulletLeave.position, bulletLeave.rotation).GetComponent<Rigidbody>().AddForce(bulletLeave.forward * shotPower);
        var varName = Instantiate(bulletPrefab, bulletLeave.position, bulletLeave.rotation);

        Rigidbody rb = varName.GetComponent<Rigidbody>();
       // varName2.WakeUp();
        rb.AddForce(rb.transform.forward * shotPower);
        Debug.Log("I have shot" + rb.transform.forward * shotPower );
        





    }


}
