using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public GameObject up;
    public GameObject down;
    public Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        up.SetActive(true); 
        down.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        down.SetActive(true);
        up.SetActive(false);
    }
}
