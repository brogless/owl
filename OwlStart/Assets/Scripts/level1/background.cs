using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.Play ("back");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
