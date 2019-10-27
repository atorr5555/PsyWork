using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccion : MonoBehaviour
{
    public Rigidbody2D principal;
    public Rigidbody2D alcalde;
    public Canvas alcaldeCam;
    // Start is called before the first frame update
    void Start()
    {
        principal.GetComponent<Rigidbody2D>();
        alcalde.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ()
        {
            alcaldeCam.gameObject.SetActive(true);
        }
        
    }
}
