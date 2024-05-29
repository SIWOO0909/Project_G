using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaEffectManager : MonoBehaviour
{
    public ParticleSystem particleSysComp;

    public void GachaEffectStart()
    {
        // ��ƼŬ �ý��� ����
        particleSysComp.Play();

        // ��ƼŬ �ý��� ����
        // particleSysComp.Stop();

        // ��ƼŬ �ý��� �Ͻ�����
        // particleSysComp.Pause();

        // ��ƼŬ �ý��� ���ڰ� ���� 100�� �վ��� ����
        // particleSysComp.Emit(100);
    }

    public void GachaEffectStop()
    {
        // ��ƼŬ �ý��� ����
        particleSysComp.Stop();
    }
}
