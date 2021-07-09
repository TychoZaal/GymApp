using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkoutFormatting : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform minXY, maxXY, exercisesParent;

    private Workout workout;
    List<GameObject> exercises = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        workout = GetComponent<Workout>();

        for (int i = 0; i < workout.exercisesWorkout.Count; i++)
        {
            GameObject ex = Instantiate(prefab, exercisesParent);
            ex.GetComponent<ExerciseFormatting>().exercise = workout.exercisesWorkout[i];
            ex.transform.position = Vector3.zero;

            exercises.Add(ex);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(minXY.transform.position, new Vector3(minXY.transform.position.x, maxXY.transform.position.y, 0.0f));
        Gizmos.DrawLine(new Vector3(minXY.transform.position.x, maxXY.transform.position.y, 0.0f), maxXY.transform.position);
        Gizmos.DrawLine(maxXY.transform.position, new Vector3(maxXY.transform.position.x, minXY.transform.position.y, 0.0f));
        Gizmos.DrawLine(new Vector3(maxXY.transform.position.x, minXY.transform.position.y, 0.0f), minXY.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < exercises.Count; i++)
        {
            float xPos = 0.0f;
            float yPos = (maxXY.transform.position.y - minXY.transform.position.y) / exercises.Count + minXY.transform.position.y;

            exercises[i].transform.position = new Vector3(xPos, yPos * i, 0.0f);
            exercises[i].transform.position = Vector3.zero;
        }
    }
}
