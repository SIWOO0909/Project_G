using UnityEngine;

public class Show : MonoBehaviour
{
    // Ȱ��ȭ�� ������Ʈ�� �巡�� �� ������� �Ҵ��� �� �ְԲ� public���� �����մϴ�.
    public GameObject objectToActivate;

    // ���� ������Ʈ�� ��Ȱ��ȭ�� �� ȣ��˴ϴ�.
    private void OnDisable()
    {
        // Ȱ��ȭ�� ������Ʈ�� null�� �ƴ��� Ȯ���մϴ�.
        if (objectToActivate != null)
        {
            // ������ ������Ʈ�� Ȱ��ȭ�մϴ�.
            objectToActivate.SetActive(true);
        }
        else
        {
            Debug.LogWarning("objectToActivate�� �Ҵ���� �ʾҽ��ϴ�.");
        }
    }
}
