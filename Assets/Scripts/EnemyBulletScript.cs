﻿using UnityEngine;
using System.Collections;

public class EnemyBulletScript : MonoBehaviour {
	public float speed = 1f;
	public Vector3 targetPos;
	bool left = false;
	bool up = false;
	// Use this for initialization
	void Start () {
		if (targetPos.y < transform.position.y) {
			//targetPos.y = targetPos.y * -1;
			speed = -speed;
		}
		//2D Equivalent to LookAt();
		Quaternion rotation = Quaternion.LookRotation
			(targetPos - transform.position, transform.TransformDirection(Vector3.up));
		transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

		Destroy(gameObject, 5f);

	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (transform.up * speed * Time.deltaTime * - 1);

	}
}
