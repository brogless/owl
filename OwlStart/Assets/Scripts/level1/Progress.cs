using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Progress : MonoBehaviour
{
    public RootLevel1 rl;
    public Animator backAnim;
    public GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Win();
    }

    void Move()
    {
        if (this.transform.position.x < 3.5f)
        {
            this.transform.Translate(0.01f, 0, 0);
        }
    }
    void Win() {
        if (this.transform.position.x > 3.5f) {
            rl.enabled=false;
            backAnim.speed = 0;
            hero.transform.Translate(0.1f, 0, 0);
            SceneManager.LoadScene("menu");
        }
    }
}
