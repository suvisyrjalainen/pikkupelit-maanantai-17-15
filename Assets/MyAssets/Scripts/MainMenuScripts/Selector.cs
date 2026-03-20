using UnityEngine;
using TMPro;

public class Selector : MonoBehaviour
{
    public TMP_Text[] items;

    public Color normalColor;
    public Color highlightColor;

    private int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateColors();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.DownArrow)){
            
            index += 1;
            if(index == items.Length){
                index = 0;
            }
            Debug.Log(index);
            UpdateColors();
        }

        if(Input.GetKeyDown(KeyCode.UpArrow)){

            index -= 1;
            if(index < 0){
                index = items.Length - 1;
            }
            Debug.Log(index);
            UpdateColors();
        }

        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)){
            ActivateItem(index);
        }
        
    }

    void UpdateColors(){

        for(int i=0; i < items.Length; i++){

            if(i==index){
                items[i].color = highlightColor;
            }
            else{
                items[i].color = normalColor;
            }
        }
    }

    public void ActivateItem(int i){
        
        if(items[i].text == "Pikkupelit"){
            Debug.Log("Selected: " + items[i].text);
        }
        else if(items[i].text == "Asetukset"){
            Debug.Log("Selected: " + items[i].text);
        }
        else if(items[i].text == "Lopeta peli"){
            Debug.Log("Selected: " + items[i].text);
        }


    }
}
