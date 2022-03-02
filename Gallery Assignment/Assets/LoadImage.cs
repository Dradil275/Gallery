
using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour
{
    public Image[] ImgArr = new Image[11];
  
    // Use this for initialization
    void Start()
    {

        StartCoroutine("load_image");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator load_image()
    {
  
        string[] filePaths = Directory.GetFiles(@"D:\Pictures\Unity assets\Pictures\11 pics", "*.jpg");
        for(int i = 0; i < filePaths.Length; i++)
        {
            
            
            WWW www = new WWW("file://" + filePaths[i]);
            yield return www;
            Texture2D new_texture = new Texture2D(512, 512);
            www.LoadImageIntoTexture(new_texture);
            Sprite new_Sprite = Sprite.Create(new_texture, new Rect(0, 0, new_texture.width, new_texture.height), new Vector2(0.5f, 0.5f));
            ImgArr[i].GetComponent<Image>().sprite = new_Sprite;
        }
            
      
            
    }
}

