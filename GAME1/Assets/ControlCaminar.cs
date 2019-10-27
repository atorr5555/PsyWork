using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCaminar : MonoBehaviour
{
    // Start is called before the first frame update
    // public Animator abajo;
    public Animator principal_0;

    //public float Velocidad;
   // private Rigidbody2D Body;
  
    void Start()
    {
        //Body = GetComponent<Rigidbody2D>();
        principal_0 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(-.1f, 0, 0);
             principal_0.SetBool("camina2", true);
          
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(.1f, 0, 0);
            principal_0.SetBool("camina3", true);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += new Vector3(0, .1f, 0);
            principal_0.SetBool("camina4", true);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += new Vector3(0, -.1f, 0);
            principal_0.SetBool("camina1", true);
        }
       
    }
}
