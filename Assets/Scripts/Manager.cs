using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public PlayerStatus player;
    public int step;

    public List<CardInfos> cards;

    public GameObject painelEndGame;
    public Image imagemResultado;

    //cards exibidos na tela
    public CardSlot slot1;
    public CardSlot slot2;
    public CardSlot slot3;

    public Sprite spriteWin;
    public Sprite spriteLose;

    // Start is called before the first frame update
    void Start()
    {
        player = PlayerStatus.instance;
        this.step = 0;
        NextStep();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextStep()
    {
        //somar mais 1 ao contador de etapa
        step += 1;

        //verificar se a etapa passa da maxima (10)
        if (step > 10)
        {
            //funcao de finalização do game
            if (player.CalcularResultado())
            {
                this.imagemResultado.sprite = spriteWin;
            }
            else
            {
                this.imagemResultado.sprite = spriteLose;
            }

            this.painelEndGame.SetActive(!painelEndGame.activeSelf);   

        }

        //chamar funcao de selecao dos cards
        SelectCards();

    }

    public void SelectCards()
    {
        CardInfos c1 = cards[Random.Range(0, cards.Count)];
        CardInfos c2 = cards[Random.Range(0, cards.Count)];
        CardInfos c3 = cards[Random.Range(0, cards.Count)];

        this.slot1.AddCardInfo(c1);
        this.slot2.AddCardInfo(c2);
        this.slot3.AddCardInfo(c3);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
