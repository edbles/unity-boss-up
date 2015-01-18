using UnityEngine;
using System.Collections;

public class objectScroller : MonoBehaviour {

	private float scrollSpeed;
	private GameController gameController;
	private Vector2 startPosition;
	private float endPositionX;



	// Use this for initialization
	void Start () {
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		scrollSpeed = gameController.worldSpeed;
		startPosition = new Vector2(5.9f, 0);
		//rigidbody2D.position = startPosition;
		rigidbody2D.velocity = new Vector2 (-scrollSpeed, 0);
		endPositionX = -5.9f;
	}
	
	// Update is called once per frame
	void Update () {

		if (this.transform.rigidbody2D.position.x < endPositionX) {
			this.transform.rigidbody2D.position = startPosition;

		}

	
	}

	void OnDisable (){
	



	}
}
