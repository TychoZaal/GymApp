using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workout : MonoBehaviour
{
    public string workoutName;
    public string date;

    [SerializeField]
    private Dictionary<string, Queue<Exercise>> exercises = new Dictionary<string, Queue<Exercise>>();
    public List<Exercise> exercisesWorkout = new List<Exercise>();

    private void Start()
    {
        for (int i = 0; i < exercisesWorkout.Count; i++)
        {
            // exercises[exercisesWorkout[i].exerciseName].Enqueue(exercisesWorkout[i]);
        }

        date = System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Year.ToString();
    }

    public Exercise GetExercise(string key)
    {
        return exercises[key].Dequeue();
    }
}
