using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject prefab;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public int rotate = 45;

    // Start is called before the first frame update
    void Start()
    {
        prefab.transform.Rotate(0,0, rotate);
        Instantiate(prefab, pos1);
        prefab.transform.Rotate(0, 0, rotate);
        Instantiate(prefab, pos2);
        prefab.transform.Rotate(0, 0, rotate);
        Instantiate(prefab, pos3);
        prefab.transform.Rotate(0, 0, rotate);
        Instantiate(prefab, pos4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
