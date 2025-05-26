using Unity.VisualScripting;
using UnityEngine;

public class RandomLateUpdate : MonoBehaviour
{
    public GameObject Cápsula;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void LateUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        Cápsula.GetComponent<MeshRenderer>().material.color = c;
    }

    // Update is called once per frame
    void OnEnable ()
    {
        Instantiate(Cápsula);
    }

    void OnDisable()
    {
        Debug.Log("Se desactivo la Cápsula");
    }
}
