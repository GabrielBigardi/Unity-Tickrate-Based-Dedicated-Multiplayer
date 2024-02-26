using System.Collections;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CanvasScaleFixer : MonoBehaviour
{
    private int lastScreenWidth = 0;
    private int lastScreenHeight = 0;

    private CanvasScaler _canvasScaler;
    private PixelPerfectCamera _pixelPerfectCamera;

    private void OnEnable()
    {
        _canvasScaler = GetComponent<CanvasScaler>();
        _pixelPerfectCamera = Camera.main.GetComponent<PixelPerfectCamera>();
    }

    void Update()
    {
        if (lastScreenWidth != Screen.width || lastScreenHeight != Screen.height)
        {
            lastScreenWidth = Screen.width;
            lastScreenHeight = Screen.height;
            StartCoroutine(FindCanvasScaleFactor());
        }
    }

    private IEnumerator FindCanvasScaleFactor()
    {
        yield return null;

        float difference = Screen.height / Camera.main.orthographicSize;
        float newScaleFactor = difference / (_pixelPerfectCamera.assetsPPU * 2);
        _canvasScaler.scaleFactor = newScaleFactor;
    }
}