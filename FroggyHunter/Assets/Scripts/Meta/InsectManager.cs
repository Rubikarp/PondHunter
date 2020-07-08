using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InsectManager : MonoBehaviour
{
    public static List<InsectBehavior> insectList = new List<InsectBehavior>();

    [Header("Component")]
    public RestrictedArea insectArea = null;
    [SerializeField] private Vector3[] insectSpawnPos = null;

    [SerializeField] private Transform insectContainer = null;
    [SerializeField] private GameObject basicInsect = null;
    [SerializeField] private GameObject libellule = null;

    [Header("Variables")]
    [SerializeField] private float insectActif = 4f;

    private void Start()
    {        
        for (int i = 0; i < insectActif; i++)
        {
            float dice = Random.Range(0f, 100f);

            if(dice < 90)
            {
                SpawnInsect( basicInsect, i % insectSpawnPos.Length);
            }
            else
            {
                SpawnInsect( libellule, i % insectSpawnPos.Length);
            }
        }
    }

    void Update()
    {
        //Verifie qu'il y ai bien 4 insectes
        if(insectList.Count < insectActif)
        {
            float dice = Random.Range(0f, 100f);

            if (dice < 90)
            {
                SpawnInsect(basicInsect, Random.Range(0, insectSpawnPos.Length));
            }
            else
            {
                SpawnInsect(libellule, Random.Range(0, insectSpawnPos.Length));
            }
        }
    }

    private void SpawnInsect(GameObject insectPrefab, int spawnPoint)
    {
        GameObject insect = null;

        insect = Instantiate(insectPrefab, insectSpawnPos[spawnPoint], Quaternion.identity, insectContainer);
        insect.GetComponent<InsectBehavior>().insectArea = insectArea;

    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Handles.color = Color.red;

        foreach (Vector3 pos in insectSpawnPos)
        {
            Handles.DrawSolidDisc(pos, transform.forward, 0.1f);
        }
    }
#endif
}
