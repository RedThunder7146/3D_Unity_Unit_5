using TMPro;
using UnityEngine;

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
}
