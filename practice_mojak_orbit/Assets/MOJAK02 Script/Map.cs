using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int carril = -3;
    public GameObject[] pisos;
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
        
        Instantiate(pisos[UnityEngine.Random.Range(0,pisos.Length)], Vector3.right * carril, Quaternion.identity);
        carril++;
    }
}
