using UnityEngine;

public sealed class PlayerTransform : MonoBehaviour
{
    void Start()
    { 
      // Players.Player = GameObject.Find("Player" ).transform;//後で買える
      // Players.PlayerCam = GameObject.Find("Player").transform;//後で買える
      //  Players.Player = GameObject.Find("Player" + AvatorSelect_ver_A.select.ToString()).transform;//後で買える
       // Players.PlayerCam = GameObject.Find("Player" + AvatorSelect_ver_A.select.ToString() + "/Main Camera").transform;//後で買える
    }
}


public class Players 
{
    public static Transform Player;
    public static Transform PlayerCam; 
}
