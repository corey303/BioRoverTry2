using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission : MonoBehaviour
{
    public string missionName;
    public ObjectiveManager objectiveSet;
    public bool missionCompleted;

    private Text missionNameDisplay;

    // Start is called before the first frame update
    void Start()
    {
        missionNameDisplay = GameObject.Find("Mission Name Display").GetComponent<Text>();
        missionNameDisplay.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (objectiveSet.allObjectivesCompleted)
        {
            missionCompleted = true;
            missionNameDisplay.text = "Mission Completed!";
            missionNameDisplay.color = Color.yellow;
        }
        else
            missionNameDisplay.text = missionName;

    }
}
