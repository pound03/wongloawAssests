using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class ReadText : MonoBehaviour
{
    // Start is called before the first frame update
    private StreamReader reader;
    private string[] words;
    void Start()
    {
        string path = "Assets/Json/wordlisttext.txt";
        reader = new StreamReader(path); 
        string line = reader.ReadToEnd();
        words = line.Split('\n');
        reader.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool CheckWord(string word)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (word == words[i])
            {
                return true;
            }
        }
        return false;
    }
}
