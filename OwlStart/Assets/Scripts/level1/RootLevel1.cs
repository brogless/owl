using UnityEngine;
using System.Collections;

public class RootLevel1 : MonoBehaviour {

	
	float t;
    float genSpeed=2*60f;
    public GameObject[] pfbs;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Timer ();
		CreateEnemy (Timer ());
        genSpeed-=0.01f;
	}

	float Timer(){
		t++;
		if (t > 3*60+2) {
			t = 0;
		}
		return t;
	}
	void CreateEnemy(float t){
		if (t > 3 * 60) {
			int r = Random.Range (0, 3);
			GameObject c = Instantiate (pfbs[r]);
			c.transform.position = new Vector3 (10, Random.Range (-3f, 3f), 0);
			c.name="enemy";			
		}
	}
}
