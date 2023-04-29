using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnManager : MonoBehaviour
{
   
    public float countDownRate = 10f;
    public float roundTimer = 99999f;

    public int zombieLimit = 3;
    private int zombieCount = 0;
    public int zombieCountMax = 0;
    public int baseZombieCount = 5;


    public int currentRound;

    public GameObject[] zombieArray;
  
    public bool roundFinished;
    public bool roundStart;

    public static UnityAction onZombieDie;

    private void Awake()
    {
        onZombieDie = CheckStatus;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnZombies());
        currentRound = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnZombies()
    {


        while (zombieCount < zombieLimit)
        {
            Instantiate(zombieArray[Random.Range (0,3)], transform);
            zombieCount++;

            yield return new WaitForSeconds(countDownRate);

        }

    }


    //
    public IEnumerator RoundBegin()
    {
        while (roundFinished != true)
        {
            

            yield return new WaitForSeconds(roundTimer);
        }

       
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
}
