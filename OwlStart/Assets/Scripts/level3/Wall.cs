using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{
    float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
              
        this.transform.Translate(new Vector3(0,-0.03f,0));
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name=="Owl"){
            SceneManager.LoadScene("world3");
        }
    }
}
