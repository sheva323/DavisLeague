using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PhotoSave : MonoBehaviour
{
        private Image img1;
        public GameObject MyImage;


        // Start is called before the first frame update
        void Start()
        {
            MyImage.AddComponent(typeof(Image));
            img1 = Resources.Load<Image>("Assets/Images/ButtonOption.png");
        img1 = gameObject.GetComponent<Image>();   
        //MyImage.GetComponent<Image>() = img1;
        //MyImage.AddComponent<Image>().sprite = img1;

            Debug.Log("Test script started");
        }

}
