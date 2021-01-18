using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public GameObject pfbBroken;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate ( 0, 0,5);
		transform.position += new Vector3 ( -0.1f,0, 0);
	}

	//проверка столкновений
	void OnCollisionEnter2D( Collision2D stolk ){

		//в stolk хранится информация о столкновении
		if (stolk.gameObject.tag == "fire") {
			GameObject c = Instantiate (pfbBroken);
			c.transform.position = transform.position;
			Destroy (this.gameObject);
			Destroy (stolk.gameObject);
		}

	}

}
