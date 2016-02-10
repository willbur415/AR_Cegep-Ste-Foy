﻿using UnityEngine;
using System.Collections;

public class FinishBehavior : MonoBehaviour
{

    void OnTriggerEnter(Collider _collider)
    {
        if (_collider.gameObject.tag == "Player")
        {
            _collider.transform.position = GameObject.Find("Starting Position").transform.position;
        }
    }
}
