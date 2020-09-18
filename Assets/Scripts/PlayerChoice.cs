using UnityEngine;
using UnityEngine.UI;

public class PlayerChoice : MonoBehaviour
{
    [SerializeField] private Image myEmote;
    private GameManager gm;

    void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void RockButton() 
    {
        myEmote.sprite = gm.handEmotes[0];

        gm.SetScore(0);
    }

    public void PaperButton()
    {
        myEmote.sprite = gm.handEmotes[1];

        gm.SetScore(1);
    }

    public void ScissorsButton()
    {
        myEmote.sprite = gm.handEmotes[2];

        gm.SetScore(2);
    }
}
