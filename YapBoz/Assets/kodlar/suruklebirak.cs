using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class suruklebirak : MonoBehaviour
{
    public GameObject levelekrani;
    public GameObject yapbozParca;
    int katman = 1;
    public int YapbozSayisi = 0;

    public float sure=0;
    public Text zamanText;
    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        sure += Time.deltaTime;
        zamanText.text = " "+(int) sure;
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("yapbozParcalari"))
            {
                if (!hit.transform.GetComponent<yapbozParca>().yerlestimi)
                {
                    yapbozParca = hit.transform.gameObject;
                    yapbozParca.GetComponent<yapbozParca>().secildimi = true;
                    yapbozParca.GetComponent<SortingGroup>().sortingOrder = katman;
                    katman++;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (yapbozParca != null)
            {
                yapbozParca.GetComponent<yapbozParca>().secildimi = false;
                yapbozParca = null;
            }
        }
        if (yapbozParca != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            yapbozParca.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
        if (YapbozSayisi == 36)
        {
            Time.timeScale = 0;
            levelekrani.SetActive(true);
        }
    }
}