using UnityEngine;

public class PlayerInputReader : MonoBehaviour

{

    private GameInputs movementInput;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementInput = new GameInputs();
        movementInput.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
