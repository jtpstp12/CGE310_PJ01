using UnityEngine;

public class FlappyBirdController : MonoBehaviour
{
    public float jumpForce = 5f; // �ç���ⴴ�ͧ��
    private Rigidbody2D rb;

    private void Start()
    {
        // ��Ҷ֧ Rigidbody2D �ͧ����Ф�
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // ��Ǩ�Ѻ��á� Spacebar ���ͤ�ԡ˹�Ҩ����͡��ⴴ
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        // ��駤�Ҥ�������᡹ Y ���͡��ⴴ
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
    }
}
