using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button levelSelect, endlessRunner;

    public GameObject welcomeScreen, levelSelectScreen;

    private void Start()
    {
        //welcomeScreen = GameObject.Find("Welcome Screen Canvas");
        //levelSelectScreen = GameObject.Find("Level Select Canvas");

        welcomeScreen.SetActive(true);
        levelSelectScreen.SetActive(false);
    }

    private void OnEnable()
    {
        levelSelect.onClick.AddListener(() => 
        {
            welcomeScreen.SetActive(false);
            levelSelectScreen.SetActive(true);
        });

        endlessRunner.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Endless");
        });
    }

    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
