using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] private float speed;
    public bool isLog;

    private void Update() // �� �����Ӹ��� ����
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // ���˽� PC�� �ı�
    //private void OnCollisionEnter(Collision collision) // �浹
    //{
    //    if(collision.collider.GetComponent<Player>() != null)
    //    {
    //        Destroy(collision.gameObject);
    //    }
            
    //}
}
