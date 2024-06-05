using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public GameObject mainLobbyCanvas; // MainLobby Canvas�� ����
    public Rotate rotateScript; // Rotate ��ũ��Ʈ�� ����

    private void Update()
    {
        // Canvas�� Ȱ��ȭ�Ǿ� �ִ��� Ȯ��
        if (mainLobbyCanvas.activeSelf)
        {
            if (!rotateScript.enabled)
            {
                rotateScript.enabled = true; // Rotate ��ũ��Ʈ Ȱ��ȭ
            }
        }
        else
        {
            if (rotateScript.enabled)
            {
                rotateScript.enabled = false; // Rotate ��ũ��Ʈ ��Ȱ��ȭ
            }
        }
    }
}
