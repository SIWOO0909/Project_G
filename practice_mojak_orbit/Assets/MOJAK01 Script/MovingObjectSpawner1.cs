using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectSpawner1 : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject; // 차 종류
    [SerializeField] private Transform spawnPos; // 차 생성 좌표
    [SerializeField] private float minSeparationTime; // 최소 시간
    [SerializeField] private float maxSeparationTime; // 최대 시간
    [SerializeField] private bool isRightSide;

    private void Start()
    {
        StartCoroutine(SpawnVehicle());
    }

    private IEnumerator SpawnVehicle() // 차 생성기
    {
        while (true) // 반복 실행기
        {
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime)); // 각각 랜덤간격으로 차 소환
            GameObject go = Instantiate(spawnObject, spawnPos.position, Quaternion.identity);
            if (!isRightSide)
            {
                go.transform.Rotate(new Vector3(0, 180, 0));
            }
        }
    }
}
