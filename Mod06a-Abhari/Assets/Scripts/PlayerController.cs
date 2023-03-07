using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float angleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 15;
        angleSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle
        transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        transform.Translate(Vector3.right * Time.deltaTime * angleSpeed);
    }
}
