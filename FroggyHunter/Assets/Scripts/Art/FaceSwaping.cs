using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceSwaping : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private TongueShoot tongue = null;
    [SerializeField] private SpriteRenderer[] shootingHead = null;
    [SerializeField] private SpriteRenderer[] aimingHead = null;

    void Update()
    {
        if (tongue.isShooting)
        {
            foreach(SpriteRenderer sprite in shootingHead)
            {
                sprite.enabled = true;
            }
            foreach (SpriteRenderer sprite in aimingHead)
            {
                sprite.enabled = false;
            }
        }
        else
        {
            foreach (SpriteRenderer sprite in shootingHead)
            {
                sprite.enabled = false;
            }
            foreach (SpriteRenderer sprite in aimingHead)
            {
                sprite.enabled = true;
            }
        }
    }
}
