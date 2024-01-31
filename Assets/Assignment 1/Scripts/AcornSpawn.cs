using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AcornSpawn : MonoBehaviour
{
    public GameObject prefab;
    public Transform pos1;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, pos1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
