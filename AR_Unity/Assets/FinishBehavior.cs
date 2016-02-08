using UnityEngine;
using System.Collections;

public class FinishBehavior : MonoBehaviour
{

    void OnTriggerEnter(Collider _collider)
    {
        if (_collider.gameObject.tag == "Player")
        {
            Debug.Log("Yay");
        }
    }
}
