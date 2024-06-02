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

    public AudioSource jumpSound;

    public AudioSource ClickSound;
    public AudioSource OutSound;
    public AudioSource PopUpSound;
    public AudioSource Reset;
    public AudioSource PlayBtn;
    public AudioSource LvUpBtn;

    public AudioSource SangJeomBGM; // �����Ҹ�

    public AudioSource Siren; // ���̷� �Ҹ�

    public AudioSource MulSoRi; // �� ÷�� �Ҹ�

    public AudioSource bora;

    static public float ButtonVolume;

    // ���� ���� �� (�κ�)
    public Slider BtnVolumeSlider;
    public Slider MusicVolumeSlider;

    // ���� ������ (�ΰ���)
    public Slider IngameBtnVolumeSlider;
    public Slider IngameMusicVolumeSlider;
    public Slider IngameSirenVolumeSlider; // ���̷�

    public GameObject ClickSoundBug;


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
        jumpSound.volume = btnVolume;
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

        PlayerPrefs.SetFloat("BtnVolume", btnVolume);
    }

    public void SirenVolume(float sirenVolume)
    {
        Siren.volume = sirenVolume;
        PlayerPrefs.SetFloat("SirenVolume", sirenVolume);
    }

    public void LoadVolume()
    {
        // �⺻�� 0.5�� ����Ͽ� ����� ��ư������ �ҷ���
        float BtnSavedVolume = PlayerPrefs.GetFloat("BtnVolume", 0.5f); // ȿ����
        float MusicSavedVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f); // �����
        float SirenSavedVolume = PlayerPrefs.GetFloat("SirenVolume", 0.5f); // ���̷���

        // �ҷ��� ������ ���� // ȿ����
        coinSound.volume = BtnSavedVolume;
        jumpSound.volume = BtnSavedVolume;
        ClickSound.volume = BtnSavedVolume; // ��ư Ŭ����
        OutSound.volume = BtnSavedVolume;
        PopUpSound.volume = BtnSavedVolume;
        Reset.volume = BtnSavedVolume;
        PlayBtn.volume = BtnSavedVolume;
        GameOverSound.volume = BtnSavedVolume;
        LvUpBtn.volume = BtnSavedVolume;
        dead.volume = BtnSavedVolume;

        // �ҷ��� ������ ���� // �����
        LobbyMusicsource.volume = MusicSavedVolume;
        IngameMusicSource.volume = MusicSavedVolume;
        bora.volume = MusicSavedVolume;

        // �ҷ��� ������ ���� // ���̷�
        Siren.volume = SirenSavedVolume;

        // �����̴� ���� �ҷ��� �������� ���� // ȿ����
        if (BtnVolumeSlider != null)
        {
            BtnVolumeSlider.value = BtnSavedVolume;
            IngameBtnVolumeSlider.value = BtnSavedVolume;
        }

        // �����̴� ���� �ҷ��� �������� ���� // �����
        if (BtnVolumeSlider != null)
        {
            MusicVolumeSlider.value = MusicSavedVolume; // �κ�
            IngameMusicVolumeSlider.value = MusicSavedVolume; // �ΰ���
        }

        // �����̴� ���� �ҷ��� �������� ���� // ���̷���
        if (IngameSirenVolumeSlider != null)
        {
            IngameSirenVolumeSlider.value = SirenSavedVolume;//�ΰ���
        }

        // ��ư �Ҹ� �ǳ� ��Ȱ��ȭ
        ClickSoundBug.SetActive(true);
    }

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
        jumpSound.Play();
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
}
