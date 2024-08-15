using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pancake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 180);
    }

    private void OnTriggerEnter(Collider other)
    {
        Makoto.score += 1;
        Debug.Log(Makoto.score);
        Makoto.gm.UpdateScore();
        Destroy(gameObject);
    }
} 
