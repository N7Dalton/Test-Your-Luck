using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class AppleAchievements : MonoBehaviour
{
    public GameManager gameManager;
    public bool HasRiskTaker;
    public string IOSAchievement;
    public string AndroidAchievement;
    private string achievementID;

    void Start()
    {

        achievementID = IOSAchievement;

        Social.localUser.Authenticate(success =>
        {
            if (success)
            {
                Debug.Log("Authentication successful");
                string userInfo = "Username: " + Social.localUser.userName +
                    "\nUser ID: " + Social.localUser.id +
                    "\nIsUnderage: " + Social.localUser.underage;
                Debug.Log(userInfo);
            }
            else
                Debug.Log("Authentication failed");
        });
    }
        private void Update()
    {
       
    }
    public void GetRiskTaker()
    {
        
        Social.ReportProgress(achievementID, 100.0,  HasRiskTaker =>
        {
            if (HasRiskTaker)
                Debug.Log("Successfully reported progress");
            else
                Debug.Log("Failed to report progress");
        });
    }
}
