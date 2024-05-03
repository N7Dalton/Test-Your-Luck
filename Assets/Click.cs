using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameManager GameManager;
    public AudioSource AudioSource;
    public float amount;
        
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        StartCoroutine("Clicks");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Clicks()
    {
        yield return new WaitForSeconds(10);
        GameManager.TotalClicks += amount;
        AudioSource.Play();
        StartCoroutine("Clicks");
    }
}
