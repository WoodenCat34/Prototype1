using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float vehicleSpeed = 20f;
    private float vehicleTurn = 10f;

    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * vehicleTurn * horizontalInput);
        
    }
}
