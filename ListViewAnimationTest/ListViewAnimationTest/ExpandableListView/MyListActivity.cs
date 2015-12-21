using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.InputMethods;
using Android.Util;

namespace ListViewAnimationTest.ExpandableListView
{
	public class MyListActivity : Activity
	{
		private ListView mListView;

		private FrameLayout mSearchLayout;
		private LinearLayout mSearchBtn;
		private EditText mEditText;
		private LinearLayout mContainer;
		private ProgressBar mLoadMoreProgressbar;
		private TextView mLoadMoewTextView;
		private LinearLayout mProgressbartextViewLayout;

		private bool mAnimateDown=false;
		private bool mIsAnimating=false;

		private bool isDragRefresh=false;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.activity_mylist);

			mListView = FindViewById<ListView> (Resource.Id.activity_mylist_listview);
			mListView.TranscriptMode = TranscriptMode.Normal;

			mContainer = FindViewById<LinearLayout> (Resource.Id.ListViewContainer);
			mContainer.BringToFront ();

			mSearchLayout = FindViewById<FrameLayout> (Resource.Id.searchLayout);
			mSearchBtn = FindViewById<LinearLayout> (Resource.Id.searchBtn);
			mEditText = FindViewById<EditText> (Resource.Id.etSearch);
			mSearchLayout.Alpha=0;

			mLoadMoreProgressbar = FindViewById<ProgressBar> (Resource.Id.progressbarLoadMore);
			mLoadMoewTextView = FindViewById<TextView> (Resource.Id.loadMoreTextView);
			mProgressbartextViewLayout = FindViewById<LinearLayout> (Resource.Id.ProgressbarTextViewLayout);
				
			mSearchBtn.Click += delegate {
				Toast.MakeText (this, "Search", ToastLength.Short).Show ();
			};

			mEditText.KeyPress+=delegate(object sender, View.KeyEventArgs e) {
				if((e.Event.Action==KeyEventActions.Down)&&(e.KeyCode==Keycode.Enter))
				{
					Toast.MakeText (this, "Search", ToastLength.Short).Show ();
				}
				if((e.Event.Action==KeyEventActions.Down)&&(e.KeyCode==Keycode.Back))
				{
					if (mAnimateDown) {
						MyAnimation anim = new MyAnimation (mListView, mListView.Height + mEditText.Height);
						anim.Duration = 500;
						mListView.StartAnimation (anim);
						anim.AnimationStart += anim_AnimationStartUp;
						anim.AnimationEnd += anim_AnimationEndUp;

						mAnimateDown = !mAnimateDown;
					} else {
						base.OnBackPressed ();	
					}
				}

			};
		}

		public void dragRefreshStateChanged(bool state)
		{
			isDragRefresh = state;
		}

		public void ListViewUPAndprogressbarStart()
		{
			mContainer.Animate ().TranslationYBy (-mProgressbartextViewLayout.Height).SetDuration (500).Start ();
			mLoadMoreProgressbar.Visibility = ViewStates.Visible;
		}

		public void ListViewDOWNAndprogressbarEnd()
		{
			mContainer.Animate ().TranslationYBy (mProgressbartextViewLayout.Height).SetDuration (500).Start ();
			mLoadMoreProgressbar.Visibility = ViewStates.Invisible;
			mListView.SetSelection (mListView.Count - 1);
		}

		public void TextViewShow()
		{
			if (mLoadMoewTextView.Visibility != ViewStates.Visible) {
				mLoadMoewTextView.Visibility = ViewStates.Visible;
			}
		}

		public void TextViewDismiss()
		{
			if (mLoadMoewTextView.Visibility != ViewStates.Invisible) {
				mLoadMoewTextView.Visibility = ViewStates.Invisible;
			}
		}

		public ListView getListView()
		{
			return mListView;
		}
			
		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate (Resource.Menu.actionbar,menu);
			return base.OnCreateOptionsMenu (menu);
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			Log.Info("SearchEdittext",isDragRefresh.ToString());

			if (!isDragRefresh) {
				switch (item.ItemId) {

				case Resource.Id.search:
					mSearchLayout.Visibility = ViewStates.Visible;
					if (mIsAnimating) {
						return true;
					}

					if (!mAnimateDown) {
						//Listview is up and will go down
						MyAnimation anim = new MyAnimation (mListView, mListView.Height - mEditText.Height);
						anim.Duration = 500;
						mListView.StartAnimation (anim);
						anim.AnimationStart += anim_AnimationStartDown;
						anim.AnimationEnd += anim_AnimationEndDown;

					} else {
						//listview is down and will go up
						MyAnimation anim = new MyAnimation (mListView, mListView.Height + mEditText.Height);
						anim.Duration = 500;
						mListView.StartAnimation (anim);
						anim.AnimationStart += anim_AnimationStartUp;
						anim.AnimationEnd += anim_AnimationEndUp;
					}
					mAnimateDown = !mAnimateDown;
					return true;


				default:
					return base.OnOptionsItemSelected (item);	
				}
			} else {
				Toast.MakeText (this, "Please wait load finish", ToastLength.Short).Show ();
				return base.OnOptionsItemSelected (item);
			}


		}

		void anim_AnimationStartDown (object sender, Android.Views.Animations.Animation.AnimationStartEventArgs e)
		{
			mIsAnimating = true;
			mSearchLayout.Animate ().AlphaBy (1.0f).SetDuration (500).Start ();
			mContainer.Animate ().TranslationYBy (mEditText.Height).SetDuration (500).Start ();
			mContainer.Animate ().AlphaBy (-0.5f).SetDuration (500).Start ();
		}

		void anim_AnimationStartUp (object sender, Android.Views.Animations.Animation.AnimationStartEventArgs e)
		{
			mIsAnimating = true;
			mSearchLayout.Animate ().AlphaBy (-1.0f).SetDuration (500).Start ();
			mContainer.Animate ().TranslationYBy (-mEditText.Height).SetDuration (500).Start ();
			mContainer.Animate ().AlphaBy (0.5f).SetDuration (500).Start ();
		}

		void anim_AnimationEndDown (object sender, Android.Views.Animations.Animation.AnimationEndEventArgs e)
		{
			mIsAnimating = false;
			mListView.Clickable = false;
		}

		void anim_AnimationEndUp (object sender, Android.Views.Animations.Animation.AnimationEndEventArgs e)
		{
			mIsAnimating = false;
			mListView.Clickable = true;

			mEditText.ClearFocus ();
			InputMethodManager inputManager = (InputMethodManager)this.GetSystemService (Context.InputMethodService);
			inputManager.HideSoftInputFromWindow (this.CurrentFocus.WindowToken, HideSoftInputFlags.NotAlways);
		}
			

		public override void OnBackPressed ()
		{
			if (mAnimateDown) {
				MyAnimation anim = new MyAnimation (mListView, mListView.Height + mEditText.Height);
				anim.Duration = 500;
				mListView.StartAnimation (anim);
				anim.AnimationStart += anim_AnimationStartUp;
				anim.AnimationEnd += anim_AnimationEndUp;

				mAnimateDown = !mAnimateDown;
			} else {
				base.OnBackPressed ();	
			}
		}
	}
}

