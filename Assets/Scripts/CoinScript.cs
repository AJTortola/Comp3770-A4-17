using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Capsule")
        {
            other.GetComponent<PickUpCounter>().points++;
            //Add 1 point
            Destroy(gameObject);//this destorys the item 
        }
    }
}
