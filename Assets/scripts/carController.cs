using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

    public float carSpeed;
    public float MaxPostion;

    Vector3 postion;
	void Start () {
      postion = transform.position;
	}
	
	
	void Update () {
        postion.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        postion.x =  Mathf.Clamp(postion.x, -MaxPostion, MaxPostion);
        
        transform.position = postion;
	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy")
            Destroy(gameObject);

    }
}
