using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnUnits : MonoBehaviour
{
    public GameObject unit;
    public int counter;
    private int spawnCounter = 180;
    Vector3 offset = new Vector3(0, 1.5f, 5.5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter % spawnCounter == 0)
        {
            GameObject newUnit = Instantiate(unit);
            newUnit.transform.position = this.transform.position + offset;
        }
        counter++;
    }
}
