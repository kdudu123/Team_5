using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Coin : MonoBehaviour
{

    public float rotateSpeed = 100f;
    [System.NonSerialized]
    public int money = 100;
    public int cc = 0;
    
    void Start()
    {
        
    }


    public void SetCoinValue(int money)
    {
        this.money = money;
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag =="Player")
        {

            cc += 1;

            if (cc == 5)
            {


                {
                    SceneManager.LoadScene("GameOver");
                }
            }

            Destroy(gameObject);
                     

        
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
        
    }
}
