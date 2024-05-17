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

    public void ReturnToMainLobby()
    {
        SceneManager.LoadScene("MainLobby");
    }

    public void ReturnToRanking()
    {
        SceneManager.LoadScene("Ranking");
    }

    public void ReturnToSkin()
    {
        SceneManager.LoadScene("Skin");
    }

    public void ReturnToStore()
    {
        SceneManager.LoadScene("Store");
    }
}
