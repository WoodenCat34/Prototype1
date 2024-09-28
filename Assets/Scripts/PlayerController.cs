using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerID; 
    private float vehicleSpeed = 30f;
    private float vehicleTurn = 40f;

    private float horizontalInput;
    private float verticalInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          // Getting keyboard inputs every frame
        horizontalInput = Input.GetAxis("Horizontal" + playerID);
        verticalInput = Input.GetAxis("Vertical" + playerID);
          // Moving vehicle forard using vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * verticalInput);
          // Rotating vehicle using horizontal inputs
        transform.Rotate(Vector3.up * Time.deltaTime * vehicleTurn * horizontalInput);
          // Switching cameras based on switch key down 
        if (Input.GetKeyDown(switchKey)) {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
         }
            
        
    }
}
