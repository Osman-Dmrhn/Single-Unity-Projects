using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayioyunu : MonoBehaviour
{
    // Start is called before the first frame update
    int min = 1, max = 100;
    int tahmin;
    bool oyunbasladi = false;
    bool oyunbitti = false;
    void Start()
    {
        Debug.Log("Benimle oyun oynamak ister misin? E/H");
    }

    // Update is called once per frame
    void Update()
    {
        if (!oyunbasladi)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Aklýndan 1-100 arasýnda bir sayý tut ve Enter'a bas");
                
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                Debug.Log("Okey");
            }
            else if(Input.GetKeyDown(KeyCode.Return))
            {
                kontrol();
                oyunbasladi = true;
            }
        }
        //oyun baþladýysa
        if (oyunbasladi && !oyunbitti)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = tahmin;
                kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = tahmin;
                kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                oyunbitti = true;
                Debug.Log("Buldum");
            }
        }



    }

    void kontrol()
    {
        tahmin = (min + max) / 2;
        Debug.Log("Tuttuðun sayý" + tahmin + "mi? Tuttuðun sayý büyükse yukarý tuþuna ,küçükse aþþaðý tuþuna,doðruysa space tuþuna bas");
    }
}
