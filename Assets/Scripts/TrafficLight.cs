using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public Light RedLight;
    public Light YellowLight;
    public Light GreenLight;
   /* public Material RedGlass;
    public Material YellowGlass;
    public Material GreenGlass;*/
    public float Timer;
    public float AlphaValue = 0.5f;
    [SerializeField] private GameObject _redGlass;
    [SerializeField] private GameObject _yellowGlass;
    [SerializeField] private GameObject _greenGlass;





    void Update()
    {
        Timer = Timer*1.5f + Time.deltaTime;
        if (Timer > 4)
            Timer = 0;

        switch (Mathf.FloorToInt(Timer))
        {
            case 1:
                RedLight.color = Color.red;
                YellowLight.color = Color.black;
                GreenLight.color = Color.black;
                /*SetMaterialAlpha(RedGlass, alphaValue);
                SetMaterialAlpha(GreenGlass, 0f);
                SetMaterialAlpha(YellowGlass, 0f);*/
                _redGlass.SetActive(true);
                _yellowGlass.SetActive(false);
                _greenGlass.SetActive(false);


                break;

            case 2:
                RedLight.color = Color.black;
                YellowLight.color = Color.yellow;
                GreenLight.color = Color.black;
                /*SetMaterialAlpha(YellowGlass, alphaValue);
                SetMaterialAlpha(RedGlass, 0f);
                SetMaterialAlpha(GreenGlass, 0f);*/
                _redGlass.SetActive(false);
                _yellowGlass.SetActive(true);
                _greenGlass.SetActive(false);

                break;

            case 3:
                RedLight.color = Color.black;
                YellowLight.color = Color.black;
                GreenLight.color = Color.green;
                /*SetMaterialAlpha(GreenGlass, alphaValue);
                SetMaterialAlpha(RedGlass, 0f);
                SetMaterialAlpha(YellowGlass, 0f);*/
                _redGlass.SetActive(false);
                _yellowGlass.SetActive(false);
                _greenGlass.SetActive(true);


                break;
        }
    }

   /* void SetMaterialAlpha(Material material, float alpha)
    {
        Color color = material.color;
        color.a = alpha;
        material.color = color;
        
    }
*/

}