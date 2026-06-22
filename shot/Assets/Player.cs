using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bulletPrefab;
    public Transform muzzle;

    // 画面外に出ないための制限
    public float minX = -8f;
    public float maxX = 8f;
    public float minY = -4f;
    public float maxY = 4f;

    void Update()
    {
        // 上下左右の入力を取得
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // 移動処理
        Vector2 direction = new Vector2(x, y).normalized;
        transform.Translate(direction * speed * Time.deltaTime);

        // 移動範囲を制限（Clamp）
        Vector3 clampedPos = transform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, minX, maxX);
        clampedPos.y = Mathf.Clamp(clampedPos.y, minY, maxY);
        transform.position = clampedPos;

        // ★ここをスペースキーから「左クリック」に変更しました！
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, muzzle.position, Quaternion.identity);
        }
    }
}