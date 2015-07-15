using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	public float speed;

	public GameObject enemyShot;
	public Transform enemyShotSpawn;
	public float enemyFireRate;
	
	private float nextFire;
	
	void Start()
	{
		rigidbody.velocity = transform.forward * speed;
	}

	void Update ()
	{
		if (Time.time > nextFire) 
		{
			nextFire = Time.time + enemyFireRate;
			Instantiate (enemyShot, enemyShotSpawn.position, enemyShotSpawn.rotation);
		}
	}
}
