using UnityEngine;
using System.Collections;

public class EnemyBoltMover : MonoBehaviour 
{
	public float speed;

	void Start ()
	{
		rigidbody.velocity = transform.forward * speed;
	}
}
