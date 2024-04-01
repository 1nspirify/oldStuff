using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float _rotationSpeed;
    [SerializeField] Transform GameObject;
    [SerializeField] public Transform PlayerPosition;
    [SerializeField] private GameObject _flies;
    [SerializeField] private AudioSource _chpock;
    [SerializeField] private GameObject _effect;


    /* [SerializeField]  AudioSource _grabCoin;*/


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotationAngle = _rotationSpeed * Time.deltaTime;

        
        _flies.transform.Rotate(0f, 0f, rotationAngle);

     
        float distance = Vector3.Distance(transform.position, PlayerPosition.position);
        Debug.Log(distance);
        if (distance < 1.5)
        {
            FindObjectOfType<CoinCounter>().CoinCount++;
            _chpock.Play();
            Destroy(gameObject);
            Instantiate(_effect, transform.position, transform.rotation);


        }
       


        
    }
  
    
    
    
        
       
  
}