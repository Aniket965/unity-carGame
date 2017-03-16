using UnityEngine;
using System.Collections;

public class enemydes : MonoBehaviour {

		void Start () {
	
	}
	
	
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy") 
        Destroy(coll.gameObject);
    }
    
}
