using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class zombie : MonoBehaviour
{

    public int speed = 15;
    public int damage = 10;
    

    public int health = 100;

    public bool takenDamage;
    

    private GameObject player;
    private NavMeshAgent zombieAI;

    // Start is called before the first frame update
    void Start()
    {
        zombieAI = GetComponent<NavMeshAgent>();

        zombieAI.speed = speed;

        player = GameObject.FindGameObjectWithTag("Player");
        print(player.name);
    }

    // Update is called once per frame
    void Update()
    {
        zombieAI.destination = player.transform.position;
    }

    [ContextMenu ("Damage")]
    public void TakeDamage()
    {
        health -= 25;
        if (health <= 0)
        {
            //destroy 
            
            Kill();
            
        }
    }

    [ContextMenu ("kill")]
    public void Kill()
    {
        Destroy(gameObject);
        SpawnManager.onZombieDie.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage();
        }
    }
}
