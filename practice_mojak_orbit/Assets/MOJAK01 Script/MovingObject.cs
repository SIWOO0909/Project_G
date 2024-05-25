using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class MovingObject : MonoBehaviour
{
    public float destructionDelay = 60f; // 파괴까지의 딜레이
    [SerializeField] private float speed;
    public bool isLog;

    private void Update() // 매 프레임마다 실행
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }

    

    void Start()
    {
        // destructionDelay 이후 DestroyObject() 메소드를 호출
        Invoke("DestroyObject", destructionDelay);
    }

    void DestroyObject()
    {
        // 해당 게임 오브젝트를 파괴
        Destroy(gameObject);
    }

    // 플레이어 접촉시 씬전환
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.GetComponent<Player>())
    //    {
    //        SceneManager.LoadScene("GameOver");
    //    }

    //}
}
