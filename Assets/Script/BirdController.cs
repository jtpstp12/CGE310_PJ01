using UnityEngine;

public class FlappyBirdController : MonoBehaviour
{
    public float jumpForce = 5f; // แรงกระโดดของนก
    private Rigidbody2D rb;

    private void Start()
    {
        // เข้าถึง Rigidbody2D ของตัวละคร
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // ตรวจจับการกด Spacebar หรือคลิกหน้าจอเพื่อกระโดด
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        // ตั้งค่าความเร็วแกน Y เพื่อกระโดด
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
    }
}
