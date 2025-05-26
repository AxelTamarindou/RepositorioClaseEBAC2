using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.LowLevelPhysics;
using UnityEngine.UIElements;

public class RandomAwake : MonoBehaviour
{
    public GameObject Cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        var SpawnCubo = Instantiate<GameObject>(Cubo);
        var meshRendererMaterial = Cubo.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        
      
    }
}
