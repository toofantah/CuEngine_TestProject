
/// ----ToofanTahmoures---2021-----
/// This is a template Script for MonoBehaviors Scripts suggested for editing
/// Please check out the naming convention Manuals Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Editable version Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Please duplicate the scripts ligns bellow in the "TemplatesScriptsMonoBehaviour.c" or script and leave it empty, you can duplicate this into a script newly made by you in the editor, 
/// or set up this template as a default unity emplate Script each time you generate a new empty script with replacing this file: https://1drv.ms/t/s!AgDnFacvwTrJgaQ2RrAA6EKnFilrAA?e=TJsnDj :)



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// panel struct
/// </summary>
[System.Serializable]
struct Panels
{
    [SerializeField]
    private RectTransform panel;
    [SerializeField]
    private List<UnityEvent> events;

    public RectTransform GetPanel() 
    { 
       return panel; 
    }

    public void Event()
    {
        foreach (UnityEvent e in events)
        {
            e.Invoke();
        }
    }
}

