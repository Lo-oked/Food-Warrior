using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitspawner : MonoBehaviour
{
    public GameObject fruit;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("spawnfruit", 1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnfruit()
    {
        var position = new Vector3(Random.Range(-10.0f, 10.0f), -5, 0);
        Instantiate(fruit, position, Quaternion.identity);
    }
}
