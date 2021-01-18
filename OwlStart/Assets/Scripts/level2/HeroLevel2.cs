using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroLevel2 : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    bool onGround;
    public GameObject pfbblood;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Control();
        AnimController();
    }
    void Control(){
        
            rb.AddForce(new Vector3(10,0,0));
        
        if(Input.GetKeyDown("space")&&onGround){
            rb.AddForce(new Vector3(0,300,0));
            onGround=false;
        }
    }
    void AnimController(){
        if(!onGround){
            anim.Play("jump20");
        }
        if(onGround){
            anim.Play("run2");
        }
    }
    void OnCollisionEnter2D(Collision2D col){
        onGround=true;
        /*if (col.relativeVelocity.y > 8 ){
            hp--;
            GameObject c =Instantiate(pfbblood);
            c.transform.position=this.transform.position;
        }   */
    }
    void OnCollisionExit2D(Collision2D coll) {
        onGround = false;
    }
    void PressUp() {
        if (onGround)
        {
            rb.AddForce(new Vector3(0, 300, 0));
            onGround = false;
        }
    }
}
