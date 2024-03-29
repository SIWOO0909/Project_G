using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] private float speed;
    public bool isLog;

    private void Update() // 매 프레임마다 실행
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
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
