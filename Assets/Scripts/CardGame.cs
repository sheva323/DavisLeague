using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum CardKind {SuperStar, AllStar, RolePlayer1, RolePlayer2, RolePlayer3, BenchWarmer}
[CreateAssetMenu(menuName = "Card Game")]
public class CardGame : ScriptableObject
{
    public CardKind Class;
    public int CardValue;
}

