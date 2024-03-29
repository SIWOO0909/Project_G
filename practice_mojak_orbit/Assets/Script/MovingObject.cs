using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float destructionDelay = 60f; // �ı������� ������
    [SerializeField] private float speed;
    public bool isLog;

    private void Update() // �� �����Ӹ��� ����
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void Start()
    {
        // destructionDelay ���� DestroyObject() �޼ҵ带 ȣ��
        Invoke("DestroyObject", destructionDelay);
    }

    void DestroyObject()
    {
        // �ش� ���� ������Ʈ�� �ı�
        Destroy(gameObject);
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
