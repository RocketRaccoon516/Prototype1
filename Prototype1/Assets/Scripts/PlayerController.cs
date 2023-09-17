using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables for speed and turning.
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput = 1.0f;
    private float verticalInput = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Uses the input manager.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); this moves instead of turns.

        //Moves vehicle left and right.
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
