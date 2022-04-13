using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button button1, button2, button3, button4, button5, button6, button7, button8, button9, button0;
    public GameObject levelSelectScreen, welcomeScreen;

    public void OnEnable()
    {
        //Register Button Events
        button1.onClick.AddListener(() => SceneManager.LoadScene("Level01"));
        button2.onClick.AddListener(() => SceneManager.LoadScene("Level02"));
        button3.onClick.AddListener(() => SceneManager.LoadScene("Level03"));
        button4.onClick.AddListener(() => SceneManager.LoadScene("Level04"));
        button5.onClick.AddListener(() => SceneManager.LoadScene("Level05"));
        button6.onClick.AddListener(() => SceneManager.LoadScene("Level06"));
        button7.onClick.AddListener(() => SceneManager.LoadScene("Level07"));
        button8.onClick.AddListener(() => SceneManager.LoadScene("Level08"));
        button9.onClick.AddListener(() => SceneManager.LoadScene("Level09"));
        button0.onClick.AddListener(() =>
        {
            levelSelectScreen.SetActive(false);
            welcomeScreen.SetActive(true);
        });
    }
}
