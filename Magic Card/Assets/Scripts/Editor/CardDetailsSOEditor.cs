using UnityEditor;
using UnityEngine;

[CanEditMultipleObjects]
[CustomEditor(typeof(CardDetailsSO))]
public class CardDetailsSOEditor : Editor
{
    private CustomEditorPresets customEditorPresets;

    private void OnEnable()
    {
        customEditorPresets = new CustomEditorPresets();
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        CardDetailsSO cardDetails = (CardDetailsSO)target;

        customEditorPresets.DrawHeader("MAIN PARAMETERS");
        cardDetails.damage = EditorGUILayout.IntField("Damage", cardDetails.damage);
        cardDetails.health = EditorGUILayout.IntField("Health", cardDetails.health);
        cardDetails.manaCost = EditorGUILayout.IntField("Mana Cost", cardDetails.manaCost);

        EditorGUILayout.Space(10);
        cardDetails.cardTier = (CardTier)EditorGUILayout.EnumPopup("Card Tier", cardDetails.cardTier);
        cardDetails.cardAbility = (CardAbilityType)EditorGUILayout.EnumPopup("Card Ability", cardDetails.cardAbility);
        
        switch (cardDetails.cardAbility)
        {
            case CardAbilityType.Battlecry:
                EditorGUILayout.Space(5);
                customEditorPresets.DrawHeader("BATTLECRY PARAMETERS");

                cardDetails.cardActionDetails = (CardActionsDetailsSO)EditorGUILayout.ObjectField("Battlecry Details",
                    cardDetails.cardActionDetails, typeof(CardActionsDetailsSO), false);
                break;

            case CardAbilityType.Deathrattle:
                EditorGUILayout.Space(5);
                customEditorPresets.DrawHeader("DEATHATTLE PARAMETERS");

                cardDetails.cardActionDetails = (CardActionsDetailsSO)EditorGUILayout.ObjectField("Deathrattle Details",
                    cardDetails.cardActionDetails, typeof(CardActionsDetailsSO), false);
                break;

            default:
                break;
        }

        EditorGUILayout.Space(10);
        cardDetails.characterName = EditorGUILayout.TextField("Character Name", cardDetails.characterName);
        cardDetails.cardDescription = EditorGUILayout.TextField("Card Description", cardDetails.cardDescription);

        EditorGUILayout.Space(10);
        cardDetails.characterAvatarSprite = (Sprite)EditorGUILayout.ObjectField("Character Avatar",
            cardDetails.characterAvatarSprite, typeof(Sprite), false);
        cardDetails.avatarBackgroundSprite = (Sprite)EditorGUILayout.ObjectField("Avatar Background",
            cardDetails.avatarBackgroundSprite, typeof(Sprite), false);

        if (GUI.changed)
        {
            EditorUtility.SetDirty(cardDetails);
        }
    }
}