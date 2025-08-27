using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveDistance = 10f;
    [SerializeField] private float _moveSpeed = 1f;

    private Vector3 startPosition;
    private bool _isMovingForward = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 targetPosition = _isMovingForward ? startPosition + Vector3.forward * _moveDistance : startPosition;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, _moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < _moveSpeed * Time.deltaTime)
        {
            _isMovingForward = _isMovingForward == false;
        }
    }
}
