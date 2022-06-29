using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public int maxPowerUpAmount, spawnInterval; 
    public List<GameObject> ballTemplateList;
    public List<GameObject> powerUpTemplateList;
    [HideInInspector] public List<GameObject> ballList; 
    [HideInInspector] public List<GameObject> powerUpList;
    [HideInInspector] public float timerBall;
    [HideInInspector] public float timerPowerUp;
     
    private void Start() 
    { 
        ballList = new List<GameObject>();
        powerUpList = new List<GameObject>();
        timerBall = 0;
        timerPowerUp = 0;
    } 
    private void Update() 
    { 
        spawnBall();
        spawnpowerUP();
    } 

    private void spawnBall()
    {
        timerBall += Time.deltaTime;
 
        if (timerBall > spawnInterval) 
        { 
            // mengecek jika jumlah powerUp sudah maksimal
            if (ballList.Count < maxPowerUpAmount) 
            { 
                GenerateRandomBall(); 
            } 
            // membuat powerUp baru
            timerBall -= spawnInterval; 
        }
    }
    private void spawnpowerUP()
    {
        timerPowerUp += Time.deltaTime;
 
        if (timerPowerUp > 5) 
        { 
            // mengecek jika jumlah powerUp sudah maksimal
            if (powerUpList.Count > 1)
            {
                RemovePower(powerUpList[0]);
            }
            // membuat powerUp baru
            GenerateRandomPowerUp();
            timerPowerUp -= 5; 
        }
    }
 
    // method for spawn ball and powerUP random
    public void GenerateRandomBall() 
    { 
        int randomIndex = Random.Range(0, ballTemplateList.Count); 
 
        GameObject ball = Instantiate(ballTemplateList[randomIndex]); 
        ball.SetActive(true); 
        ballList.Add(ball); 
    } 
    public void GenerateRandomPowerUp() 
    { 
        int randomIndex = Random.Range(0, powerUpTemplateList.Count); 
 
        GameObject power = Instantiate(powerUpTemplateList[randomIndex]); 
        if (powerUpList.Contains(power))
        {
            GenerateRandomPowerUp();
            return;
        }else
        {
            power.SetActive(true);
            powerUpList.Add(power); 
        }
 
    } 

    // method for delete ball and powerUp in list
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
    public void RemovePower(GameObject power) 
    { 
        powerUpList.Remove(power); 
        Destroy(power);
    } 
    public void RemoveAllPower() 
    { 
        while (powerUpList.Count > 0)
        {
            RemovePower(powerUpList[0]);
        }
    } 
}
