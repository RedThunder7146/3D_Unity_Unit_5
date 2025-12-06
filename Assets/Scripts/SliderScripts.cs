using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SliderScripts : MonoBehaviour
{

    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider SFXSlider;
    [SerializeField] private AudioMixer MasterVolume;
    [SerializeField] private TextMeshProUGUI musicVol;
    [SerializeField] private TextMeshProUGUI SFXVol;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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


    }
    public void SetMusicVolume()
    {
        float mVolume = musicSlider.value;
        MasterVolume.SetFloat("music", Mathf.Log10(mVolume)*20);
        PlayerPrefs.SetFloat("musicVolume", mVolume);

        musicVol.text = mVolume.ToString("0%");
    }

    public void SetSFXVolume()
    {
        float sfxVolume = SFXSlider.value;
        MasterVolume.SetFloat("SFX", Mathf.Log10(sfxVolume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);

        SFXVol.text = sfxVolume.ToString("0%");
    }


    public void LoadMusicVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");

        SetMusicVolume();

    }

    public void LoadSFXVolume()
    {
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");

        SetSFXVolume();
    }


}
