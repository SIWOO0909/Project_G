using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour
{
    public Animator animator; // Animator�� ������ ����

    // ��ư�� Ŭ���� �� ȣ��� �Լ�
    public void AttackAnimation()
    {
        if (animator != null)
        {
            StartCoroutine(PlayAnimationWithDelay());//���� �� �ִϸ��̼� ����
        }
        else
        {
            Debug.LogWarning("Animator�� �������� �ʾҽ��ϴ�.");
        }
    }

    // ���� �ð��� ���� �� �ִϸ��̼��� �����ϴ� �ڷ�ƾ
    private IEnumerator PlayAnimationWithDelay()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetTrigger("Effect");
    }
}
