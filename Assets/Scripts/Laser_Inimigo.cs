using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Inimigo : MonoBehaviour
{
    public float velocLaser = 12.0f ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocLaser * Time.deltaTime);
  
        if (transform.position.x <= -14.65f){
            Destroy(this.gameObject);

        }

        
    }
}
