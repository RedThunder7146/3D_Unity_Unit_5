using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance;
    private int highScore;
    private int playerHealth;
    private int playerScore;

    void Awake()
    {
        if (instance == null)
        {
            // if instance is null, store a reference to this instance
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("do not destroy");
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            print("do destroy");
            Destroy(gameObject);
        }
    }

    public void SetPlayerHealth(int pHealth)
    {
        playerHealth = pHealth;
    }
    public void AddPlayerHealth(int pHealthDep)
    {
        playerHealth -= pHealthDep;
    }
    public int GetPlayerHealth()
    {
        return playerHealth;
    }
    public void SetPlayerScore(int score)
    {
        playerScore = score;
    }
    public void AddPlayerScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
    }
    public int GetPlayerScore()
    {
        return playerScore;
    }

}
