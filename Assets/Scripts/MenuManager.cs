using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.instance.PlayMusic("MenuTheme");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
