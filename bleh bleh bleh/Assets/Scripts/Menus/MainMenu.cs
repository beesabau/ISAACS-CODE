using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame() // to load the game scene
    {
        SceneManager.LoadScene("Bar");
    }

    public void LoadSettings() // to load the game scene
    {
        SceneManager.LoadScene("MenuSettings");
    }

    public void LoadCredits() // to load the game scene
    {
        SceneManager.LoadScene("MenuCredits");
    }

    public void QuitGame() // to load the game scene
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
