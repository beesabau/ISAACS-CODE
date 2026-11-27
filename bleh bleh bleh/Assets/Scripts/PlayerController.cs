using UnityEngine;
using System.Collections.Generic; // why isn't this included by default anymore :(

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f; // player character's default movement speed
    private CharacterController controller; // physics for collision
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite placeholder_Front;
    [SerializeField] private Sprite placeholder_Back;

    [SerializeField] private List<string> inventory = new List<string>(); // list for items in inventory; string for characters as opposed to int for numbers. please don't mix them up
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
        if (item != null)
        {
            inventory.Add(item.PickupItem);
            item.PickingUp(); // from PickupItems script. is there a reason why i'm not just destroying the item in this script? idk. we'll see
            item = null; // turn that thing offfff
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PickupItems collectibleItem)) // checks if item has PickupItems script; puts it into collectibleItem temporarily
        {
            item = collectibleItem;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out PickupItems collectibleItem)) // checks if item has PickupItems script and nulls it once player exits collider
        {
            item = null;
        }
    }
}
