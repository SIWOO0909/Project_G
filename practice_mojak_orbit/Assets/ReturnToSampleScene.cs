using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToSampleScene : MonoBehaviour
{
    // ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    public void ReturnToSampleScenes()
    {
        // SampleScene���� ���� ��ȯ
        SceneManager.LoadScene("SampleScene");
    }
}
