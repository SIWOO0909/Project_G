using UnityEngine;

public class AnotherScript : MonoBehaviour
{
    // DestroyExternalObject ��ũ��Ʈ�� ���� ����
    public DestroyExternalObject destroyManager;

    private void Update()
    {
        // ������ ���ǿ��� ���� ������Ʈ�� �ı� (��: �����̽� Ű�� ������ ��)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            destroyManager.DestroyTargetObject();
        }
    }
}