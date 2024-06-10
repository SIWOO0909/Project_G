using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource LobbyMusicsource;
    public AudioSource IngameMusicSource;

    public AudioSource dead;

    public AudioSource GameOverSound;

    public AudioSource coinSound;

    public AudioSource attack;

    //public AudioSource ChumBeong;

    public AudioSource FootSound;

    public AudioSource ClickSound;
    public AudioSource OutSound;
    public AudioSource PopUpSound;
    public AudioSource Reset;
    public AudioSource PlayBtn;
    public AudioSource LvUpBtn;

    public AudioSource PamPhaRe;

    public AudioSource SangJeomBGM; // �����Ҹ�

    public AudioSource Siren; // ���̷� �Ҹ�

    public AudioSource MulSoRi; // �� ÷�� �Ҹ�

    public AudioSource bora;

    static public float ButtonVolume;



    // ���� ������ (�ΰ���)
    public Slider IngameMusicVolumeSlider;
    public Slider IngameBtnVolumeSlider;
    public Slider IngameFootVolumeSlider; // �߼Ҹ�
    public Slider IngameSirenVolumeSlider; // ���̷� �Ҹ�


    public void Start()
    {
        LoadVolume();
    }


    // ������� ����
    public void SetMusicVolume(float volume) 
    {  
        LobbyMusicsource.volume = volume;
        IngameMusicSource.volume = volume;
        bora.volume = volume;
        SangJeomBGM.volume = volume;

        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    // ȿ���� ����
    public void SetButtonVolume(float btnVolume)
    {
        coinSound.volume = btnVolume;
        ClickSound.volume = btnVolume; // ��ư Ŭ����
        OutSound.volume = btnVolume;
        PopUpSound.volume = btnVolume;
        Reset.volume = btnVolume;
        PlayBtn.volume = btnVolume;
        GameOverSound.volume = btnVolume;
        LvUpBtn.volume = btnVolume;
        dead.volume = btnVolume;
        MulSoRi.volume = btnVolume;
        attack.volume = btnVolume;
        PamPhaRe.volume = btnVolume;

        PlayerPrefs.SetFloat("BtnVolume", btnVolume);
    }

    // �߼Ҹ� ����
    public void FootVolume(float footVolume)
    {
        FootSound.volume = footVolume; // �߼Ҹ�
        PlayerPrefs.SetFloat("FootVolume", footVolume);
    }

    // ���̷� �Ҹ� ����
    public void SirenVolume(float sirenVolume)
    {
        Siren.volume = sirenVolume;
        PlayerPrefs.SetFloat("SirenVolume", sirenVolume);
    }

    public void LoadVolume()
    {
        // �⺻�� 0.5�� ����Ͽ� ����� ��ư������ �ҷ���
        float MusicSavedVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f); // �����
        float BtnSavedVolume = PlayerPrefs.GetFloat("BtnVolume", 0.5f); // ȿ����
        float FootSavedVolume = PlayerPrefs.GetFloat("FootVolume", 0.5f); // �߼Ҹ�
        float SirenSavedVolume = PlayerPrefs.GetFloat("SirenVolume", 0.5f); // ���̷��Ҹ�

        // ����� ����
        if (IngameMusicVolumeSlider != null)
        {
            IngameMusicVolumeSlider.value = MusicSavedVolume;
        }

        // ȿ���� ����
        if (IngameBtnVolumeSlider != null)
        {
            IngameBtnVolumeSlider.value = BtnSavedVolume;
        }

        // �߼Ҹ� ����
        if (IngameFootVolumeSlider != null)
        {
            IngameFootVolumeSlider.value = FootSavedVolume;
        }

        // ���̷� �Ҹ� ����
        if (IngameSirenVolumeSlider != null)
        {
            IngameSirenVolumeSlider.value = SirenSavedVolume;
        }
    }


    #region ���� ���
    // ���ݻ���
    public void attackSound()
    {
        attack.Play();
    }

    public void CoinBtnSound()
    {
       coinSound.Play();
    }

    public void JumpSound()
    {
        FootSound.Play();
    }

    public void ClickBtnSound()
    {
        ClickSound.Play();
    }

    public void OutBtnSound()
    {
        OutSound.Play();
    }

    public void PopUpBtnSound()
    {
        PopUpSound.Play();
    }

    public void ResetBtnSound()
    {
        Reset.Play();
    }

    public void PlayBtnSound()
    {
        PlayBtn.Play();
    }

    public void StopIngameBgm()
    {
        IngameMusicSource.Pause();
    }

    public void StartBgm()
    {
        IngameMusicSource.Play();
    }

    public void LvUpBgm()
    {
        LvUpBtn.Play();
    }
    #endregion
}
