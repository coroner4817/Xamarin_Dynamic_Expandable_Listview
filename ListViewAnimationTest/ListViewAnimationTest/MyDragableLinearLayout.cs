using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.InputMethods;
using Android.Util;

namespace ListViewAnimationTest
{
	public class MyDragableLinearLayout : LinearLayout
	{

		public MyDragableLinearLayout (Context context) : base (context)
		{
		}

		public MyDragableLinearLayout (Context context, IAttributeSet attrs) : base (context, attrs)
		{
		}

		public override bool OnTouchEvent (MotionEvent e)
		{
			if (e.Action == MotionEventActions.Up) {
				LinearLayoutMoveUp (e);
			}
			return true;
		}

		private void LinearLayoutMoveUp(MotionEvent e)
		{
			
		}

	}
}

