using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destrutor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.transform.gameObject);
    }
}

