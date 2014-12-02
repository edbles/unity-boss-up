using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float horizontalSpeed;
	public float verticalSpeed;

	private Vector2 playerForce;
	private Vector2 startingPosition;

	// Use this for initialization
	void Start () {
		playerForce = new Vector2 (0, 0);
		startingPosition = rigidbody2D.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = Vector2.zero;
		playerForce.Set (0.0f, 0.0f);
		if(Input.GetKey(KeyCode.UpArrow)||Input.GetKey (KeyCode.W)){
			playerForce.y += verticalSpeed;
		}
		if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey (KeyCode.S)){
			playerForce.y -= verticalSpeed;
		}
		if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey (KeyCode.A)){
			playerForce.x -= horizontalSpeed;
		}
		if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey (KeyCode.D)){
			playerForce.x += horizontalSpeed;
		}
		rigidbody2D.AddForce (playerForce);


	
	}

	void OnDisable(){
		rigidbody2D.position = startingPosition;
	}
}
