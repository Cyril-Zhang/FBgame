using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;
public class HighestScore : MonoBehaviour
{
    public GameObject highestScore;

    public Canvas statsCanvas;
    public GameObject statsScrollContent;
    public GameObject statsPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if(DataCollecter.getScores().Any()){
            var high_score = DataCollecter.getScores().Max();
            highestScore.GetComponent<Text>().text = "Highest Score:" + high_score;
        }
        
        PopulateStatsScrollMenu();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    private void PopulateStatsScrollMenu()
    {
        // Destroy the children. Do it Anakin.
        var children = new List<GameObject>();
        foreach (Transform child in statsScrollContent.transform) children.Add(child.gameObject);
        children.ForEach(child => Destroy(child));

        int index = 0;
        var scores = DataCollecter.getScores();
        var flap_times = DataCollecter.getFlaps();
        var game_times = DataCollecter.getTimes();


        //init
        GameObject go1 = Instantiate(statsPrefab, statsScrollContent.transform);
        Text[] array1 = go1.GetComponentsInChildren<Text>();
        array1[1].text = "Game\n--------------------------------------------";
        array1[2].text = "Time\n---------------------------------------------------";
        array1[3].text = "Click Times\n------------------------------------------------";
        array1[4].text = "Score\n----------------------------------------------------";
        array1[1].enabled = true;
        array1[2].enabled = true;
        array1[3].enabled = true;
        array1[4].enabled = true;
        for(int i = 0; i < scores.Count; i++)
        {
            Debug.Log("Adding a new data box.");
            index++;
            GameObject go = Instantiate(statsPrefab, statsScrollContent.transform);
            Text[] array = go.GetComponentsInChildren<Text>();
            array[1].text = (i+1).ToString();
            array[2].text = Math.Round(game_times[i],2).ToString();
            array[3].text = flap_times[i].ToString();
            array[4].text = scores[i].ToString();
            array[1].enabled = true;
            array[2].enabled = true;
            array[3].enabled = true;
            array[4].enabled = true;
        }
    }
}
