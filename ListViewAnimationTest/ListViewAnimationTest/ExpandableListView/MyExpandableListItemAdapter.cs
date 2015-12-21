using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

using Com.Nhaarman.Listviewanimations;
using Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem;

namespace ListViewAnimationTest.ExpandableListView
{
	public class MyExpandableListItemAdapter : Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter
	{
		private Context mContext;
		public List<string> danWeiXinXi;

		private LayoutInflater inflater;
		private Button mEnterBtn;
		private Button mChaGangBtn;
		private TextView mXinXiTextView;

		public MyExpandableListItemAdapter (Context context,int p0, int p1, int p2) : base(context, p0, p1, p2)
		{	
			mContext = context;
			danWeiXinXi = new List<string> ();
			inflater = (LayoutInflater)mContext.GetSystemService (Context.LayoutInflaterService);
		}

		public override View GetTitleView (int p0, View p1, ViewGroup p2)
		{
			TextView tv = (TextView)p1;
			if (tv == null) {
				tv = new TextView (mContext);
			}
				
			tv.Text=GetItem (p0).ToString();
			tv.SetTextColor(Android.Graphics.Color.ParseColor ("#ffffff"));
			return tv;
		}

		public override View GetContentView (int p0, View p1, ViewGroup p2)
		{
			LinearLayout Layout = new LinearLayout (mContext);
			var parameter = new LinearLayout.LayoutParams (LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.WrapContent);
			Layout.LayoutParameters = parameter;
			Layout.SetBackgroundColor (Android.Graphics.Color.ParseColor ("#f2f2f2"));

			View mExpandView = inflater.Inflate (Resource.Layout.expand_content_layout, Layout);
			mEnterBtn = mExpandView.FindViewById<Button> (Resource.Id.enterBtn);
			mChaGangBtn = mExpandView.FindViewById<Button> (Resource.Id.chaGangBtn);
			mXinXiTextView = mExpandView.FindViewById<TextView> (Resource.Id.ContentText);

			mXinXiTextView.Text = danWeiXinXi [p0];
			mEnterBtn.Click += delegate {
				Toast.MakeText (mContext, string.Format("Item" + p0.ToString()), ToastLength.Short).Show ();
			};
			mChaGangBtn.Click += delegate {
				Toast.MakeText (mContext, string.Format("Item" + p0.ToString()), ToastLength.Short).Show ();
			};

			return mExpandView;
		}
	 	
	}
}

