using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float horizontalSpeed;
	public float verticalSpeed;
	public float laneRange;
	public float bottomLaneLowPoint;
	public float topLaneLowPoint;

	private float laneLowPoint;
	private Vector2 playerForce;
	private Vector2 startingPosition;
	//private float yPos;
	private bool inBottomlane;
	private float health;

	// Use this for initialization
	void Start () {
		playerForce = new Vector2 (0, 0);
		startingPosition = rigidbody2D.position;
		health = 5;
		inBottomlane = true;
		laneLowPoint = bottomLaneLowPoint;
	
	}
	
	// Update is called once per frame
	void Update () {




		rigidbody2D.velocity = Vector2.zero;

		playerForce.Set (0.0f, 0.0f);
		if(Input.GetKey(KeyCode.UpArrow)||Input.GetKey (KeyCode.W)){
			if(rigidbody2D.position.y<laneLowPoint+laneRange){
				playerForce.y += verticalSpeed;
			}
		}
		if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey (KeyCode.S)){
			if(rigidbody2D.position.y>laneLowPoint){
				playerForce.y -= verticalSpeed;
			}
		}
		if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey (KeyCode.A)){

			playerForce.x -= horizontalSpeed;
		}
		if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey (KeyCode.D)){
			playerForce.x += horizontalSpeed;
		}
		rigidbody2D.AddForce (playerForce);


	
	}

	void OnTriggerEnter2D(Collider2D other){
		/** Adjust world speed when Player and crash Edge crash
		 */
		if (other.tag == "passEdge") {
			if(inBottomlane){
				rigidbody2D.MovePosition(new Vector2(rigidbody2D.position.x+.750f, topLaneLowPoint));
				other.audio.Play();
				inBottomlane = false;
				laneLowPoint = topLaneLowPoint;
			}
			else{
				rigidbody2D.MovePosition(new Vector2(rigidbody2D.position.x+.750f, bottomLaneLowPoint+laneRange));
				other.audio.Play ();
				inBottomlane = true;
				laneLowPoint = bottomLaneLowPoint;

			}

		}
		else if(other.tag == "crashEdge") {
			if(inBottomlane){
				other.audio.Play();
				health--;
				rigidbody2D.MovePosition(new Vector2(rigidbody2D.position.x, -0.27f));
			}
			else {
				other.audio.Play ();
				health--;
				rigidbody2D.MovePosition(new Vector2(rigidbody2D.position.x, 0.28f));
			}
		
		} 
		/*
		else if (other.tag == "hazard") {
			Destroy (other);
			health--;
		}*/
	}

	void OnDisable(){
		rigidbody2D.position = startingPosition;
	}
}
