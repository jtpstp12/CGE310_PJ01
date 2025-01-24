using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [SerializeField] private float _speed = 2f; // ความเร็วการเลื่อนพื้น
    [SerializeField] private float _resetPosition = -10f; // จุดที่พื้นจะถูกรีเซ็ต
    [SerializeField] private float _startPosition = 10f; // จุดเริ่มต้นของพื้น

    private void Update()
    {
        // เลื่อนพื้นไปทางซ้าย
        transform.position += Vector3.left * _speed * Time.deltaTime;

        // ถ้าพื้นเลื่อนพ้นจุดที่กำหนด รีเซ็ตตำแหน่งใหม่
        if (transform.position.x < _resetPosition)
        {
            transform.position = new Vector3(_startPosition, transform.position.y, transform.position.z);
        }
    }
}
