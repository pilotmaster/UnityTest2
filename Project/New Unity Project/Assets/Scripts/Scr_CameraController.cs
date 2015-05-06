using UnityEngine;
using System.Collections;

public class Scr_CameraController : MonoBehaviour 
{
	// Reference to the player
	public GameObject mPlayer;
	
	// Offset value from the ball
	private Vector3 mOffset;
	
	
	// Use this for initialization
	void Start () 
	{
		// Calculate the offset amount
		mOffset = transform.position - mPlayer.transform.position;
	}
	
	// Runs after ALL objects have been updated
	void LateUpdate () 
	{
		// Update the position of the camera
		transform.position = mPlayer.transform.position + mOffset;
	}
}
