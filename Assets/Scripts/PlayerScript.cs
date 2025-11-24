using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float hSensitivity;
    public float vSensitivity;
    public Rigidbody playerRB;
    public float xvel;
    public float zvel;
    public float yvel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LevelManager.instance.SetPlayerHealth(5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRB.linearVelocity = Vector3.forward*zvel;
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRB.linearVelocity = -Vector3.forward * zvel;
        }
        if(Input.GetKey(KeyCode.A))
        {
            playerRB.linearVelocity = -Vector3.right * xvel;
        }
        if(Input.GetKey(KeyCode.D))
        {
            playerRB.linearVelocity = Vector3.right * xvel;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.linearVelocity = Vector3.up * yvel;
        }


        float h = hSensitivity * Input.GetAxis("Mouse X");
        float v = vSensitivity * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);


    }

    private void OnGUI()
    {
        int playerHealth = LevelManager.instance.GetPlayerHealth();

        string text = "Player health: " + playerHealth;


        GUI.contentColor = Color.white;
        GUILayout.BeginArea(new Rect(10f, 10f, 1600f, 1600f));
        GUILayout.Label($"<size=24>{text}</size>");
        GUILayout.EndArea();
    }


}
