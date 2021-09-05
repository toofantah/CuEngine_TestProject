
/// ----ToofanTahmoures---2021-----
/// This is a template Script for MonoBehaviors Scripts suggested for editing
/// Please check out the naming convention Manuals Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Editable version Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Please duplicate the scripts ligns bellow in the "TemplatesScriptsMonoBehaviour.c" or script and leave it empty, you can duplicate this into a script newly made by you in the editor, 
/// or set up this template as a default unity emplate Script each time you generate a new empty script with replacing this file: https://1drv.ms/t/s!AgDnFacvwTrJgaQ2RrAA6EKnFilrAA?e=TJsnDj :)



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Please mention your classe use or introduction here (this is  a template class for demo)
/// </summary>

public class UIPanels : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    private RawImage _image;
    [SerializeField]
    private RectTransform _gridPanel;
    [SerializeField]
    private RectTransform _imagePannel;
    #endregion
    #region PUBLIC_VARIABLES
    #endregion
    #region MONOBEHAVIOUR_METHODS
    void Start()
    {
        AssetDatas aData = AssetController.Instance.data();
        DownloadManager.Instance.DownloadTextures(aData.data.URL.ToArray(), (IMG) => { LoadImages(IMG); });
    }
    #region PMONOBEHAVIOUR_METHODS_PUBLIC
    public void ImageView(RawImage image)
    {
        _image.texture = image.texture;
        UIManager.Instance.SwitchPanel(1);
    }

    private void LoadImages(Texture2D[] tex)
    {
        for (int i = 0; i < tex.Length; i++)
        {
            RawImage image = new GameObject(string.Format("Texture [{0}]", i), typeof(RawImage), typeof(Button)).GetComponent<RawImage>();
            image.rectTransform.SetParent(_gridPanel, false);
            image.texture = tex[i];

            Button btn = image.GetComponent<Button>();
            btn.onClick.AddListener(() => ImageView(image));
        }

        _image = new GameObject("_image", typeof(RawImage)).GetComponent<RawImage>();
        _image.rectTransform.SetParent(_imagePannel);

    }
    #endregion
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment
    private void Update()
    {
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

