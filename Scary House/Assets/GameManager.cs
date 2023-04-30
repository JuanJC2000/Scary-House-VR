using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public static UnityAction onZombieDie;
    public static UnityAction onRoundStart;

    private int zombieCount = 0;

    public bool roundFinished;

    public int currentRound;
    private void Awake()
    {
        onZombieDie = CheckStatus;
        onRoundStart = MaxZombies;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckStatus()
    {
        zombieCount--;
        if (zombieCount <= 0)
        {
            Debug.Log("Win");
            roundFinished = true;
            currentRound++;
        }
    }

    public void MaxZombies()
    {

        
    }
}
