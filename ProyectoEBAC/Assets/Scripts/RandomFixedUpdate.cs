using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.LowLevelPhysics;
using UnityEngine.UIElements;

public class RandomFixedUpdate : MonoBehaviour
{
    public GameObject Cápsula;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void FixedUpdate()
    {
        var meshRendererMaterial = Cápsula.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void OnEnable()
    {
        var SpawnCubo = Instantiate<GameObject>(Cápsula);
    }

    void OnDisable()
    {
        Debug.Log("Se deshabilitó la Cápsula");
    }

}
