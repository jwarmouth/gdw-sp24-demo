using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.Rendering;

public class CarController : MonoBehaviour
{
    // declare variables here
    public float speed;
    public float rotationSpeed;
    public string forwardAxis;
    public GameObject bulletPrefab;
    int ammo;

    // Update is called once per frame
    void Update()
    {
        float forwardMovement;

        if (forwardAxis != "")
        {
            forwardMovement = Input.GetAxis(forwardAxis);
        }
        else
        {
            forwardMovement = 1.0f; 
        }

        if (Input.GetKeyDown(KeyCode.Space) || ammo > 0)
            // Logical AND &&
            // Logical OR  ||
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardMovement);
    }
}
