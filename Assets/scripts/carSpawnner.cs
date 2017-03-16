using UnityEngine;
using System.Collections;

public class carSpawnner : MonoBehaviour {
    public GameObject Car;
    public float maxPos = 1.9f;

	void Start () {
        Vector3 carpos = new Vector3(Random.Range(-maxPos, maxPos), transform.position.y, transform.position.z);
        Instantiate(Car,carpos,transform.rotation);
	}
	

	void Update () {
	
	}
}
