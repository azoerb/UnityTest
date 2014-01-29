using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {
	public SoundRayGenerator generator;

	public void Start() {
		generator.init (20, 40, 3, 60, 60);
	}
	
	public void Action() {
		generator.generate(transform.position, transform.rotation);
	}
}	