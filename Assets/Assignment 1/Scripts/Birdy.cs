using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        rigidbody.AddForce(force);
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
