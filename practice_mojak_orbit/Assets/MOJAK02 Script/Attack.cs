using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public float cooltime = 5f;
    public Collider hit;
    public Text text;
    bool isOn;

    public void Hit()
    {
        if (!isOn)
            StartCoroutine("ColliderOn");
    }

    IEnumerator ColliderOn()
    {
        hit.enabled = true;
        yield return new WaitForSeconds(0.01f);
        hit.enabled = false;
        StartCoroutine("CoolDown");
    }


    IEnumerator CoolDown()
    {
        isOn = true;
        float delay = 0f;
        while(delay < cooltime)
        {
            delay += Time.deltaTime;
            text.text = delay.ToString();
            yield return new WaitForSeconds(Time.deltaTime);
        }
        isOn = false;
    }
}
