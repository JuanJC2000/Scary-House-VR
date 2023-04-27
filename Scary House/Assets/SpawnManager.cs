using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public float countDownRate = 10f;

    public int zombieLimit = 3;
    public int zombieCount = 0;

    public GameObject zombie;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator CountDown()
    {
        while (zombieCount < zombieLimit)
        {
            Instantiate(zombie);
            zombieCount++;

            yield return new WaitForSeconds(countDownRate);

        }

    }
}
