using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour
{
    private MeshRenderer mr;
    public float variable = 1f;

    void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }
    void Start()
    {
    }

    // Update is called once per frame
    private  void Update()
    {
        mr.material.mainTextureOffset += new Vector2(variable * Time.deltaTime, 0);
    }
}
