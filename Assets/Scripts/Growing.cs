using UnityEngine;

public class Growing : MonoBehaviour
{
    [SerializeField] private float _growthSpeed = 0.5f;
    [SerializeField] private float _maxScale = 3f;
    [SerializeField] private float _minScale = 0.3f;

    private bool _isGrowing = true;

    private void Update()
    {
        float scaleChange = _growthSpeed * Time.deltaTime;

        Vector3 currentScale = transform.localScale;

        if (_isGrowing)
        {
            currentScale += Vector3.one * scaleChange;

            if (currentScale.x >= _maxScale)
            {
                currentScale = Vector3.one * _maxScale;

                _isGrowing = false;
            }
        }
        else
        {
            currentScale -= Vector3.one * scaleChange;

            if (currentScale.x <= _minScale)
            {
                currentScale = Vector3.one * _minScale;

                _isGrowing = true;
            }
        }

        transform.localScale = currentScale;
    }
}
