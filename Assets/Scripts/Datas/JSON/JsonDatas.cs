
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
/// A Script for json data structs.
/// urls are defined as strings. 
/// </summary>

[System.Serializable]
public class JsonDatas
{
    #region PRIVATE_VARIABLES
    #endregion
    #region PUBLIC_VARIABLES

    public List<string> URL;
    public List<Position> positions;
    
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
    public JsonDatas()
    {
        URL = new List<string>();
        positions = new List<Position>();

    }
    #endregion
    #endregion
}

/// <summary>
/// a class for parse datas from json datas and load files to the controller.
/// </summary>

[System.Serializable]
public class AssetDatas
{
    #region PRIVATE_VARIABLES
    #endregion
    #region PUBLIC_VARIABLES

    public JsonDatas data;
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
    public void parsFromJson(string fileName)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);
        Debug.Log(filePath);
        string dataAsJson = File.ReadAllText(filePath);
        data = JsonUtility.FromJson<AssetDatas>(dataAsJson).data;
    }

    public void LoadFiles(string file)
    {
        assetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, file));
    }
    #endregion
    #endregion
}

