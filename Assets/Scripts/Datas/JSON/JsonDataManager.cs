
/// ----ToofanTahmoures---2021-----
/// This is a template Script for MonoBehaviors Scripts suggested for editing
/// Please check out the naming convention Manuals Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Editable version Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Please duplicate the scripts ligns bellow in the "TemplatesScriptsMonoBehaviour.c" or script and leave it empty, you can duplicate this into a script newly made by you in the editor, 
/// or set up this template as a default unity emplate Script each time you generate a new empty script with replacing this file: https://1drv.ms/t/s!AgDnFacvwTrJgaQ2RrAA6EKnFilrAA?e=TJsnDj :)



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


/// <summary>
/// Please mention your classe use or introduction here (this is  a template class for demo)
/// </summary>

public class JsonDataManager : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    #endregion
    #region PUBLIC_VARIABLES
    public JsonData data;
    public AssetBundle assetBundle;


    #endregion
    #region MONOBEHAVIOUR_METHODS
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment
    private void Update()
    {
    }
    #endregion
    #region PMONOBEHAVIOUR_METHODS_PUBLIC
    #endregion
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS
    #region NON_MONOBEHAVIOUR_METHODS_PRIVATE
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS_PUBLIC
    public void ParsJSon(string file)
    {
        string path = Path.Combine(Application.streamingAssetsPath, file);
        string dataAsJson = File.ReadAllText(path);

        data = JsonUtility.FromJson<JsonDataManager>(dataAsJson).data;
    }

    public void LoadFiles(string file)
    {
        assetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, file));
    }
    #endregion
    #endregion
}

