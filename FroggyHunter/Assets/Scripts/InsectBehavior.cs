using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsectBehavior : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private RestrictedArea insectArea = null;


    public enum Direction { Right, Left, Up, Down };
    [SerializeField] private Direction dir = Direction.Right;

    [Header("Variables")]
    [SerializeField] private float speed = 5f;
    [Range(1,5)] [SerializeField] private float randomScale = 1f;

    [SerializeField] Vector2 perlinSeedX = Vector2.zero;
    [SerializeField] Vector2 perlinSeedY = Vector2.zero;

    [SerializeField] private float moveX = 1f;
    [SerializeField] private float moveY = 1f;

    [SerializeField] Vector3 moveDir = Vector2.zero;

    void Start()
    {
        perlinSeedX = new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
        perlinSeedY = new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
    }

    void Update()
    {
        perlinSeedX += Vector2.one * randomScale * Time.deltaTime;
        perlinSeedY += Vector2.one * randomScale * Time.deltaTime;

        moveX = Mathf.PerlinNoise(perlinSeedX.x, perlinSeedX.y);
        moveY = Mathf.PerlinNoise(perlinSeedY.x, perlinSeedY.y);

        moveDir = new Vector2( (moveX -0.45f) * 2, (moveY - 0.45f) * 2) * speed;

        transform.position += moveDir * Time.deltaTime;

    }

}
