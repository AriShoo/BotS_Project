using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class highScoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;

    public int maxEntryCount;
    public float entryPlacementDifference;

    public Color firstPlaceColour;

    private List<Transform> highscoreEntryTransformList;

    private void Awake()
    {
        entryContainer = transform.Find("hsEntryContainer");
        entryTemplate = entryContainer.Find("hsEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        string jsonString = PlayerPrefs.GetString("highScoreTable");
        HighScores highscores = JsonUtility.FromJson<HighScores>(jsonString);

        for (int i = 0; i < highscores.highScoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highScoreEntryList.Count; j++)
            {
                if (highscores.highScoreEntryList[j].score > highscores.highScoreEntryList[i].score)
                {
                    //swap
                    HighScoreEntry tmp = highscores.highScoreEntryList[i];
                    highscores.highScoreEntryList[i] = highscores.highScoreEntryList[j];
                    highscores.highScoreEntryList[j] = tmp;
                }
            }
        }

        highscoreEntryTransformList = new List<Transform>();
        foreach (HighScoreEntry highscoreEntry in highscores.highScoreEntryList)
        {
            CreateHighScoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        }
    }

    private void CreateHighScoreEntryTransform(HighScoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count + 1;
        string rankString;

        switch (rank)
        {
            default:
                rankString = rank + "TH"; break;
            case 1: rankString = "1ST"; break;
            case 2: rankString = "2ND"; break;
            case 3: rankString = "3RD"; break;
        }

        entryTransform.Find("posNo").GetComponent<TextMeshProUGUI>().text = rankString;

        int score = highscoreEntry.score;

        Debug.Log(score.ToString());
        Transform ScoreTran = entryTransform.Find("scoreNo");
        //entryTransform.Find("scoreNo").
        TextMeshProUGUI scoreText = ScoreTran.GetComponent<TextMeshProUGUI>();
        //ScoreTran.GetComponent<Text>()
        scoreText.text = score.ToString();

        string name = highscoreEntry.name;
        entryTransform.Find("nameEntry").GetComponent<TextMeshProUGUI>().text = name;

        // Set fancy first place colour
        if (rank == 1)
        {
            entryTransform.Find("posNo").GetComponent<TextMeshProUGUI>().color = firstPlaceColour;
            entryTransform.Find("scoreNo").GetComponent<TextMeshProUGUI>().color = firstPlaceColour;
            entryTransform.Find("nameEntry").GetComponent<TextMeshProUGUI>().color = firstPlaceColour;

        }

        transformList.Add(entryTransform);
    }

    public static void AddHighScoreEntry(int score, string name)
    {
         // Make highscore entry
         HighScoreEntry highScoreEntry = new HighScoreEntry { score = score, name = name };

        // Load
        string jsonString = PlayerPrefs.GetString("highScoreTable");
        HighScores highscores = JsonUtility.FromJson<HighScores>(jsonString);
        if(highscores == null)
        {
            highscores = new HighScores();
        }

        // Add new
        highscores.highScoreEntryList.Add(highScoreEntry);

        // Limit to 10 rankings
        if (highscores.highScoreEntryList.Count > 10)
        {
            for (int h = highscores.highScoreEntryList.Count; h > 10; h--)
            {
                highscores.highScoreEntryList.RemoveAt(10);
            }
        }

        // Save updated list
        string json = JsonUtility.ToJson(highscores);
         PlayerPrefs.SetString("highScoreTable", json);
         PlayerPrefs.Save();
     }

    [System.Serializable]
    private class HighScores
    {
        public string test = "Hello";

        [SerializeField]
        public List<HighScoreEntry> highScoreEntryList = new List<HighScoreEntry>();
    }

    [System.Serializable]
    private class HighScoreEntry
    {
        public int score;
        public string name;

    }
}
