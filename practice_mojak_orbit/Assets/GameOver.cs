using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    // // �ð��� ���߸� ���ӿ���������
    //void Update()
    //{
    //    if (Time.timeScale == 0)
    //    {
    //        SceneManager.LoadScene("GameOver");
    //    }

    //}


    // ���� �浹�� ���ӿ���������
    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ��ü�� carro �±׸� ������ �ִ��� Ȯ��
        if (collision.collider.CompareTag("carro"))
        {
            Debug.Log("���� �浹�Ͽ����ϴ�.");

            // carro �±׸� ���� ��ü�� �浹�� ��쿡�� GameOverScene���� ��ȯ
            // SceneManager.LoadScene("GameOver");
        }
    }

}
