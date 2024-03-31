using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectSpawner1 : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject; // �� ����
    [SerializeField] private Transform spawnPos; // �� ���� ��ǥ
    [SerializeField] private float minSeparationTime; // �ּ� �ð�
    [SerializeField] private float maxSeparationTime; // �ִ� �ð�
    [SerializeField] private bool isRightSide;

    private void Start()
    {
        StartCoroutine(SpawnVehicle());
    }

    private IEnumerator SpawnVehicle() // �� ������
    {
        while (true) // �ݺ� �����
        {
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime)); // ���� ������������ �� ��ȯ
            GameObject go = Instantiate(spawnObject, spawnPos.position, Quaternion.identity);
            if (!isRightSide)
            {
                go.transform.Rotate(new Vector3(0, 180, 0));
            }
        }
    }
}
