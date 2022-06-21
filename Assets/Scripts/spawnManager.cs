using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public int maxPowerUpAmount; 
    public int spawnInterval; 
    public List<GameObject> powerUpTemplateList;
    private float timer;
    private List<GameObject> powerUpList; 
     
    private void Start() 
    { 
        powerUpList = new List<GameObject>(); 
        timer = 0;
    } 
    private void Update() 
    { 
        timer += Time.deltaTime;
 
        if (timer > spawnInterval) 
        { 
            // mengecek jika jumlah powerUp sudah maksimal
            if (powerUpList.Count < maxPowerUpAmount) 
            { 
                GenerateRandomPowerUp(); 
            } 
            // membuat powerUp baru
            timer -= spawnInterval; 
        }
        
    } 
 
    // method for spawn powerUP in area spawn
    public void GenerateRandomPowerUp() 
    { 
        if (powerUpList.Count >= maxPowerUpAmount) 
        { 
            return; 
        } 
 
        int randomIndex = Random.Range(0, powerUpTemplateList.Count); 
 
        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex]); 
        powerUp.SetActive(true); 
 
        powerUpList.Add(powerUp); 
    } 

    // method for delete powerUp in list
    public void removeBall(GameObject powerUp) 
    { 
        powerUpList.Remove(powerUp); 
        Destroy(powerUp);
    } 
 
    public void removeAllBall() 
    { 
        while (powerUpList.Count > 0) 
        { 
            removeBall(powerUpList[0]); 
        } 
    } 
}
