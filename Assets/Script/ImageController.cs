using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageController : MonoBehaviour
{
    public GameObject[] ImagePrefab;

    bool flag = true;
    //public void imageGenerator()
    //{
    private void Update()
    {

        if (flag)
        {

            GameObject imageObject = (GameObject)Instantiate(ImagePrefab[0], this.gameObject.transform.position, Quaternion.identity);
            GameObject imageObject2 = (GameObject)Instantiate(ImagePrefab[1], this.gameObject.transform.position, Quaternion.identity);
            GameObject imageObject3 = (GameObject)Instantiate(ImagePrefab[2], this.gameObject.transform.position, Quaternion.identity);
        }
        flag = false;
    }
        //}
 
}
