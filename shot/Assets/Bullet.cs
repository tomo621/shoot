using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; 

    void Start()
    {
        // 撃たれてから3秒後に自動で消滅
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        // 上に向かって移動
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    // 他のオブジェクトとぶつかった時の処理
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); 
            Destroy(gameObject); 
        }
    }
}