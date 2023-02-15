using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private GameObject _player;

    private int _moveDiraction;
    private bool _hasToMove = true;

    private Vector3 _startPosition;

    private void Awake()
    {
        //DestroyPlatform();
        _startPosition = transform.position;

        _player = GameObject.FindGameObjectWithTag("Player");

        _moveDiraction = transform.position.x < _player.transform.position.x ? 1 : -1;
    }

    void Update()
    {
        if (_hasToMove == true)
        transform.position += Vector3.right * _moveDiraction * _moveSpeed * Time.deltaTime;

        DestroyPlatform();
    }

    public void StopMovement() => _hasToMove = false;

    void DestroyPlatform()
    {
        if (transform.position.x > 8 || transform.position.x < -8)
        {
            transform.position = _startPosition;
        }
    }
}

