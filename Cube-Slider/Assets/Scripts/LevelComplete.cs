using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public Button button1, button2;

    private void OnEnable()
    {
        button1.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
        button2.onClick.AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
}
