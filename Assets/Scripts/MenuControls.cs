using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public void StartPressed()
    {
        SceneManager.LoadScene("0");
    }
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed");
    }
}
