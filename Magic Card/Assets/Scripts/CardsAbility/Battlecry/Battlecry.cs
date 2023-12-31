using UnityEngine;

[DisallowMultipleComponent]
public class Battlecry : BaseCardActions
{
    private void OnEnable()
    {
        StaticEventsHandler.OnCardPlaced += StaticEventsHandler_OnCardPlaced;
    }

    private void OnDisable()
    {
        StaticEventsHandler.OnCardPlaced += StaticEventsHandler_OnCardPlaced;
    }

    private void StaticEventsHandler_OnCardPlaced(Card placedCard)
    {
        if (placedCard == card)
        {
            HandleBattlecryAbilities();
        }
    }

    private void HandleBattlecryAbilities()
    {
        switch (card.GetCardDetails().cardActionDetails.cardActionType)
        {
            case CardActionType.DrawCard:
                HandleDrawCardAction();
                break;

            case CardActionType.SpawnCard:
                HandleSpawnCardAction();
                break;

            default:
                break;
        }
    }
}