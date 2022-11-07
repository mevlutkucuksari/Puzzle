using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class yapbozParca : MonoBehaviour
{
    public Vector3 ilkPozisyon;
    public bool yerlestimi;
    public bool secildimi;
    public int katman = 0;
    


    void Start()
    {
        ilkPozisyon = transform.position;
        transform.position = new Vector2(Random.Range(1.23f, 7f), Random.Range(-2.8f, 2.26f));
    }
    
    void Update()
    {
        if (Vector3.Distance(transform.position, ilkPozisyon) < 0.5f)
        {
            if (!secildimi)
            {
                if (yerlestimi == false)
                {
                    transform.position = ilkPozisyon;
                    yerlestimi = true;
                   GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<suruklebirak>().YapbozSayisi++;
                }
            }
        }


    }

}
