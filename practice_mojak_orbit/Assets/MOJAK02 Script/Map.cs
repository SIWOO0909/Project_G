using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int carril = -3;
    public int nextmap = 100;
    public GameObject[] pisos;
    public GameObject[] nextpisos;
    public int pisosDiferencia;

    private void Start()
    {
        for(int i =0; i < pisosDiferencia; i++)
        {
            CrearPiso();
        }
    }

    public void CrearPiso()
    {
        if(carril >= nextmap)
        {
            Instantiate(nextpisos[UnityEngine.Random.Range(0, nextpisos.Length)], Vector3.right * carril, Quaternion.identity);
            carril++;
        }
        else
        {
            Instantiate(pisos[UnityEngine.Random.Range(0, pisos.Length)], Vector3.right * carril, Quaternion.identity);
            carril++;
        }
    }
}
