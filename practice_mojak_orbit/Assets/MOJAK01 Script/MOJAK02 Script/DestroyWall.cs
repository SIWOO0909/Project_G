using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    // public AudioSource ChumBeong;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("obstaculo"))
        {
            Destroy(other.transform.gameObject);
            Debug.Log("�� �ϼ���!");
            int biggerScore = PlayerPrefs.GetInt("plus")+10;
            PlayerPrefs.SetInt("plus", biggerScore);
            Debug.Log(biggerScore);
        }
        if (other.transform.CompareTag("carro"))
        {
            // ChumBeong.Play();
            Destroy(other.transform.gameObject);
            Debug.Log("����ü �ϼ���!");
            int biggerScore = PlayerPrefs.GetInt("plus") + 10;
            PlayerPrefs.SetInt("plus", biggerScore);
        }
    }
}
