using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("10ƒ⁄¿Œ¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.");
        }
    }
}
