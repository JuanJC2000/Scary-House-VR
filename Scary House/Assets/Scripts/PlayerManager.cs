using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 20;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
       
        if (health <= 0)
        {
            //destroy 
            Debug.Log("u have failed");
            //Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("zombie"))
        {
          
            TakeDamage(collision.gameObject.GetComponent<zombie>().damage);
            
        }
    }
}
