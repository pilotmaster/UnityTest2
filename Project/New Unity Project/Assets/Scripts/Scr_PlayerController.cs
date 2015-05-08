using UnityEngine;
using System.Collections;

public class Scr_PlayerController : MonoBehaviour
{
	// Movement variables - public variables show up in editor
	public float mSpeed;
	public GUIText mCountText;
	public GUIText mWinText;
	public int mNumPickUps;
	
	// Variables to hold references to Game Object components
	private Rigidbody mRigidBody;
	
	// Tracking number of collected pickups
	private int mCount;
	
	// Called when initialising the game object
	void Start()
	{
		// Need to get a handle to the RigidBody component
		mRigidBody = GetComponent<Rigidbody>();
		
		// Initialise count value & count text
		mCount = 0;
		SetCountText();
		mWinText.text = "";
	}
	
	// Called before rendering a frame
	void Update()
	{
		
	}
	
	// Physics code goes in here - called before draw scene / render frame
	void FixedUpdate()
	{
		// Get the horizontal & verticel axis of the ball
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		// Determine movement vector
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		
		// Add a force in the given direction
		mRigidBody.AddForce(movement * mSpeed);
	}
	
	// Triggers when the player object collides with a *trigger* object (pickups)
	void OnTriggerEnter(Collider other)
	{
		// Remove the object it has collided with
		//Destroy (other.gameObject);
		
		// Deactivate pickup objects when collided with & increment count
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);
			mCount++;
			SetCountText();
		}
	}
	
	// Update the counter text
	void SetCountText()
	{
		mCountText.text = "Count: " + mCount.ToString();
		if (mCount >= mNumPickUps)
		{
			mWinText.text = "You Win!";
		}
	}
}
