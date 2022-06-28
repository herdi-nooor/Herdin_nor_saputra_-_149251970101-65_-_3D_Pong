using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public int maxPowerUpAmount, spawnInterval; 
    public List<GameObject> ballTemplateList;
    private float timer;
    [HideInInspector] public List<GameObject> ballList; 
     
    private void Start() 
    { 
        ballList = new List<GameObject>(); 
        timer = 0;
    } 
    private void Update() 
    { 
        timer += Time.deltaTime;
 
        if (timer > spawnInterval) 
        { 
            // mengecek jika jumlah powerUp sudah maksimal
            if (ballList.Count < maxPowerUpAmount) 
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
        if (ballList.Count >= maxPowerUpAmount) 
        { 
            return; 
        } 
 
        int randomIndex = Random.Range(0, ballTemplateList.Count); 
 
        GameObject ball = Instantiate(ballTemplateList[randomIndex]); 
        ball.SetActive(true); 
 
        ballList.Add(ball); 
    } 

    // method for delete powerUp in list
    public void removeBall(GameObject ball) 
    { 
        ballList.Remove(ball); 
        Destroy(ball);
    } 
    public void removeAllBall() 
    { 
        while (ballList.Count > 0)
        {
            removeBall(ballList[0]);
        }
    } 
}
