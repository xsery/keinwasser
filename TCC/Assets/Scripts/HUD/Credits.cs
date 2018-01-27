using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public int interval;
    public Image imCredits;
    public Text txCredits;
    public GameObject im_soon;
    public GameObject tx_credits;
    public Sprite credits1;
    public Sprite credits2;
    public Sprite credits3;
    public Sprite credits4;
    public Sprite credits5;
    public Sprite credits6;
    public Sprite credits7;
    public Sprite credits8;
    public Sprite credits9;
    public Sprite credits10;
    public AudioSource button;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("credits");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator credits()
    {
        //Credits1
        txCredits.text = "\n\n\n\n\n\nKein Wasser";
        imCredits.sprite = credits1;
        tx_credits.SetActive(true);
        yield return new WaitForSeconds((interval / 2));
        tx_credits.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        txCredits.text = "\n\n\nProgramadores:\n\nFrancisca Augusto,\nLuis Henrique,\nSamuel Queiroz e\nTiago Parente";
        imCredits.sprite = credits2;
        tx_credits.SetActive(true);
        //Credits2
        yield return new WaitForSeconds((interval / 2));
        tx_credits.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        txCredits.text = "\n\n\n\nDesigners:\n\nDeny Monteiro\ne\nThiago Calazans";
        imCredits.sprite = credits3;
        tx_credits.SetActive(true);
        //Credits3
        yield return new WaitForSeconds((interval / 2));
        tx_credits.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        txCredits.text = "\n\n\n\nDesigners de Som:\n\nMatheus Casalotti\ne\nFúlvio Casalotti";
        imCredits.sprite = credits4;
        tx_credits.SetActive(true);
        //Credits4
        yield return new WaitForSeconds((interval / 2));
        tx_credits.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        txCredits.text = "\n\n\n\nDubladores:\n\nNelson Neto                      Kein\nSamuel Queiroz    Geist(Brise)\nMayara Silva              Weisheit";
        imCredits.sprite = credits5;
        tx_credits.SetActive(true);
        //Credits5
        yield return new WaitForSeconds((interval / 2));
        tx_credits.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        txCredits.text = "\n\n\n\nDubladores:\n\nLaura Benayon                    Reinheit\nFúlvio Casalotti     Rei Bestante(Tier)";
        imCredits.sprite = credits6;
        tx_credits.SetActive(true);
        //Credits6
        yield return new WaitForSeconds((interval / 2));
        tx_credits.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        txCredits.text = "\n\n\n\nDubladores:\n\nMatheus Casalotti     Kommandant\nFrancisca Augusto            Layouna";
        imCredits.sprite = credits7;
        tx_credits.SetActive(true);
        //Credits7
        yield return new WaitForSeconds((interval / 2));
        tx_credits.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        txCredits.text = "\n\n\n\nDubladores:\n\nTiago Parente                        Tertulius\nElisa Benayon                    Unschuldig\nThiago Calazans Weissmann(Feuer)";
        imCredits.sprite = credits8;
        tx_credits.SetActive(true);
        //Credits8
        yield return new WaitForSeconds((interval / 2));
        tx_credits.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        txCredits.text = "\n\n\n\nOrientadora:\nCristina Araujo\n\nCo-orientador:\nRicardo Maginator";
        imCredits.sprite = credits9;
        tx_credits.SetActive(true);
        //Credits9
        yield return new WaitForSeconds((interval / 2));
        tx_credits.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        imCredits.sprite = credits10;
        im_soon.SetActive(true);
        //Credits10
        yield return new WaitForSeconds((interval / 2));
        im_soon.SetActive(false);
        yield return new WaitForSeconds((interval / 2));
        StartCoroutine("menu");
    }

    public void goMenu()
    {
        StartCoroutine("menu");
    }

    IEnumerator menu()
    {
        button.Play();
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Menu/Menu");
    }
}
