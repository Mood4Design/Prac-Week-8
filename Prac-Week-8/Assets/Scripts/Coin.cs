using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {   
        
        if(other.CompareTag("Player"))
        {
            Scorekeeper.Instance.AddPointsForCoin();
            Destroy(gameObject);
        }
        else if(other.CompareTag("Player2"))
        {
            Scorekeeper.Instance.AddPointsForCoin2();
            Destroy(gameObject);
        }
    }
}
