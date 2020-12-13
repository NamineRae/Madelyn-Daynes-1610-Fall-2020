using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class RiddlePuzzle : MonoBehaviour
{
    public TextMeshProUGUI riddleText;

    public Button answerButtonOne;

    public Button answerButtonTwo;

    public Button answerButtonThree;
    // Start is called before the first frame update
    void Start()
    {
        answerButtonOne = GetComponent<Button>();
        answerButtonTwo = GetComponent<Button>();
        answerButtonThree = GetComponent<Button>();
        //answerButtonOne.onClick.AddListener(Wrong);  
        //answerButtonTwo.onClick.AddListener(Right);
        //answerButtonThree.onClick.AddListener(Wrong);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Wrong()
    {
        //GetComponent<Image>().color = Color.gray;
    }

    void Right()
    {
        
    }
    
}
