using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserInterfaceManager : MonoBehaviour
{
    [Header("Class references")]
    [SerializeField] private Workout workout;

    [SerializeField] private TextMeshProUGUI workoutName, date;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateWorkoutFields();
        UpdateExerciseFields();
    }

    private void UpdateWorkoutFields()
    {
        workoutName.text = workout.workoutName;
        date.text = workout.date;
    }

    private void UpdateExerciseFields()
    {

    }
}
