using UnityEngine;
using System.Collections;

public class carSpawnner : MonoBehaviour {
    public GameObject Car;
    public float maxPos = 1.9f;
    public float delayedtimer = 1f;
    float timer;

	void Start () {
          timer = delayedtimer;

	}
	

	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0) {
            Vector3 carpos = new Vector3(Random.Range(-maxPos, maxPos), transform.position.y, transform.position.z);
            Instantiate(Car, carpos, transform.rotation);
            timer = delayedtimer;
        }
       
    }
}
