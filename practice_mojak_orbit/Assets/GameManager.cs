using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnClickRestart()
    {
        //ù ����� �������� �ȴ�.
        //GetActiveScene.name�� ���� ���� scene�� �̸��� �޾ƿ´�.
        //LoadScene�� ���� �ش� scene�� �����Ѵ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
