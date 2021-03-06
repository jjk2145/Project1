﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public GameObject PlayerBullet;
	public GameObject BulletPosition;


	public float speed = 10.0f;
	
	void Update ()
	{
		if (Input.GetKeyDown ("space")) {

			GameObject bul = (GameObject)Instantiate (PlayerBullet);
			bul.transform.position = BulletPosition.transform.position;

		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}
}
