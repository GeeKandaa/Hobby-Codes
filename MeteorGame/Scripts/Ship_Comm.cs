using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ship_Comm : MonoBehaviour
{
    public GameObject Player;
    public GameObject Tracker;
    public Text textBox;
    public string[] Text_Array;

    //Store all your text in this string array
    int currentlyDisplayingText = 0;


    void Awake()
    {
        StartCoroutine(AnimateText());
    }
    //This is a function for a button you press to skip to the next text
    public void SkipToNextText()
    {
        StopAllCoroutines();
        currentlyDisplayingText++;
        //If we've reached the end of the array, do anything you want. I just restart the example text
        if (currentlyDisplayingText > Text_Array.Length)
        {
            currentlyDisplayingText = 0;
        }
        StartCoroutine(AnimateText());
    }
    //Note that the speed you want the typewriter effect to be going at is the yield waitforseconds (in my case it's 1 letter for every      0.03 seconds, replace this with a public float if you want to experiment with speed in from the editor)
    IEnumerator AnimateText()
    {
        for (int j = 0; j < Text_Array.Length; j++)
        {
            for (int i = 0; i < (Text_Array[currentlyDisplayingText].Length + 1); i++)
            {
                textBox.text = Text_Array[currentlyDisplayingText].Substring(0, i);
                if (i < (Text_Array[currentlyDisplayingText].Length))
                {
                    yield return new WaitForSeconds(.03f);
                }
                else
                {
                    yield return new WaitForSeconds(1.5f);
                }

            }
            currentlyDisplayingText += 1;
            if (currentlyDisplayingText == 11)
            {
                //  Debug.Log("HIT");
                Tracker.gameObject.SetActive(true);
            }
        }
    }
}