using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    float playerSpeed;
    float speedLimit;

    bool overSpeedLimit;
    public Transform[] spheres;
    int i = 0;




    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Delicious Pancakes");
        }



    }

    // Update is called once per frame
    void Update()
    {
        if (i < 10) 
        {
        spheres[i].transform.Translate(0, 5, 0);
        i++;
        }
    }
}
