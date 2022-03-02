using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class ImageClick : MonoBehaviour
{
    public GameObject Canvas;
    GraphicRaycaster ui_raycaster;
    PointerEventData clickData;
    List<RaycastResult> clickResults;
    public GameObject BigImage;

    void Start()
    {
        ui_raycaster = Canvas.GetComponent<GraphicRaycaster>();
        clickData = new PointerEventData(EventSystem.current);
        clickResults = new List<RaycastResult>();
        BigImage.SetActive(false);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           // UIclick();
        }
    }
    public void UIclick()
    {
        clickData.position = Input.mousePosition;
        clickResults.Clear();
        ui_raycaster.Raycast(clickData, clickResults);
        foreach(RaycastResult result in clickResults)
        {
            
        }
    }
        public void ClickImage(Image Pic)
        {
            BigImage.SetActive(true);
            BigImage.GetComponent<Image>().sprite = Pic.GetComponent<Image>().sprite;
            

        }

    public void CloseImage()
    {
        BigImage.GetComponent<Image>().sprite = null;
        BigImage.SetActive(false);
    }

    }



