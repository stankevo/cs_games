using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;

    string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = StartingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(daysOfWeek[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
