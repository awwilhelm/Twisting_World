using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public int playerID;
    private float movementSpeed = 0.2f;
    private float jumpSpeed = 8;
    private float gravity = 20;

    private Vector3 moveDirection = Vector3.zero;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        CharacterController controller = GetComponent<CharacterController>();

        if (InputManager.Horizontal(playerID) != 0)
        {
            transform.position = new Vector3(transform.position.x + InputManager.Horizontal(playerID) * movementSpeed, transform.position.y, transform.position.z);
        }

        if(InputManager.Jump(playerID))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10);
        }


    }
}
