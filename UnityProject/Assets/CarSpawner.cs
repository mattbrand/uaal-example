using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject carPrefab;

    private int count = 0;
    private Transform parentTrans;
    
    public void Start()
    {
        parentTrans = GameObject.Find("CarSpawner").transform;
    }
    
    private void Update()
    {

    }
    
    public void OnButtonClicked()
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Adding 500 more models to increase memory");
        Spawn500Cars();
    }
    
    private void Spawn500Cars()
    {
        var pt = this.parentTrans;
        
        for (int i = 0; i < 500; i++)
        {
            GameObject newCar = GameObject.Instantiate(carPrefab);
            newCar.transform.position = new Vector3(4.0f + count + i, -1.9f, 0.0f);
            newCar.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            newCar.transform.parent = pt; // here to organize the clones under a single game object 
        }

        count = count + 500;
    }
}
