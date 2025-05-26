using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.LowLevelPhysics;
using UnityEngine.UIElements;

public class RandomUpdate : MonoBehaviour
{
    public GameObject Esfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var SpawnCubo = Instantiate<GameObject>(Esfera);
        var meshRendererMaterial = Esfera.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = new Color(Random.value, Random.value, Random.value);
      
    }
}
