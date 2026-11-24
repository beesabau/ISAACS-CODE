using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour

{

    private GameInputs movementInput;
    private GameInputs menuInput;
    [SerializeField] private PlayerController playerController;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementInput = new GameInputs();
        movementInput.Player.Enable();

        movementInput.Player.Interaction.performed += OnInteraction; // Actions documentation
        movementInput.Player.Talk.performed += OnTalk; // Actions documentation

        menuInput = new GameInputs();
        menuInput.Player.Enable();

        menuInput.Player.Interaction.performed += OnMenu;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = movementInput.Player.Movement.ReadValue<Vector2> ();
        Vector3 direction = new Vector3(input.y, 0, input.x);
        playerController.Movement(direction);
         
    }

    void OnInteraction(InputAction.CallbackContext context) // Action Assets documentation
    {
            playerController.PickUpItem();
    }

    void OnMenu(InputAction.CallbackContext context) // Action Assets documentation
    {
        
    }

    void OnTalk(InputAction.CallbackContext context) // Action Assets documentation
    {
      
    }
}
