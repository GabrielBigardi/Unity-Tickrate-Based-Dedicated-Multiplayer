using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject startMenu;
    public TMPro.TMP_InputField usernameField;
    public TMPro.TMP_Text connectionStatusText;
    public Button connectButton;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    /// <summary>Attempts to connect to the server.</summary>
    public void ConnectToServer()
    {
        DatabaseManager.Instance.connectingGameEvent?.Invoke();
        usernameField.interactable = false;
        connectButton.interactable = false;
        Client.instance.ConnectToServer();
        //startMenu.SetActive(false);
    }
}
