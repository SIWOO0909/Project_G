using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // 접촉시 PC가 파괴
    //private void OnCollisionEnter(Collision collision) // 충돌
    //{
    //    if(collision.collider.GetComponent<Player>() != null)
    //    {
    //        Destroy(collision.gameObject);
    //    }

    //}
}
