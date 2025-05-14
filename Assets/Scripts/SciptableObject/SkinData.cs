using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

[CreateAssetMenu(fileName = "SkinData", menuName = "Game/Skin Data")]
public class SkinData : ScriptableObject
{
    public SpriteAtlas spriteAtlas;
    public List<string> listNameAtlas;
}
