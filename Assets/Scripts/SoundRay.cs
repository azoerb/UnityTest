using UnityEngine;
using System.Collections;

public class SoundRay : MonoBehaviour {

	private float speed;
	private Quaternion direction;
	private float lifetime;

	public void init (Quaternion dir, float speed, float lifetime) {
		this.direction = dir;
		this.speed = speed;
		this.lifetime = lifetime;
	}

	void Start () {
		rigidbody.velocity = direction.eulerAngles * speed;
		Destroy (gameObject, lifetime);
	}
}
