using UnityEngine;

public class Invader : MonoBehaviour
{
    public Sprite[] animationSprites;
    public float animationTime = 1.0f;

    private SpriteRenderer _spriteRenderer;
    private int _animationIndex;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), animationTime, animationTime);
    }

    private void AnimateSprite()
    {
        _animationIndex++;

        if (_animationIndex >= animationSprites.Length)
        {
            _animationIndex = 0;
        }

        _spriteRenderer.sprite = animationSprites[_animationIndex];
    }
}
