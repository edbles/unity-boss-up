using UnityEngine;
using System.Collections;

public class Stair : MonoBehaviour {
	public float stairSpeed;

	private GameController gameController;
	//private Vector3 startPosition;
	private Vector2 stairVectorSpeed;

	// Use this for initialization
	void Start () {

		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		stairSpeed = gameController.worldSpeed;
		stairVectorSpeed = new Vector2(-stairSpeed, 0);
		rigidbody2D.velocity = stairVectorSpeed;
	
	}
	
	// Update is called once per frame
	void Update () {



	}
}
