using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenuController : MonoBehaviour
{
    public TMP_InputField playerNameTMP;
    public string playerNameText;
    void Update()
    {
        playerNameText = playerNameTMP.text;
    }

    public void StartGame()
    {
        GameManager.instance.SetName(playerNameText);
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
