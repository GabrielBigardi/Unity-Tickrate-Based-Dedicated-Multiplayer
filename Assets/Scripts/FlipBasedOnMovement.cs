using UnityEngine;

public class FlipBasedOnMovement : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    private Vector3 _previousPos;

    private void Awake()
    {
        _previousPos = transform.position;
    }

    private void Update()
    {
        var currentPosition = transform.position;
        var difference = currentPosition - _previousPos;

        if (difference.x < 0)
            _spriteRenderer.flipX = true;

        if (difference.x > 0)
            _spriteRenderer.flipX = false;

        _previousPos = transform.position;
    }
}
