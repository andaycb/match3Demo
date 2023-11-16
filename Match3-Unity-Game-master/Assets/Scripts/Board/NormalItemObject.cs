using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItemObject : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    public void SetSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }
}