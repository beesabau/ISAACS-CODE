using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f; // player character's default movement speed
    private CharacterController controller; // physics for collision
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite placeholder_Front;
    [SerializeField] private Sprite placeholder_Back;

    private PickupItems item;

    private Vector3 startPosition; // start position

    //public SpriteRenderer spriteRenderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>(); //finds CharacterController component
        startPosition = transform.position; //sets the starting position to be the position the player model/object is currently at

    }

    public void Movement(Vector3 direction)
    {
        controller.Move(direction * movementSpeed * Time.deltaTime);
        if (direction.x < 0) //moving towards camera
        {
            spriteRenderer.sprite = placeholder_Front;
        }
        else if (direction.x > 0) //moving away from camera
        {
            spriteRenderer.sprite = placeholder_Back;
        }
    }

    public void PickUpItem()
    {
        
    }
}
