using UnityEngine;
using System.Collections;

public class GravityChanger : MonoBehaviour {
	void Update () 
    {
        Physics.gravity = transform.forward;

    }
}
