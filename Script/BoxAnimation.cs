using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnimation : MonoBehaviour
{
   public GameObject box_move;
   public GameObject box_rotate;
   public GameObject box_scale;

   public void BoxMoveAnimation() {
	box_move.GetComponent<Animation>().Play();
   }
	
   public void BoxRotateAnimation() {
	box_rotate.GetComponent<Animation>().Play();
   }

   public void BoxScaleAnimation() {
	box_scale.GetComponent<Animation>().Play();
   }

}
