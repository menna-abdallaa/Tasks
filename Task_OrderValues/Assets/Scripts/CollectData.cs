using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class CollectData : MonoBehaviour
{
    public TMP_InputField[] inputFields = new TMP_InputField[6];
    //public List<TMP_InputField> inputFields = new List<TMP_InputField>();
    public TMP_Text textValues;
    public GameObject panel1;
    public GameObject panel2;
    //int[] Values = new int [6];

    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        for (int i = 0; i < inputFields.Length; i++)
        {
            inputFields[i].characterValidation = TMP_InputField.CharacterValidation.Integer;
            
        }
    }

    public void Sorting()
    {
        int[] Values = new int[6];
        //List<int> Values = new List<int>();
        for (int i = 0; i < inputFields.Length; i++)
        {
            string inputField = inputFields[i].GetComponent<TMP_InputField>().text;
            if ( inputField== "")
            {
                inputField = "0";
            }
            int ip_text = int.Parse(inputField);
            Values[i] = ip_text;
            //Values.Add(ip_text);
        }
        /*
        List<int> Values = new List<int>() { ip_text_1, ip_text_2, ip_text_3, ip_text_4, ip_text_5, ip_text_6 }; ;
        */
        Array.Sort(Values);
        //Values.Sort();
        int[] SortedValues = new int[6];
        //List<int> SortedValues = new List<int>();
        int j = Values.Length - 1;
        for (int i = Values.Length-1; i >= 0; i--)
        {            
            SortedValues[i - (j)] = Values[i];
            textValues.text += " \n" + Values[i].ToString();
            Debug.Log(SortedValues[i- (j)]);
            j = j - 2;
            panel2.SetActive(true);
            panel1.SetActive(false);
        }
        
    }
}
