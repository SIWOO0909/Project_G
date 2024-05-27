using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hojas : MonoBehaviour
{
    public GameObject hoja;

    void Start()
    {
        LanzarRayo();
    }

    public void LanzarRayo()
    {
        RaycastHit hit;
        Ray rayo = new Ray(transform.position + Vector3.up * 3 - Vector3.right, Vector3.down);
        if (Physics.Raycast(rayo, out hit))
        {
            if (hit.collider.CompareTag("Aqua"))
            {
                Instantiate(hoja, transform.position - Vector3.right, transform.rotation);
            }
            else if (hit.collider.CompareTag("obstaculo"))
            {
                Destroy(hit.transform.gameObject);
            }
        }

    }
}
