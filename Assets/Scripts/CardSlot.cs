using UnityEngine;
using UnityEngine.UI;

public class CardSlot : MonoBehaviour
{
    public Image imagem;

    public CardInfos card;

    public PlayerStatus player;

    void Start()
    {
        this.player = PlayerStatus.instance;
    }

    public void AddCardInfo(CardInfos newCard)
    {
        this.card = newCard;
        this.imagem.sprite = card.imagem;

    }

    public void SelectThisCard()
    {
        player.AlterarAtributos(card.getAtributes());
    }
}
