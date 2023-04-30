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

    public GameObject[] zombieTypes;
  
    public bool roundFinished;
    public bool roundStart;

    //static to be used by all clases, Unity Action delegate acting as observer?.
  


    //Reference the function 
    private void Awake()
    {
        
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
            Instantiate(zombieTypes[Random.Range (0,3)], transform);
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

    //CheckStatus as as function and observer to check for condition// event 
  

  

   // public void Kill()
  //  {
   //     Destroy(gameObject);
  //      SpawnManager.onZombieDie.Invoke();
  //  }
}
