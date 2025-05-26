using Unity.VisualScripting;
using UnityEngine;

public class RandomLateUpdate : MonoBehaviour
{
    public GameObject C�psula;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void LateUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        C�psula.GetComponent<MeshRenderer>().material.color = c;
    }

    // Update is called once per frame
    void OnEnable ()
    {
        Instantiate(C�psula);
    }

    void OnDisable()
    {
        Debug.Log("Se desactivo la C�psula");
    }
}
