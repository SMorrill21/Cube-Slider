using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI, endlessGameOverUI;
    public Button button1, button2;

    private void OnEnable()
    {
        button1.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
        button2.onClick.AddListener(() => SceneManager.LoadScene("Endless"));
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false && SceneManager.GetActiveScene().name != "Endless")
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
        else if (gameHasEnded == false && SceneManager.GetActiveScene().name == "Endless")
        {
            endlessGameOverUI.SetActive(true);
            gameHasEnded = true;
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
