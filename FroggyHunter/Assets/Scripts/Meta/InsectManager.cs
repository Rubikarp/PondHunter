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
    [SerializeField] private GameObject insectPrefab = null;

    private void Start()
    {        
        GameObject insect = null;

        for (int i = 0; i < 4; i++)
        {
            insect = Instantiate(insectPrefab, insectSpawnPos[i], Quaternion.identity, insectContainer);
            insect.GetComponent<InsectBehavior>().insectArea = insectArea;
        }
    }

    void Update()
    {
        //Verifie qu'il y ai bien 4 insectes
        if(insectList.Count < 4)
        {
            GameObject insect = Instantiate(insectPrefab, insectSpawnPos[Random.Range(0, insectSpawnPos.Length - 1)], Quaternion.identity, insectContainer);
            insect.GetComponent<InsectBehavior>().insectArea = insectArea;
        }


    }

    private void OnDrawGizmos()
    {
        Handles.color = Color.red;

        foreach (Vector3 pos in insectSpawnPos)
        {
            Handles.DrawSolidDisc(pos, transform.forward, 0.1f);
        }
    }
}
