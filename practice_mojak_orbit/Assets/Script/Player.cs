using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // ���� �� ���ξ���
    // 1
    // 2
    // 3
    // 4
    // 5
    // 6
    // 7
    // 8
    // 9
    [SerializeField] private TerrainGenerator terrainGenerator;
    [SerializeField] private Text scoreText;

    private Animator animator;
    private bool isHopping;
    private int score;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        score++;
    }

    private void Update() // �� �����Ӹ��� ����
    {
        scoreText.text = "Score: " + score;
        if(Input.GetKeyDown(KeyCode.W) && !isHopping) // W ���� ��
        {
            animator.SetTrigger("hop"); // ���ϸ��̼� hop ����
            isHopping = true;
            float zDifference = 0;
            if(transform.position.z % 1 != 0)
            {
                zDifference = Mathf.Round(transform.position.z) - transform.position.z;
            }
            MoveCharacter(new Vector3(1, 0, zDifference));
        }
        else if (Input.GetKeyDown(KeyCode.A) && !isHopping) // A ���� ��
        {
            //transform.position = (transform.position + new Vector3(0, 0, 1)); // �̵�
            MoveCharacter(new Vector3(0, 0, 1)); // �̵�
        }
        else if (Input.GetKeyDown(KeyCode.D) && !isHopping) // D ���� ��
        {
            // transform.position = (transform.position + new Vector3(0, 0, -1)); // �̵�
            MoveCharacter(new Vector3(0, 0, -1)); // �̵�
        }
        else if (Input.GetKeyDown(KeyCode.S) && !isHopping) // S ���� ��
        {
            // transform.position = (transform.position + new Vector3(0, 0, -1)); // �̵�
            MoveCharacter(new Vector3(-1, 0, 0)); // �̵�
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.GetComponent<MovingObject>() != null)
        {
            if (collision.collider.GetComponent<MovingObject>().isLog)
            {
                transform.parent = collision.collider.transform;
            }
        }
        else
        {
            transform.parent = null;
        }
    }

    private void MoveCharacter(Vector3 difference)
    {
        animator.SetTrigger("hop"); // ���ϸ��̼� hop ����
        isHopping = true;
        transform.position = (transform.position + difference);
        terrainGenerator.SpawnTerrain(false, transform.position);
    }

    public void FinishHop()
    {
        isHopping = false;
    }
    
}
