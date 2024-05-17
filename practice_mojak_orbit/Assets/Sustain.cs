using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sustain : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
