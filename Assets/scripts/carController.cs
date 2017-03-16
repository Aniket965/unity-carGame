using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

    public float carSpeed;
    public float MaxPostion;
   public uimanager ui;
    Vector3 postion;
	void Start () {
      postion = transform.position;
	}
	
	
	void Update () {

        ACMMOVE();
       
	
	}
    void ACMMOVE()
    {
        float x = Input.acceleration.x;
        if (x >= 0)
        {
            postion.x += x * carSpeed * Time.deltaTime*8;
            postion.x = Mathf.Clamp(postion.x, -MaxPostion, MaxPostion);
            transform.position = postion;
        }
        else {
            postion.x += x * carSpeed * Time.deltaTime*8;
            postion.x = Mathf.Clamp(postion.x, -MaxPostion, MaxPostion);
            transform.position = postion;
        }
 
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy")
        {
            ui.GameOver();
            Destroy(gameObject);

        }
    }
}
