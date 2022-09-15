using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationScript : MonoBehaviour
{
    public GameObject MSG1;
    public GameObject MSG2;
    public GameObject MSG3;
    public GameObject MSG4;

    public Animator Animator;
    private void Start()
    {
        MSG1.SetActive(false);
        MSG2.SetActive(false);
        MSG3.SetActive(false);
        MSG4.SetActive(false);

        Message1();
    }
    public void Message1() { 
    IEnumerator wait() {
            MSG1.SetActive(true);
            yield return new WaitForSeconds(3);
            MSG1.SetActive(false);
            Message2();
        }
        StartCoroutine(wait());
    }
    public void Message2() {
        IEnumerator wait()
        {
            MSG2.SetActive(true);
            yield return new WaitForSeconds(3);
            MSG2.SetActive(false);
            Message3();
        }
        StartCoroutine(wait());
    }
    public void Message3() {
        IEnumerator wait()
        {
            MSG3.SetActive(true);
            yield return new WaitForSeconds(3);
            MSG3.SetActive(false);
            Message4();
        }
        StartCoroutine(wait());
    }
    public void Message4() {
        IEnumerator wait()
        {
            MSG4.SetActive(true);
            yield return new WaitForSeconds(3);
            MSG4.SetActive(false);
            SceneManager.LoadScene(2);
        }
        StartCoroutine(wait());
    }


}
