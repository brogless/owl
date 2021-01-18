using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLevel2 : MonoBehaviour
{
    
    HeroLevel2 hero;
    // Start is called before the first frame update
    void Start()
    {
        
        hero=FindObjectOfType<HeroLevel2>();
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0.03f, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag=="hero"){
            SceneManager.LoadScene("world2");

        }
    }
}
