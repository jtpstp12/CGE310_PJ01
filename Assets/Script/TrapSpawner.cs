using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _Trap;
    private float _timer;

    void Start()
    {
        TrapSpawn();
    }

    void Update()
    {
        if (_timer > _maxTime)
        {
            TrapSpawn();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void TrapSpawn()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject trap = Instantiate(_Trap, spawnPos, Quaternion.identity);

        // ทำลาย Object ที่สร้างหลังจาก 10 วินาที
        Destroy(trap, 10f);
    }
}
