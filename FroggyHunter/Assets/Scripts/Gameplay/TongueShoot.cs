using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TongueShoot : MonoBehaviour
{
    [Header("Component")]
    private InputHandler input = null;
    [SerializeField] private Timer timer = null;
    [SerializeField] private HighScore scoring = null;
    [SerializeField] private InstinctJauge instinct = null;
    [SerializeField] private SpriteRenderer tongue = null;
    [SerializeField] private List<Transform> Targets = null;

    [Header("Variables")]
    [SerializeField] private float radius = 3f;
    [SerializeField] private float tongueFactor = 1f;
    [SerializeField] private float etirSpeed = 200f;
    [SerializeField] private float retractSpeed = 5f;


    [Header("OnShoot")]
    [SerializeField] private float bonusTime = 2f;
    [SerializeField] private float bonusInstinct = 0.5f;

    private void Awake()
    {
        input = InputHandler.Instance;
    }

    private void Update()
    {
        //Quand tu tires
        if (input.shootExit && Targets.Count == 0)
        {
            Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, radius);

            foreach (Collider2D hit in hits)
            {
                if (hit.CompareTag("Insect"))
                {
                    StartCoroutine(TongueEtir(0.05f, hit.transform));

                    timer.remainingTime += bonusTime;
                    instinct.instinct += bonusInstinct;
                }
            }
        }

        TongueRetract();
    }

    private IEnumerator TongueEtir(float shootDuration, Transform target)
    {
        float time = shootDuration;
        float porter = Vector2.Distance(tongue.transform.position, transform.position);

        target.GetComponent<InsectBehavior>().isTrapped = true;

        while (0 < time) 
        {
            time -= Time.deltaTime;

            Time.timeScale = 0.05f;

            porter = Vector2.Distance(tongue.transform.position, transform.position);

            target.position = transform.position;
            tongue.size = new Vector2(Mathf.Lerp(tongue.size.x, porter * tongueFactor, etirSpeed * Time.deltaTime), 1);

            yield return 0; //go to next frame
        }

        Targets.Add(target);
        target.SetParent(tongue.transform);

        scoring.scoreChange(target.GetComponent<InsectBehavior>().point);

        yield return 0;
    }

    private void TongueRetract()
    {
        if(tongue.size.x > 0.1f)
        {
            tongue.size = new Vector2( Mathf.Lerp(tongue.size.x, 0, retractSpeed * Time.deltaTime),1);

            if(Targets != null)
            {
                foreach (Transform target in Targets)
                {
                    Vector3 pos = new Vector3( target.position.x - tongue.transform.position.x, target.position.y - tongue.transform.position.y, 0).normalized;
                    target.position = tongue.transform.position + pos * tongue.size.x * 0.5f;
                }
            }
        }
        else
        {
            if (Targets != null)
            {
                foreach (Transform target in Targets)
                {
                    Destroy(target.gameObject);
                }

                Targets.Clear();
            }

            tongue.size = new Vector2(0, 1);
        }
    }
    
    private void OnDrawGizmos()
    {
        Handles.color = Color.red;
        Handles.DrawWireDisc(transform.position, transform.forward, radius);
    }

}
