using UnityEngine;
using UnityEngine.UI;

public class PlayerChoice : MonoBehaviour
{
    [SerializeField] private Image myEmote;

    public int playerChoice;
    private GameManager gm;

    void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void RockButton() 
    {
        myEmote.sprite = gm.handEmotes[0];

        playerChoice = 0;
    }

    public void PaperButton()
    {
        myEmote.sprite = gm.handEmotes[1];

        playerChoice = 1;
    }

    public void ScissorsButton()
    {
        myEmote.sprite = gm.handEmotes[2];

        playerChoice = 2;
    }
}
