using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLevel3 : MonoBehaviour
{
    public HeroLevel3 owl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position=new Vector3(0, owl.transform.position.y, -10);
    }
}
