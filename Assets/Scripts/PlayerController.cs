using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    private float turnSpeed = 200;
    private float horizontalInput;
    private float forwardInput;
    public GameObject door;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "key")
        {
            Destroy(other.gameObject);
            Destroy(door);
        }
    }   
}
