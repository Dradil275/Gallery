using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class ImageClick : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Scrollbar;
    public GameObject BigImage;


    void Start()
    {
        
        BigImage.SetActive(false);
    }


  public void ClickImage(Image Pic)
   {
        Scrollbar.SetActive(false);
     BigImage.SetActive(true);
     BigImage.GetComponent<Image>().sprite = Pic.GetComponent<Image>().sprite;
   }

    public void CloseImage()
    {
        Scrollbar.SetActive(true);
        BigImage.GetComponent<Image>().sprite = null;
        BigImage.SetActive(false);
    }

    }



