﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControls : MonoBehaviour
{
    Vector3 rotation;
    [SerializeField]
    float rotationSpeed, maxAngle;
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 1f;
        maxAngle = 80f;
    }

    // Update is called once per frame
    void Update()
    {
        lookAround();
    }

    public void lookAround()
    {
        rotation += new Vector3(-Input.GetAxis("Mouse Y"), 0, 0) * rotationSpeed;
        rotation.x = Mathf.Clamp(rotation.x, -maxAngle, maxAngle);
        transform.localRotation = Quaternion.Euler(rotation);
    }
}