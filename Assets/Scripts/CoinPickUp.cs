using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinPickUp : MonoBehaviour
{
    private int coin = 0;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin") //check for coin tag
        {
            Destroy(other.gameObject);
            coin++; //adds one to coin
        }

        if(coin >= 10) //if you collect 10 coins
        {
            SceneManager.LoadScene("End");//gameover scene
        }
    }



}
