using UnityEngine;

public class MovementForwardByOrientation : MonoBehaviour
{
    [SerializeField] private float _moveDistance = 10f;
    [SerializeField] private float _moveSpeed = 1f;

    private Vector3 _startPosition;
    private Vector3 _targetPosition;
    private bool _isMovingForward = true;

    void Start()
    {
        _startPosition = transform.position;

        CalculateTargetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, _targetPosition) < _moveSpeed * Time.deltaTime)
        {
            _isMovingForward = _isMovingForward == false;

            CalculateTargetPosition();
        }
    }

    private void CalculateTargetPosition()
    {
        if (_isMovingForward)
        {
            _targetPosition = _startPosition + transform.forward * _moveDistance;
        }
        else
        {
            _targetPosition = _startPosition;
        }
    }
}
