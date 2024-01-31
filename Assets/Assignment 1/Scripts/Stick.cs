using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        rigidbody.drag = 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        rigidbody.drag = 2;
    }
}
