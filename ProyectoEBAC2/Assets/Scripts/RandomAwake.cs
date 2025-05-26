using UnityEngine;

public class RandomAwake : MonoBehaviour
{
    public GameObject Cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Instantiate(Cubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        Cubo.GetComponent<MeshRenderer>().material.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
