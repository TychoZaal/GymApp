using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightsFormatting : MonoBehaviour
{
    [SerializeField] private Transform minXY, maxXY;
    [SerializeField] private GameObject prefab;

    public Exercise exercise;
    private List<GameObject> weightsUI;

    void Start()
    {
        int weights = exercise.weights.Count;

        for (int i = 0; i < weights; i++)
        {
            weightsUI.Add(Instantiate(prefab));
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(minXY.transform.position, new Vector3(minXY.transform.position.x, maxXY.transform.position.y, 0.0f));
        Gizmos.DrawLine(new Vector3(minXY.transform.position.x, maxXY.transform.position.y, 0.0f), maxXY.transform.position);
        Gizmos.DrawLine(maxXY.transform.position, new Vector3(maxXY.transform.position.x, minXY.transform.position.y, 0.0f));
        Gizmos.DrawLine(new Vector3(maxXY.transform.position.x, minXY.transform.position.y, 0.0f), minXY.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < weightsUI.Count; i++)
        {
            float middleY = (maxXY.transform.position.y - minXY.transform.position.y) / 2 + minXY.transform.position.y;

            weightsUI[i].transform.position = new Vector3(0.0f, middleY, 0.0f);
        }
    }
}
