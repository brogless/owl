using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLevel2 : MonoBehaviour
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
        Vector3 dir=hero.transform.position-this.transform.position;
        dir.y=0;
        dir.z=-10;
        this.transform.Translate(dir.normalized);
        
    }
}
