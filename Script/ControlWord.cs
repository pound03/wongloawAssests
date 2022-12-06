using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWord : MonoBehaviour
{
    // Start is called before the first frame update
    string[] wordUsed;
    int wordUsedCount;
    ReadText callReadText;

    char lastChar;
    void Start()
    {
        callReadText = GetComponent<ReadText>();
        wordUsed = new string[255];
        wordUsedCount = 0;
    }

    void Update()
    {
        
    }
    public void NewWord(string word){
        if(callReadText.CheckWord(word)){
            bool used = false;
            for (int i = 0; i < wordUsedCount; i++)
            {
                if (word == wordUsed[i])
                {
                    used = true;
                }
            }
            if (!used)
            {
                wordUsed[wordUsedCount] = word;
                wordUsedCount++;
                Debug.Log("word is correct");
                lastChar = word[word.Length - 1];
                Debug.Log(lastChar);
            }
            else
            {
                Debug.Log("word is used");
            }
        }
        else{
            Debug.Log("Word is incorrect");
        }
    }
}
