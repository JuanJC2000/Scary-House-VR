using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class zombie : MonoBehaviour
{
    // Set base values
    public int speed = 15;
    public int damage = 10;
    

    public int health = 100;

    public bool takenDamage;
    
    //get reference to player

    private GameObject player;
    //get reference to zombie ai agent
    private NavMeshAgent zombieAI;

    // Start is called before the first frame update

    /// <summary>
    /// Intialize zombie agent and set its speed to value (editor). 
    /// Find player with .FindGameObjectWithTag
    /// </summary>
    void Start()
    {
        zombieAI = GetComponent<NavMeshAgent>();

        zombieAI.speed = speed;

        player = GameObject.FindGameObjectWithTag("Player");
        
    }

   
    /// <summary>
    /// Get player destination and set zombie destinaton to player transform.
    /// </summary>
    void Update()
    {
        zombieAI.destination = player.transform.position;
        Debug.DrawLine(transform.position, zombieAI.destination, Color.red); //debug
    }

    
    // Context Menu for editor mode

    [ContextMenu ("Damage")]
    
    //Public function to reduce health and conditional to check for Kill function
    public void TakeDamage()
    {
        health -= 25;
        if (health <= 0)
        {
            //destroy 
            
            Kill();
            
        }
    }
    // Context menu
    [ContextMenu ("kill")]

    //Public kill function to destroy gameObject and Invoke reference to onZombieDie in SpawnManager.
    public void Kill()
    {
        Destroy(gameObject);
        GameManager.onZombieDie.Invoke();
    }
    //Collision to induce damage on collision with bullet 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage();
        }
    }
}
