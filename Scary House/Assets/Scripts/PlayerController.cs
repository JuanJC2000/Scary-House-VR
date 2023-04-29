using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20f;
    public float maxSpeed;
    public float minSpeed;
    public float Thrust;

    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);

        // Make car go forwards
    }
}
