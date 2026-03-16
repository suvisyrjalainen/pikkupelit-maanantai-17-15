using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeController : MonoBehaviour
{

    public Image fadePanel;

    public float fadeDuration = 2f;

    private Color originalColor;
    
    void Awake()
    {

         originalColor = fadePanel.color;
        
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fadeIn(){
        StartCoroutine(FadeRoutine(originalColor.a));
    }

    public void fadeOut(){
        StartCoroutine(FadeRoutine(0f));
    }

    private IEnumerator FadeRoutine(float targetAlpha){

        
        float time = 0f;

        float startAlpha = fadePanel.color.a;

        while(time < fadeDuration){

            //Lisätään kulunut aika edellisestä framesta
            time += Time.deltaTime;

            //Tällä saadaan 0-1 väliltä kerroin t seuraavaa vaihetta varten
            float t = time / fadeDuration;

            //Luetaan paneelin väri ennen muutosta
            Color c = fadePanel.color;

            c.a = Mathf.Lerp(startAlpha, targetAlpha, t);

            
            fadePanel.color = c;



            yield return null;
        }


        
        
        
       

    }
}
