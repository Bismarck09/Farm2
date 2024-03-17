using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _upBarrier;
    [SerializeField] private float _downBarrier;
    [SerializeField] private float _rightBarrier;
    [SerializeField] private float _leftBarrier;

    private Vector3 _targetPosition;

    private void LateUpdate()
    {
        Move();
        CheckCameraPosition(transform.position.x, _rightBarrier, _leftBarrier, new Vector3(_rightBarrier, transform.position.y, _player.transform.position.z - 10), new Vector3(_leftBarrier, transform.position.y, _player.transform.position.z - 10));
        CheckCameraPosition(transform.position.y, _upBarrier, _downBarrier, new Vector3(transform.position.y, _upBarrier, _player.transform.position.z - 10), new Vector3(transform.position.y, _downBarrier, _player.transform.position.z - 10));
    }

    private void Move()
    {
        _targetPosition = new Vector3(_player.transform.position.x, _player.transform.position.y, _player.transform.position.z - 10);
        transform.position = _targetPosition;

    }

    private void CheckCameraPosition(float position ,float barrier1, float barrier2, Vector3 newPosition1, Vector3 newPosition2)
    {
        if (position > barrier1)
            transform.position = newPosition1;
        else if (position < barrier2)
            transform.position = newPosition2;
    }
}
