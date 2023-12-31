using UnityEngine;

public static class Settings
{
    public const int startingAmountOfRivalsHealth = 30;
    public const int startingAmountOfRivalsMana = 9;
    public const int maxAmountOfRivalsMana = 10;

    public const int startingNumberOfCards = 6;

    public const int maxNumberOfPlacedCards = 5;
    public const int maxNumberOfCardsInHand = 6;

    public const float cardStandartYPosition = -600f;
    public const float cardMouseEnterYPosition = -340f;

    public static Color cardSTierColor = new Color(246f, 224f, 0f);
    public static Color cardATierColor = new Color(95f, 246f, 0f);
    public static Color cardBTierColor = new Color(0f, 121f, 246f);
    public static Color cardCTierColor = new Color(246f, 0f, 246f);
    public static Color cardDTierColor = new Color(145f, 145f, 145f);

    public const string mainMenuSceneString = "MainMenuScene";
    public const string gameSceneSctring = "GameScene";
    public const string editDeckScene = "EditDeckScene";

    public const string playerDeckSavingKey = "playerDeck";
    public const string enemyDeckSavingKey = "enemyDeck";

    public const string baseCardDetailsPath = "ScriptableObjects/Cards/Base_CardDetails";
}