using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;
    private GameInputs menuInput;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        menuInput = new GameInputs();
        menuInput.Player.Enable();

        menuInput.Player.Interaction.performed += OnMenu;

        /* if (InputSystem.Keyboard.current.spaceKey.isPressed)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }*/

        void OnMenu(InputAction.CallbackContext context) // Action Assets documentation
        {

        }

        void Resume()
        {
            GameIsPaused = false;
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }

        void Pause()
        {
            GameIsPaused = true;
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}
