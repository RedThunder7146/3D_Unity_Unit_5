using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.TerrainTools;
public class ButtonScript : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject volumeMenu;
    public GameObject quitMenu;
    public GameObject videoSettingsMenu;
    public Toggle fullscreen;


    void Start()
    {
        MainMenu();
        Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
    }
    public void LoadFrontend()
    {
        SceneManager.LoadScene("Frontend");
        AudioManager.instance.PlaySoundEffect("Button");
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("Level1");

    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("Level 2");

    }
    public void Score()
    {
        LevelManager.instance.AddPlayerScore(1);

    }

    public void OptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
        volumeMenu.SetActive(false);
        quitMenu.SetActive(false);
        videoSettingsMenu.SetActive(false);
    }


    public void MainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        volumeMenu.SetActive(false);
        quitMenu.SetActive(false);
        videoSettingsMenu.SetActive(false);

    }

    public void QuitMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        quitMenu.SetActive(true);
        volumeMenu.SetActive(false);
        videoSettingsMenu.SetActive(false);

    }

    public void VolumeMenu()
    {
        volumeMenu.SetActive(true);
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        quitMenu.SetActive(false);
        videoSettingsMenu.SetActive(false);
    }
    public void VideoSettingsMenu()
    {
        volumeMenu.SetActive(false);
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        quitMenu.SetActive(false);
        videoSettingsMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void SFX()
    {
        AudioManager.instance.PlaySoundEffect("Button");
    }

    public void fullScreenMode()
    {
        if (fullscreen.isOn == true)
        {
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            print("Is fullscreened");
        }
        else
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
            print("Is not fullscreened");
        }
    }
    
}
