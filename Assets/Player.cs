using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform cameraRig;
    public float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Makoto.gm.player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = cameraRig.forward * Input.GetAxisRaw("Vertical");
        movement += cameraRig.right * Input.GetAxisRaw("Horizontal");

        rb.AddForce(movement * speed);
    }
}
