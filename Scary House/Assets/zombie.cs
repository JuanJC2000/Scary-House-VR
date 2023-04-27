using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class zombie : MonoBehaviour
{

    public int speed = 15;
    private GameObject player;
    private NavMeshAgent zombieAI;

    // Start is called before the first frame update
    void Start()
    {
        zombieAI = GetComponent<NavMeshAgent>();

        player = GameObject.FindGameObjectWithTag("Player");
        print(player.name);
    }

    // Update is called once per frame
    void Update()
    {
        zombieAI.destination = player.transform.position;
    }
}
