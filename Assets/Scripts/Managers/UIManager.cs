
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
/// Please mention your classe use or introduction here (this is  a template class for demo)
/// </summary>

public class UIManager : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    [SerializeField]
    private List<Panels> panels;
    #endregion
    #region PUBLIC_VARIABLES
    public static UIManager Instance { get; set; }
    #endregion
     void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #region MONOBEHAVIOUR_METHODS
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment
    private void Update()
    {
    }
    #endregion
    #region PMONOBEHAVIOUR_METHODS_PUBLIC
    public void SwitchPanel(int Num)
    {
        for (int i = 0; i < panels.Count; i++)
        {
            if(i== Num)
            {
                panels[i].GetPanel().gameObject.SetActive(true);
            }
            else
            {
                panels[i].GetPanel().gameObject.SetActive(false);
            }
        }
        panels[Num].Event();
    }
    #endregion
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS
    #region NON_MONOBEHAVIOUR_METHODS_PRIVATE
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS_PUBLIC
    #endregion
    #endregion
}

