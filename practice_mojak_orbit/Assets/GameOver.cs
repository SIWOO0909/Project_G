using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    // // 시간이 멈추면 게임오버씬으로
    //void Update()
    //{
    //    if (Time.timeScale == 0)
    //    {
    //        SceneManager.LoadScene("GameOver");
    //    }

    //}


    // 적과 충돌시 게임오버씬으로
    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 객체가 carro 태그를 가지고 있는지 확인
        if (collision.collider.CompareTag("carro"))
        {
            Debug.Log("적과 충돌하였습니다.");

            // carro 태그를 가진 객체와 충돌한 경우에만 GameOverScene으로 전환
            // SceneManager.LoadScene("GameOver");
        }
    }

}
