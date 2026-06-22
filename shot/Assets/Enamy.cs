using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f; 

    void Start()
    {
      
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        // ‰º‚ÉŒü‚©‚Á‚ÄˆÚ“®
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}