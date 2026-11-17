using UnityEngine;

public class PickupItems : MonoBehaviour

{

    [SerializeField] private string pickupItem = "Item";

    public string PickupItem => pickupItem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickingUp()
    {
        Destroy(gameObject);
    }
}
