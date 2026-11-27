using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour

{
    private GameInputs movementInput;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private PauseMenu pauseMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementInput = new GameInputs();
        movementInput.Player.Enable();

        movementInput.Player.Interaction.performed += OnInteraction; // Actions documentation
        movementInput.Player.Talk.performed += OnTalk; // Actions documentation
        movementInput.Player.Menus.performed += OnMenu;
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseMenu != null && pauseMenu.GameIsPaused) return;

        Vector2 input = movementInput.Player.Movement.ReadValue<Vector2>();
        Vector3 direction = new Vector3(input.y, 0, input.x);
        playerController.Movement(direction);
    }

    private void OnDestroy()
    {
        if (movementInput != null)
        {
            movementInput.Player.Interaction.performed -= OnInteraction;
            movementInput.Player.Talk.performed -= OnTalk;
            movementInput.Player.Menus.performed -= OnMenu;
        }
    }

    void OnMenu(InputAction.CallbackContext context) // Action Assets documentation
    {
        pauseMenu.TogglePause();
    }

    void OnInteraction(InputAction.CallbackContext context)
    {
        if (pauseMenu != null && pauseMenu.GameIsPaused) return; // pauses game when game is paused; i don't think this is necessary but literally who cares anymore
        playerController.PickUpItem();
    }

    void OnTalk(InputAction.CallbackContext context) // Action Assets documentation
    {
        if (pauseMenu != null && pauseMenu.GameIsPaused) return; // pauses game when game is paused; i think this one is necessary but, once again, who cares
    }
}
