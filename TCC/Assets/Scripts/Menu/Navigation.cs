using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Navigation : MonoBehaviour {

	public void playGame(){

		SceneManager.LoadScene ("Level1");

	}

}


	/*
    public AudioSource button;

    public void playBeginningOfArc1Past(){
        button.Play();
        StartCoroutine("BeginningOfArc1Past");
    }

    public void playBeginningOfArc1House()
    {
        button.Play();
        StartCoroutine("BeginningOfArc1House");
    }

    public void playBeginningOfArc1Input()
    {
        button.Play();
        StartCoroutine("BeginningOfArc1Input");
    }

    public void playEndOfArc1()
    {
        button.Play();
        StartCoroutine("EndOfArc1");
    }

    public void playBeginningOfArc2Escape()
    {
        button.Play();
        StartCoroutine("BeginningOfArc2Escape");
    }

    public void playBeginningOfArc2Input()
    {
        button.Play();
        StartCoroutine("BeginningOfArc2Input");
    }

    public void playBeginningOfArc2Running()
    {
        button.Play();
        StartCoroutine("BeginningOfArc2Running");
    }

    public void playEndOfArc2Past()
    {
        button.Play();
        StartCoroutine("EndOfArc2Past");
    }

    public void playEndOfArc2Present()
    {
        button.Play();
        StartCoroutine("EndOfArc2Present");
    }

    public void playEndOfArc2ReturnToThePresent()
    {
        button.Play();
        StartCoroutine("EndOfArc2ReturnToThePresent");
    }

    public void playBeginningOfArc3()
    {
        button.Play();
        StartCoroutine("BeginningOfArc3");
    }

    public void playEndOfArc3Past()
    {
        button.Play();
        StartCoroutine("EndOfArc3Past");
    }

    public void playEndOfArc3Present()
    {
        button.Play();
        StartCoroutine("EndOfArc3Present");
    }

    public void playEndOfArc3ReturnToThePresent()
    {
        button.Play();
        StartCoroutine("EndOfArc3ReturnToThePresent");
    }

    public void playBeginningOfArc4()
    {
        button.Play();
        StartCoroutine("BeginningOfArc4");
    }

    public void playBeginningOfTheFinalBattle()
    {
        button.Play();
        StartCoroutine("BeginningOfTheFinalBattle");
    }

    public void playEndOfArc4Dam()
    {
        button.Play();
        StartCoroutine("EndOfArc4Dam");
    }

    public void playEndOfArc4DamEntrance()
    {
        button.Play();
        StartCoroutine("EndOfArc4DamEntrance");
    }

    public void playMiddleOfTheFinalBattlePast()
    {
        button.Play();
        StartCoroutine("MiddleOfTheFinalBattlePast");
    }

    public void playMiddleOfTheFinalBattlePresent()
    {
        button.Play();
        StartCoroutine("MiddleOfTheFinalBattlePresent");
    }

    public void playMiddleOfTheFinalBattleReturnToThePresent()
    {
        button.Play();
        StartCoroutine("MiddleOfTheFinalBattleReturnToThePresent");
    }

    public void playArc1Part1and2and3()
    {
        button.Play();
        StartCoroutine("Arc1Part1and2and3");
    }

    public void playArc2Part1()
    {
        button.Play();
        StartCoroutine("Arc2Part1");
    }

    public void playArc2Part2And3()
    {
        button.Play();
        StartCoroutine("Arc2Part2And3");
    }

    public void playArc3Part1()
    {
        button.Play();
        StartCoroutine("Arc3Part1");
    }

    public void playArc3Part2()
    {
        button.Play();
        StartCoroutine("Arc3Part2");
    }

    public void playArc3Part3()
    {
        button.Play();
        StartCoroutine("Arc3Part3");
    }

    public void playArc4Part1()
    {
        button.Play();
        StartCoroutine("Arc4Part1");
    }

    public void playArc4Part2()
    {
        button.Play();
        StartCoroutine("Arc4Part2");
    }

    public void playArc4Part3()
    {
        StartCoroutine("Arc4Part3");
    }

    public void playArc4Part4()
    {
        button.Play();
        StartCoroutine("Arc4Part4");
    }

    public void playCredits()
    {
        button.Play();
        StartCoroutine("Credits");
    }

    IEnumerator BeginningOfArc1Past()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow1/BeginningOfArc1Past");
    }

    IEnumerator BeginningOfArc1House()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow1/BeginningOfArc1House");
    }

    IEnumerator BeginningOfArc1Input()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow1/BeginningOfArc1Input");
    }


    IEnumerator EndOfArc1()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow1/EndOfArc1");
    }


    IEnumerator BeginningOfArc2Escape()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow2/BeginningOfArc2Escape");
    }


    IEnumerator BeginningOfArc2Input()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow2/BeginningOfArc2Input");
    }

    IEnumerator BeginningOfArc2Running()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow2/BeginningOfArc2Running");
    }

    IEnumerator EndOfArc2Past()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow2/EndOfArc2Past");
    }

    IEnumerator EndOfArc2Present()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow2/EndOfArc2Present");
    }

    IEnumerator EndOfArc2ReturnToThePresent()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow2/EndOfArc2ReturnToThePresent");
    }

    IEnumerator BeginningOfArc3()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow3/BeginningOfArc3");
    }

    IEnumerator EndOfArc3Past()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow3/EndOfArc3Past");
    }

    IEnumerator EndOfArc3Present()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow3/EndOfArc3Present");
    }

    IEnumerator EndOfArc3ReturnToThePresent()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow3/EndOfArc3ReturnToThePresent");
    }

    IEnumerator BeginningOfArc4()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow4/BeginningOfArc4");
    }

    IEnumerator BeginningOfTheFinalBattle()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow4/BeginningOfTheFinalBattle");
    }

    IEnumerator EndOfArc4Dam()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow4/EndOfArc4Dam");
    }

    IEnumerator EndOfArc4DamEntrance()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow4/EndOfArc4DamEntrance");
    }

    IEnumerator MiddleOfTheFinalBattlePast()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow4/MiddleOfTheFinalBattlePast");
    }

    IEnumerator MiddleOfTheFinalBattlePresent()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow4/MiddleOfTheFinalBattlePresent");
    }

    IEnumerator MiddleOfTheFinalBattleReturnToThePresent()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Narrative/Bow4/MiddleOfTheFinalBattleReturnToThePresent");
    }

    IEnumerator Arc1Part1and2and3()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow1/Arc1Part1and2and3");
    }

    IEnumerator Arc2Part1()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow2/Arc2Part1");
    }

    IEnumerator Arc2Part2And3()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow2/Arc2Part2And3");
    }

    IEnumerator Arc3Part1()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow3/Arc3Part1");
    }

    IEnumerator Arc3Part2()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow3/Arc3Part2");
    }

    IEnumerator Arc3Part3()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow3/Arc3Part3");
    }

    IEnumerator Arc4Part1()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow4/Arc4Part1");
    }

    IEnumerator Arc4Part2()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow4/Arc4Part2");
    }

    IEnumerator Arc4Part3()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow4/Arc4Part3");
    }

    IEnumerator Arc4Part4()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Stages/Bow4/Arc4Part4");
    }

    IEnumerator Credits()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Extra/Credits");
    }

*/



