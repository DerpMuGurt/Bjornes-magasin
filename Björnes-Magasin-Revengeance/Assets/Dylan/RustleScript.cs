using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RustleScript : MonoBehaviour
{
	Vector3 startingPos;
	Quaternion startingRot;
	public float speedMax = 35f, speedMin = 20f;
	float speed = 0f;
	public float durationMax = 0.5f, durationMin = 0.3f;
	float duration = 0f;
	public float amountMax = 0.06f, amountMin = 0.02f;
	float amountX = 0f, amountZ = 0f;
	GameObject player;
	bool shake;

	void Awake()
	{
		startingPos = transform.position;
		startingRot = transform.rotation;
		player = GameObject.FindGameObjectWithTag("Player");
	}

	private void OnTriggerEnter(Collider other)
	{
		speed = Random.Range(speedMin, speedMax);
		duration = Random.Range(durationMin, durationMax);
		amountX = Random.Range(amountMin, amountMax);
		amountZ = Random.Range(amountMin, amountMax);
		shake = true;
		print("entered " + gameObject.name + ": " + speed + ", " + duration + ", " + amountX + ", " + amountZ);
	}
	private void OnTriggerExit(Collider other)
	{
		print("exited " + gameObject.name);
		if (other.tag == player.tag)
		{
			StartCoroutine(ShakeNow(duration));
		}
	}

	private void Update()
	{
		if (shake)
		{
			gameObject.transform.position = new Vector3(
				startingPos.x + Mathf.Sin(Time.time * speed) * amountX,
				startingPos.y,
				startingPos.z + Mathf.Sin(Time.time * speed) * amountZ);

			gameObject.transform.rotation = new Quaternion(
				startingRot.x + Mathf.Sin(Time.time * speed) * amountX,
				startingRot.y,
				startingRot.z + Mathf.Sin(Time.time * speed) * amountZ,
				startingRot.w);
		}
	}

	IEnumerator ShakeNow(float dur)
	{
		yield return new WaitForSeconds(dur);
		shake = false;
		speed = 0f;
		duration = 0f;
		amountX = 0f;
		amountZ = 0f;
	}
}