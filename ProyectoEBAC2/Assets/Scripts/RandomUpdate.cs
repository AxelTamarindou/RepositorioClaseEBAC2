using UnityEngine;

public class RandomUpdate : MonoBehaviour
{
    public GameObject Esfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Esfera);
        Color c = new Color(Random.value, Random.value, Random.value);
        Esfera.GetComponent<MeshRenderer>().material.color = c;
    }
}
