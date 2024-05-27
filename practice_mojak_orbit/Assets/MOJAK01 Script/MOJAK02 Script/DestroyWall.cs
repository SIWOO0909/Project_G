using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("obstaculo"))
        {
            Destroy(other.transform.gameObject);
            Debug.Log("�� �ϼ���!");
        }
        if (other.transform.CompareTag("carro"))
        {
            Destroy(other.transform.gameObject);
            Debug.Log("����ü �ϼ���!");
        }
    }
}
