using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f; // player character's default movement speed
    private CharacterController controller; // physics for collision
    private Vector3 startPosition; // start position

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>(); //finds CharacterController component
        startPosition = transform.position; //sets the starting position to be the position the player model/object is currently at

    }

    public void Movement(Vector3 direction)
    {
        controller.Move(direction * movementSpeed * Time.deltaTime);
    }
}
