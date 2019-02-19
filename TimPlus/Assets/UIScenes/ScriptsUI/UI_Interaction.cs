using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Interaction : MonoBehaviour {
    public int currentPage;
    public GameObject[] UIPages;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangePage(UI_ButtonInfo ButtonInfo) {

        if (ButtonInfo.condition == 1)
        {

            UIPages[currentPage].SetActive(false);
            UIPages[ButtonInfo.index].SetActive(true);
            currentPage = ButtonInfo.index;

        }
        else if (ButtonInfo.condition == 2)
        {

            UIPages[currentPage].SetActive(false);
            UIPages[ButtonInfo.alternativeindex[1]].SetActive(true);
            currentPage = ButtonInfo.alternativeindex[1];

        }
        else if (ButtonInfo.condition == 3) {
            UIPages[currentPage].SetActive(false);
            UIPages[ButtonInfo.index].SetActive(true);
            UIPages[ButtonInfo.index].GetComponent<UIPageWithRedirects>().lastpage = currentPage;
            currentPage = ButtonInfo.index;

        }



    }
}
