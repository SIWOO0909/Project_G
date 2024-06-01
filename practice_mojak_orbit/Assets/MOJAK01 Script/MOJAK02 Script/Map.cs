using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int x = 0;
    public int carril = -3;
    public int nextmap = 100;
    public GameObject[] pisos;
    public GameObject[] nextpisos;
    public int pisosDiferencia;
    public AudioSource MapChangeBGM;
    public AudioSource OriginBGM;

    private void Start()
    {
        for(int i =0; i < pisosDiferencia; i++)
        {
            CrearPiso();
        }
    }

    public void CrearPiso()
    {
        // ¸ÊÀÌ ¹Ù²ð¶§
        // 
        if(carril >= nextmap+24)
        {
            // »ç¿îµå ¹ßµ¿
            if (x < 1)
            {
                OriginBGM.Stop();
                MapChangeBGM.Play();
                x = 1;
            }
        }
        if(carril >= nextmap)
        {
            Instantiate(nextpisos[UnityEngine.Random.Range(0, nextpisos.Length)], Vector3.right * carril, Quaternion.identity);
            carril++;
            Debug.Log("º¸¶ó¸Ê µîÀå!!!");
        }
        else
        {
            Instantiate(pisos[UnityEngine.Random.Range(0, pisos.Length)], Vector3.right * carril, Quaternion.identity);
            carril++;
        }
    }
}
