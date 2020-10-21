using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject carPrefab;

    private int count = 0;
    
    private void Update()
    {
        if (count > 5000)
            return;

        GameObject newCar = GameObject.Instantiate(carPrefab);
        newCar.transform.position = new Vector3(4.0f + count, -1.9f, 0.0f);
        newCar.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

        count++;
    }

    public void Spawn100Cars()
    {
        
    }
}
