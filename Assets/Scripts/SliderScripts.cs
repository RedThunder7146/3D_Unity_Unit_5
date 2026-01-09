using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.TerrainTools;

public class SliderScripts : MonoBehaviour
{
    [Header("---- AUDIO MIXER ----")]

    [SerializeField] private AudioMixer MasterVolume;
    [Header("---- MASTER VOLUME ----")]

    [SerializeField] private Slider masterSlider;
    [SerializeField] private TextMeshProUGUI masterVol;
    [Header("---- MUSIC VOLUME ----")]

    [SerializeField] private Slider musicSlider;
    [SerializeField] private TextMeshProUGUI musicVol;
    [Header("---- SFX VOLUME ----")]

    [SerializeField] private Slider SFXSlider;
    [SerializeField] private TextMeshProUGUI SFXVol;
    [Header("---- Mute Button ----")]

    [SerializeField] private Toggle muteMusic; 

    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadMusicVolume();
        }
        else
        {
            SetMusicVolume();
        }
        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            LoadSFXVolume();
        }
        else
        {
            SetSFXVolume();
        }

        if (PlayerPrefs.HasKey("masterVolume"))
        {
            LoadMasterVolume();
        }
        else
        {
            SetMasterVolume();
        }
        
        

    }
    public void SetMusicVolume()
    {
        float mVolume = musicSlider.value;
        MasterVolume.SetFloat("music", Mathf.Log10(mVolume)*20);
        PlayerPrefs.SetFloat("musicVolume", mVolume);

        musicVol.text = mVolume.ToString("0%");
        muteMusic.isOn = false;
    }

    public void SetSFXVolume()
    {
        float sfxVolume = SFXSlider.value;
        MasterVolume.SetFloat("SFX", Mathf.Log10(sfxVolume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);

        SFXVol.text = sfxVolume.ToString("0%");
    }

    public void SetMasterVolume()
    {
        float masterVolume = masterSlider.value;
        MasterVolume.SetFloat("Master", Mathf.Log10(masterVolume) * 20);
        PlayerPrefs.SetFloat("masterVolume", masterVolume);
        masterVol.text = masterVolume.ToString("0%");
    }


    public void LoadMusicVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        MasterVolume.SetFloat("music", Mathf.Log10(PlayerPrefs.GetFloat("musicVolume")) * 20);
        SetMusicVolume();

    }

    public void LoadSFXVolume()
    {
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        MasterVolume.SetFloat("SFX", Mathf.Log10(PlayerPrefs.GetFloat("SFXVolume")) * 20);
        SetSFXVolume();
    }
    public void LoadMasterVolume()
    {
        masterSlider.value = PlayerPrefs.GetFloat("masterVolume");
        MasterVolume.SetFloat("Master", Mathf.Log10(PlayerPrefs.GetFloat("masterVolume")) * 20);
        SetMasterVolume();
    }

    public void MuteMusic()
    {

        float music = PlayerPrefs.GetFloat("musicVolume");

        if(muteMusic.isOn == true)
        {
            MasterVolume.SetFloat("music", Mathf.Log10(0.0001f) * 20);
        }
        else
        {
            MasterVolume.SetFloat("music", Mathf.Log10(music) * 20);
        }

    }

}