using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject volumeMenu;
    public GameObject quitMenu;
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
    }


    public void MainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        volumeMenu.SetActive(false);
        quitMenu.SetActive(false);

    }

    public void QuitMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        quitMenu.SetActive(true);
        volumeMenu.SetActive(false);

    }

    public void VolumeMenu()
    {
        volumeMenu.SetActive(true);
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        quitMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void SFX()
    {
        AudioManager.instance.PlaySoundEffect("Button");
    }

}
