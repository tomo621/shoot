using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f; 
    public GameObject bulletPrefab; 
    public Transform muzzle;
    void Update()
    {
        // 上下左右の入力を取得
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // 移動処理
        Vector2 direction = new Vector2(x, y).normalized;
        transform.Translate(direction * speed * Time.deltaTime);

        // スペースキーで弾を発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, muzzle.position, Quaternion.identity);
        }
    }
}