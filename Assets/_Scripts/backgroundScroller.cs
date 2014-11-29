using UnityEngine;
using System.Collections;

public class backgroundScroller : MonoBehaviour {

	public float scrollSpeed;

	private Vector2 savedOffset;


	// Use this for initialization
	void Start () {

		savedOffset = renderer.sharedMaterial.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {

		float x = Mathf.Repeat (Time.time*scrollSpeed, 6);
		Vector2 scrollOffset = new Vector2(x, savedOffset.y);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", scrollOffset); 

	
	}

	void OnDisable (){
	
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", savedOffset);


	}
}
