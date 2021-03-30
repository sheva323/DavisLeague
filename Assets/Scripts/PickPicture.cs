using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickPicture : MonoBehaviour
{
	public Image Picture;
    private void Start()
    {
        if (PlayerPrefs.GetString("picturepath") != "")
        {
			LoadPicture(512);
        }
    }
    public void PickImage(int maxSize)
	{
		NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
		{
			Debug.Log("Image path: " + path);
			if (path != null)
			{
				// Create Texture from selected image
				Texture2D texture = NativeGallery.LoadImageAtPath(path, maxSize);
				texture.filterMode = FilterMode.Point;

				Picture.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
				Picture.preserveAspect = true;
				PlayerPrefs.SetString("picturepath", path);
			}
		}, "Select a PNG image", "image/png");

		Debug.Log("Permission result: " + permission);
	}
	public void LoadPicture(int maxSize)
    {
		Texture2D texture = NativeGallery.LoadImageAtPath(PlayerPrefs.GetString("picturepath"), maxSize);
		texture.filterMode = FilterMode.Point;
		Picture.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
		Picture.preserveAspect = true;
	}
}
