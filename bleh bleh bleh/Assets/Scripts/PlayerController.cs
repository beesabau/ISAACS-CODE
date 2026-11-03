using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f; // player character's default movement speed
    private Rigidbody rb; // physics for collision
    private Vector3 startPosition; // start position

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //finds RigidBody component
        startPosition = transform.position; //sets the starting position to be the position the player model/object is currently at

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector3(-movementSpeed, rb.linearVelocity.y); //moves left when A is pressed
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector3(movementSpeed, rb.linearVelocity.y); //moves right when D is pressed
        }
        else
        {
            rb.linearVelocity = new Vector3(0, rb.linearVelocity.y); //doesn't move if nothing is pressed
        }
    }
}
