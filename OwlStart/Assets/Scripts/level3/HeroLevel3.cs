using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroLevel3 : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 horizontalForce=new Vector2(7,0);
    Vector2 verticalForce=new Vector2(0,200);
    float hp=5;
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
        if(hp<=0){
            SceneManager.LoadScene("world3");
        }
        
        
    }
    void Control(){
        if(Input.GetKey("d")&&onGround){
            rb.AddForce(horizontalForce);
           transform.eulerAngles = new Vector3(0,0,0);
        }
        if(Input.GetKey("a")&&onGround){
            rb.AddForce(-1*horizontalForce);
            transform.eulerAngles = new Vector3(0,180,0);
        }
        if(Input.GetKeyDown("space")&&onGround){
            rb.AddForce(verticalForce);
            onGround=false;
            
           
        }
    }
    void AnimController(){
        if(!onGround){
            anim.Play("jump");
        }
        if((Input.GetKey ("d") || Input.GetKey ("a"))&&onGround){
            anim.Play("run");
        }
    }
    void OnCollisionEnter2D(Collision2D col){
        onGround=true;
        if (col.relativeVelocity.y > 8 ){
            hp--;
            GameObject c =Instantiate(pfbblood);
            c.transform.position=this.transform.position;
        }   
    }
    void OnCollisionExit2D(Collision2D col){
        onGround=false;
    }
    void PressUp (){
        if ( onGround)
        {
            rb.AddForce(verticalForce);
            onGround = false;


        }
    }
    void PressRight() {
        if ( onGround)
        {
            rb.AddForce(horizontalForce);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
    void PressLeft() {
        if ( onGround)
        {
            rb.AddForce(-1 * horizontalForce);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

}
