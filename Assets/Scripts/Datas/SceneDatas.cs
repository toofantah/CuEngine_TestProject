
/// ----ToofanTahmoures---2021-----
/// This is a template Script for MonoBehaviors Scripts suggested for editing
/// Please check out the naming convention Manuals Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Editable version Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Please duplicate the scripts ligns bellow in the "TemplatesScriptsMonoBehaviour.c" or script and leave it empty, you can duplicate this into a script newly made by you in the editor, 
/// or set up this template as a default unity emplate Script each time you generate a new empty script with replacing this file: https://1drv.ms/t/s!AgDnFacvwTrJgaQ2RrAA6EKnFilrAA?e=TJsnDj :)



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;



/// <summary>
/// Getting all instance from the Scene
/// </summary>

public static class SceneDatas 
{
    #region PRIVATE_VARIABLES
    #endregion
    #region PUBLIC_VARIABLES
    #endregion
    #region MONOBEHAVIOUR_METHODS
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment
   
    #endregion
    #region PMONOBEHAVIOUR_METHODS_PUBLIC
    #endregion
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS
    #region NON_MONOBEHAVIOUR_METHODS_PRIVATE
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS_PUBLIC
    public static List<Transform> GetChildren(this Transform parent, List<Transform> transforms=null)
    {
        transforms = new List<Transform>();
        foreach (Transform child in parent)
        {
            transforms.Add(child);
            child.GetChildren(transforms);
        }
        return transforms;
    }

    public static List<Transform> SceneTransforms(this Scene sceneTransforms)
    {
        List<Transform> gameObjects = new List<Transform>();





        GameObject[] root = sceneTransforms.GetRootGameObjects();

        for (int i = 0; i < root.Length; i++)
        {
            gameObjects.Add(root[i].transform);

            List<Transform> childiren = root[i].transform.GetChildren();
            foreach (Transform child in childiren)
            {
                gameObjects.Add(child);
            }
        }
        return gameObjects;
    }

    #endregion
    #endregion
}

