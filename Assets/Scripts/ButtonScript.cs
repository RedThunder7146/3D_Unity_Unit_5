using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public void LoadFrontend()
    {
        SceneManager.LoadScene("Frontend");
        AudioManager.instance.PlaySoundEffect("Button");
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("Level1");
        AudioManager.instance.PlaySoundEffect("Button");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("Level 2");
        AudioManager.instance.PlaySoundEffect("Button");
    }
    public void Score()
    {
        LevelManager.instance.AddPlayerScore(1);
        AudioManager.instance.PlaySoundEffect("Button");
    }

    public void OptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }


    public void MainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }


}
