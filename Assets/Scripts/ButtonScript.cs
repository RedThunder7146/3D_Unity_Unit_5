using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public TMP_Text buttonText;
    public GameObject player;

    public void ButtonMethod()
    {
        buttonText.text = "Clicked";
        LevelManager.instance.SetPlayerHealth(5);
        player.transform.position = new Vector3(0, 4, 0);
    }
    public void LoadFrontend()
    {
        SceneManager.LoadScene("Frontend");
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
}
