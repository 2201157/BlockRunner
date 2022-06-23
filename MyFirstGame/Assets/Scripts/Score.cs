using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
       //Foward Direction
       scoreText.SetText(player.position.z.ToString("0"));
    }
}
