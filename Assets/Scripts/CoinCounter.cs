using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] public int CoinCount;
    [SerializeField] public GameObject YouWon;
    /*[SerializeField] public GameObject _shakingCamera;*/
    /*[SerializeField] AudioSource _congratulations;*/
    [SerializeField] private AudioSource _crash;
    [SerializeField] private AudioSource _openedParty;
    [SerializeField] private AudioSource _closedParty;
    [SerializeField] GameObject Door;
    [SerializeField] private GameObject _marks;
    // Start is called before the first frame update
    void Start()
    {
        CoinCount = 0;
        YouWon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CoinCount == 9)
        {
            if (_closedParty.isPlaying)
            {
                _closedParty.Stop();
                _crash.Play();
                Door.SetActive(false);
                _marks.SetActive(true);
                _openedParty.Play();
            }
        }
       /* if (CoinCount == 9)
        {
            if (!_openedParty.isPlaying)
            {
                _openedParty.Play();
                
            }*/
        /*}*/
        if (CoinCount == 10)
        {
            YouWon.SetActive(true);
        }
    }
}
