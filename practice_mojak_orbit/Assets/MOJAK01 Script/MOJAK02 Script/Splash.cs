using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
    public GameObject targetObject;

    public void DestroyTargetObject()
    {
        Destroy(targetObject);
        Debug.Log("���÷��� �ı�");
    }
}
