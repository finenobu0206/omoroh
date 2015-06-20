using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public GameObject  g;
	public GameObject  player;
	public GameObject  bakudan;

	public float x;
	public float y;
	public float z;


	// Use this for initialization
	void Start () {
		g = GameObject.Find("test1");
		Debug.Log( g.transform.position );
//		Destroy(g, 15.0f);

//		bakudan = GameObject.Find("bomb");

	}
	
	// Update is called once per frame
	void Update () {
		g.transform.Rotate (0, 10, 0);

		if (Input.GetKeyDown (KeyCode.Space)) {

			player = GameObject.Find("ThirdPersonController");
			x = player.transform.localPosition.x;
			y = player.transform.localPosition.y;
			z = player.transform.localPosition.z;
//			Instantiate(Resources.Load("bomb"),new Vector3(x, y, z), Quaternion.identity) ;

			GameObject bakudan = Instantiate(Resources.Load("bomb"),new Vector3(x, y, z), Quaternion.identity) as GameObject;
			Destroy(bakudan, 3); 

	//		GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
	//		sphere.transform.position = new Vector3(x, y, z);
		}
	}
} 	 
