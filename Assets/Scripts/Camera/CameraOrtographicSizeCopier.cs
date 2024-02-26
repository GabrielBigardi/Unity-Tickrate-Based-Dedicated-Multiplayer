using UnityEngine;


[ExecuteInEditMode]
public class CameraOrtographicSizeCopier : MonoBehaviour
{
    [SerializeField] private Camera _pixelPerfectCamera;
    [SerializeField] private Camera _targetCamera;

    private void Update()
    {
        if (_targetCamera != null && _pixelPerfectCamera != null)
            _targetCamera.orthographicSize = _pixelPerfectCamera.orthographicSize;
    }
}