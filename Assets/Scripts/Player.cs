using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Player : NetworkBehaviour
{

    [SerializeField] private float movementSpeed = 7f;
    [SerializeField] private float rotationSpeed = 500f;

    void Update()
    {

        if (!IsOwner) { return; };

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        movement.Normalize();
        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

    }
}
