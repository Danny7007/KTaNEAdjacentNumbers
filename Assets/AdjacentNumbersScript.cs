using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;

public class AdjacentNumbersScript : MonoBehaviour {

    public KMBombInfo Bomb;
    public KMAudio Audio;
    public KMBombModule Module;
    public KMSelectable[] buttons;

    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;

    int[] order = Enumerable.Range(0, 10).ToArray();
    bool[] solution = new bool[10];
    

    void Awake () {
        moduleId = moduleIdCounter++;
        /*
        foreach (KMSelectable button in Buttons) 
            button.OnInteract += delegate () { ButtonPress(button); return false; };
        */
        
        //Button.OnInteract += delegate () { ButtonPress(); return false; };

    }

    void Start ()
    {
        order.Shuffle();
        for (int i = 0; i < 10; i++)
            buttons[i].GetComponentInChildren<TextMesh>().text = order[i].ToString();
        Debug.LogFormat("[Adjacent Numbers #{0}] The labels on the module are: {1}.", moduleId, order.Join(""));
        CalculatePresses();
        Debug.Log(solution.Count(x => x));

    }

    void CalculatePresses()
    {
        for (int keyPos = 0; keyPos < 10; keyPos++)
        {
            int trueCount = 0;
            int falseCount = 0;
            foreach (int adjLabel in Data.horizAdj[keyPos].Select(x => order[x]))
                if (Data.horizSets[adjLabel].Contains(order[keyPos]))
                    trueCount++;
                else falseCount++;
            foreach (int adjLabel in Data.vertAdj[keyPos].Select(x => order[x]))
                if (Data.vertSets[adjLabel].Contains(order[keyPos]))
                    trueCount++;
                else falseCount++;
            solution[keyPos] = trueCount > falseCount;
            Debug.LogFormat("[Adjacent Numbers #{0}] Position {1} (Label {2}) has {3} truth{4} and {5} falsit{6}. {7}",
                moduleId, keyPos + 1, order[keyPos], trueCount, trueCount == 1 ? "" : "s", falseCount, falseCount == 1 ? "y" : "ies",
                solution[keyPos] ? "You should press it." : "");
        }
    }

    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"Use <!{0} foobar> to do something.";
    #pragma warning restore 414

    IEnumerator ProcessTwitchCommand (string command)
    {
        command = command.Trim().ToUpperInvariant();
        List<string> parameters = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        yield return null;
    }

    IEnumerator TwitchHandleForcedSolve ()
    {
        yield return null;
    }
}
