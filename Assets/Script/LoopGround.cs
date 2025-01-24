using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [SerializeField] private float _speed = 2f; // �������ǡ������͹���
    [SerializeField] private float _resetPosition = -10f; // �ش����鹨ж١����
    [SerializeField] private float _startPosition = 10f; // �ش������鹢ͧ���

    private void Update()
    {
        // ����͹���价ҧ����
        transform.position += Vector3.left * _speed * Time.deltaTime;

        // ��Ҿ������͹�鹨ش����˹� ���絵��˹�����
        if (transform.position.x < _resetPosition)
        {
            transform.position = new Vector3(_startPosition, transform.position.y, transform.position.z);
        }
    }
}
