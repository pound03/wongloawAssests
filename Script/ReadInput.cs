using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    // Start is called before the first frame update
    ControlWord callControlWord;
    private string input;
    void Start()
    {
        callControlWord = GetComponent<ControlWord>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadStringInput(string s)
    {
        input = s.ToLower();
        Debug.Log(input);
        callControlWord.NewWord(input);
    }
}
//https://www.youtube.com/watch?v=guelZvubWFY&ab_channel=GameDevTraum