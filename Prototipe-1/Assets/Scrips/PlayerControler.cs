using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    Vector3 currentPosition;
    Vector3 newPosition;
    public Vector3 positionOffset = new Vector3(0, 0, 1);
    public float speed = 15.0f;
    public float turnSpeed = 30.0f;
    public float nitroSpeed = 10.0f;
    public float verticalInput;
    public float horizontalInput;
    
    


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    private void movement()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (verticalInput > 0)
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        if (verticalInput < 0)
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput * -1);

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
    }

}
