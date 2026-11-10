using UnityEditor;
using UnityEngine;

public class PlayerInputReader : MonoBehaviour

{

    private GameInputs movementInput;
    [SerializeField] private PlayerController playerController;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementInput = new GameInputs();
        movementInput.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = movementInput.Player.Movement.ReadValue<Vector2> ();
        Vector3 direction = new Vector3(input.y, 0, input.x);
        playerController.Movement(direction);
         
    }
}
