using UnityEngine;
using System.Collections;

public class SoundRayGenerator : MonoBehaviour {

	public SoundRay soundRay;

	public float speed;
	public float numRays;
	public float lifeTime;
	public int hSpread;
	public int vSpread;

	public void init(float speed, int numRays, float lifeTime, int hSpread, int vSpread) {
		this.speed = speed;
		this.numRays = numRays;
		this.lifeTime = lifeTime;
		this.hSpread = hSpread;
		this.vSpread = vSpread;
	}

	public void generate(Vector3 pos, Quaternion dir) {
		for (int h = 0; h < hSpread; h += 10) {
			for (int v = 0; v < vSpread; v += 10) {
				SoundRay sr = Instantiate(soundRay, new Vector3(pos.x, 0.5f, pos.z), Quaternion.identity) as SoundRay;
				sr.init(dir, speed, lifeTime);
			}
		}
	}

	private Vector3 Rotate(Vector3 vec, Vector3 axis, float angle) {
		return Quaternion.Euler(axis.x * angle, axis.y * angle, axis.z * angle) * vec;
	}
}
