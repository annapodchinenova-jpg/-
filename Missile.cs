using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        
    }
    void OnTriggerEnter(Collider other)
    { 
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
