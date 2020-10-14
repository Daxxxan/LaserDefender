﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D laserCollider)
    {
        Debug.Log("I'm triggered");
        Destroy(laserCollider.gameObject);
    }
}