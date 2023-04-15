using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheColorTube : MonoBehaviour
{
   public SpriteRenderer spriteRenderer;

   public void SetColor(Color color)
   {
      spriteRenderer.color = color;
   }
}
