using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ImageLoader : MonoBehaviour
{
    public Image[] ImgArray = new Image[11];
    object[] textures;
    public string url = "file//D:/Pictures/Unity assets/Pictures/11 pics/The-Starry-Night.jpg";
    public Image thisRenderer;
    WWW wwwloader;
    private object wwwLoader;

    void Start()
    {
        StartCoroutine(LoadFromLikeCoroutine());
        
    }

    private IEnumerator LoadFromLikeCoroutine()
    {
        Debug.Log("loading...");
        
        wwwloader = new WWW("file//D:/Pictures/Unity assets/Pictures//11 pics/The-Starry-Night.jpg"); 
        yield return wwwloader;
        Debug.Log("loaded");
        thisRenderer.material.color = Color.white;
        thisRenderer.material.mainTexture = wwwloader.texture;
        WWW loader = wwwloader;
        thisRenderer.sprite = Sprite.Create(loader.texture, new Rect(0, 0, loader.texture.width, loader.texture.height), Vector2.one / 2);

    }

    

}
