using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsectBehavior : MonoBehaviour
{
    [Header("Component")]
    public RestrictedArea insectArea = null;

    [Header("Variables")]
    public int point = 10;
    public bool isTrapped = false;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float randomScale = 1f;
    [Range(0, 1)] [SerializeField] private float directionX = 0.5f, directionY = 0.5f;

    private Vector2 perlinSeedX = Vector2.zero, perlinSeedY = Vector2.zero;

    private void OnEnable() => InsectManager.insectList.Add(this);
    private void OnDisable() => InsectManager.insectList.Remove(this);

    void Start()
    {
        perlinSeedX = new Vector2(Random.Range(-1000, 1000), Random.Range(-1000, 1000));
        perlinSeedY = new Vector2(Random.Range(-1000, 1000), Random.Range(-1000, 1000));
    }

    void Update()
    {
        perlinSeedX += Vector2.one * Random.value * randomScale * Time.deltaTime;
        perlinSeedY += Vector2.one * Random.value * randomScale * Time.deltaTime;

        float moveX = Mathf.PerlinNoise(perlinSeedX.x, perlinSeedX.y);
        float moveY = Mathf.PerlinNoise(perlinSeedY.x, perlinSeedY.y);

        Vector3 moveDir = new Vector2( (moveX - directionX) * 2, (moveY - directionY) * 2).normalized * speed;

        if (!isTrapped)
        {
            if (insectArea.InZone(transform))
            {
                transform.position += moveDir * speed * Time.deltaTime;
            }
            else
            //Il peut revenir dans la zone de jeu
            if (insectArea.CanMoveInDir(transform, moveDir))
            {
                transform.position += moveDir * speed * Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("InsectZone"))
        {
            Vector2 dir = gameObject.GetComponent<InscetChangeDir>().Direction;
            directionX = dir.x;
            directionY = dir.y;
        }
    }

}
