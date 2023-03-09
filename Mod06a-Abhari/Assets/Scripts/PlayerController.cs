using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float angleSpeed;
    // Input handler
    public float horizontalInput;
    public float forwardInput;
    public float jumpInput;

    // Start is called before the first frame update
    void Start()
    {
        speed = 20;
        angleSpeed = 45;
    }

    // Update is called once per frame
    void Update()
    {
        // Getting input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");

        // Move the vehicle
        transform.Translate(new Vector3(0, 1, 0) * speed * jumpInput * Time.deltaTime);
        transform.Translate(new Vector3(0, 0, 1) * speed * forwardInput * Time.deltaTime);
        transform.Rotate(new Vector3(0, 1, 0), angleSpeed * horizontalInput * Time.deltaTime);
    }
}
