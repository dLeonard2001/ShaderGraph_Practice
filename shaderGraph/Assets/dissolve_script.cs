using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissolve_script : MonoBehaviour
{
    public Camera cam;
    
    private Material material;
    
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        material.SetFloat("_distance", (cam.transform.position - transform.position).magnitude);
    }
}
