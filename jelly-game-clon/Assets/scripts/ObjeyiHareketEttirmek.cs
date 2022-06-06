using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeyiHareketEttirmek : MonoBehaviour
{
    public Camera cam;
    public Rigidbody rb;
    private bool oyunDevamEdiyorMu=true;

    public float ObjeninDikeyYatayHareketi;
    public float hiz;
    public float lerpValue = 4;
    public float minY,maxY;
    public float minX, maxX;
    
    private bool oyunBitti;

    void Start()
    {
        cam=Camera.main;
        
    }
    
    void Update()
    {
        
        if (Input.GetButton("Fire1"))
        {
            ObjeninSekliniDegistirmek();
        }

        if (oyunDevamEdiyorMu)
        {
            rb.velocity = Vector3.forward * hiz * 10 *Time.deltaTime;  //obje sabit hizda ileri hareket eiyor
        }


          
    }
    //OBJEYÝ AÞAGI VE YUKARI HAREKKET ETTÝRMEK
    public void ObjeninSekliniDegistirmek()
    {
        Vector3 mausePozisyonu = Input.mousePosition;
        mausePozisyonu.z = 10;

        Vector3 mauseyiHareketi = cam.ScreenToWorldPoint(mausePozisyonu);

        float x = transform.localScale.x;
        mauseyiHareketi.z = transform.localScale.z;
        mauseyiHareketi.y *= 2f;

        //clamp-minimum ve maxsimum alacagi deger..
        //eger clamp olmazsa.. durmadan buyumeye devam eder.
       
        mauseyiHareketi.y = Mathf.Clamp(mauseyiHareketi.y, minY, maxY); //en fazla ve en az y degerleri




        x = maxY / mauseyiHareketi.y;      // en asagidayken x 10 dur  // y artikca x azalir

        mauseyiHareketi.x = Mathf.Clamp(x,minX,maxX);   //en fazla ve en az x degerleri

        transform.localScale = mauseyiHareketi;

        
    }
      
}
