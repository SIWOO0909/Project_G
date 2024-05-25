using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

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

    // �÷��̾� ���˽� ����ȯ
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.GetComponent<Player>())
    //    {
    //        SceneManager.LoadScene("GameOver");
    //    }

    //}
}
