using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class highScoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    

    private void Awake()
    {
        entryContainer = transform.Find("hsEntryContainer");
        entryTemplate = entryContainer.Find("hsEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        for (int i = 0; i <10; i++)
        {
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryTransform.gameObject.SetActive(true);

            int rank = i + 1;
            string rankString;

            switch (rank)
            {
                default:
                    rankString = rank + "TH"; break;
                case 1: rankString = "1ST"; break;
                case 2: rankString = "2ND"; break;
                case 3: rankString = "3RD"; break;
            }

            Debug.Log("posNo");

            entryTransform.Find("posNo").GetComponent<TextMeshProUGUI>().text = rankString;

            int score = Random.Range(0, 10000);

            entryTransform.Find("scoreNo").GetComponent<Text>().text = score.ToString();
            
            string name = "AAA";
            entryTransform.Find("nameEntry").GetComponent<Text>().text = name;
        }
    }
}
