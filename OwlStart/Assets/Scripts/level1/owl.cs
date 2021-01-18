using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class owl : MonoBehaviour {

	public Rigidbody2D rb;
	public GameObject pfbFire;
	public float hp = 3;
	public Animator camAnim;
	public Animator backAnim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Control ();
		Shoot ();
		Die (hp);

	}

	void Control(){
		if (Input.GetKey ("w")) {
			rb.AddForce (new Vector2 (0, 25));
		}
		if (Input.GetKey ("s")) {
			rb.AddForce (new Vector2(0,-25));
		}
	}

	void Shoot(){
		if (Input.GetKeyDown ("space")) {
			GameObject c = Instantiate (pfbFire);
			c.transform.position = transform.position;
		}
	}

	void OnCollisionEnter2D(Collision2D stolk){
		Destroy (stolk.gameObject);
		Debug.Log ("lol");
		hp--;
		camAnim.Play("shake");

	}

	void  Die(float hp){
		if (hp <= 0) {
			this.gameObject.layer = 12;
			rb.gravityScale = 1;
			backAnim.enabled = false;
		}
	}
    void PressUp() {
        rb.AddForce(new Vector2(0, 25));
    }
    void PressDown() {
        rb.AddForce(new Vector2(0, -25));
    }
    public void Fire() {
        GameObject c = Instantiate(pfbFire);
        c.transform.position = transform.position;
    }

}
