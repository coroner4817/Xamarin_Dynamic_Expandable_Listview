using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Com.Nhaarman.Listviewanimations.Appearance.Simple;
using ListViewAnimationTest.ExpandableListView;
using System.ComponentModel;
using System.Threading;
using Android.Util;

namespace ListViewAnimationTest
{
	[Activity]
	public class ExpandableListItemActivity : MyListActivity
	{
		private static int INITIAL_DELAY_MILLIS=500;
		private MyExpandableListItemAdapter mExpandableListItemAdapter;
		private ListView mListView;
		private BackgroundWorker mWorker=new BackgroundWorker();

		private bool isLoadingMore=false;

		private int count=0;
		int beginList=30;
		int addList=5;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			int p0 = Resource.Layout.activity_expandablelistitem_card;
			int p1 = Resource.Id.activity_expandablelistitem_card_title;
			int p2 = Resource.Id.activity_expandablelistitem_card_content;

			mExpandableListItemAdapter = new MyExpandableListItemAdapter (this,p0,p1,p2);

			//add all the title into a list
			//add dan wei xinxi list
			for (int i = 0; i < beginList; i++) {
				mExpandableListItemAdapter.Add (string.Format ("Item " + i.ToString ()));
				mExpandableListItemAdapter.danWeiXinXi.Add (string.Format("Item"+i.ToString()+"'s information"));
			}


			mExpandableListItemAdapter.SetLimit (1);

			AlphaInAnimationAdapter alphaInAnimationAdapter = new AlphaInAnimationAdapter (mExpandableListItemAdapter);
			mListView = getListView ();
			alphaInAnimationAdapter.SetAbsListView (mListView);

			alphaInAnimationAdapter.ViewAnimator.SetInitialDelayMillis (INITIAL_DELAY_MILLIS);
			mListView.Adapter = alphaInAnimationAdapter;
	
			mListView.Scroll += delegate(object sender, AbsListView.ScrollEventArgs e) {
				if(((e.FirstVisibleItem+e.VisibleItemCount)==e.TotalItemCount)&&(e.TotalItemCount!=0))
				{
					Log.Info("Scroll","textview Show");

					TextViewShow();
				}
				else
				{
					TextViewDismiss();
				}
			};

			mListView.ScrollStateChanged += delegate(object sender, AbsListView.ScrollStateChangedEventArgs e) {

				int threshold=1;
				int listviewCount=mListView.Count;

				if(e.ScrollState==ScrollState.Idle){
					if(mListView.LastVisiblePosition>=(listviewCount-threshold))
					{
						if(!isLoadingMore)
						{
							dragRefreshStateChanged(true);

							mWorker = new BackgroundWorker ();
							mWorker.WorkerSupportsCancellation = true;

							count++;
							Log.Info("load Times",count.ToString());

							//toggle loading state bool to true
							isLoadingMore=!isLoadingMore;

							//start progressbar
							ListViewUPAndprogressbarStart();
							Log.Info("mContainer","Going up");

							mWorker.DoWork+=delegate(object sender1, DoWorkEventArgs e1) {

								BackgroundWorker mworker = sender1 as BackgroundWorker;
								if (mworker.CancellationPending == true) {
									e1.Cancel = true;
								} else {
									//do work example
									Thread.Sleep(3000);
								}
							};

							mWorker.RunWorkerCompleted+=delegate(object sender1, RunWorkerCompletedEventArgs e1) {
								//end progressbar
								ListViewDOWNAndprogressbarEnd();
								Log.Info("mContainer","Going down");
								if (e1.Cancelled == true) {

								} else if (!(e1.Error == null)) {

								} else {
									//work complete add more data
									for (int i=beginList; i < beginList+addList; i++) {
										mExpandableListItemAdapter.Add (string.Format ("Item " + i.ToString ()));
										mExpandableListItemAdapter.danWeiXinXi.Add (string.Format("Item"+i.ToString()+"'s information"));	
									}

									beginList=beginList+addList;
								}
									
								//toggle loading state bool to false when complete
								isLoadingMore=!isLoadingMore;
								dragRefreshStateChanged(false);
							};

							if (mWorker.IsBusy != true) {
								mWorker.RunWorkerAsync ();
							}
						}
						else
						{
							Log.Info("load fail","loading data and can't start backgroundworker");
						}
					}
				}
			};

			Toast.MakeText (this, "Click expand the listview", ToastLength.Short).Show ();
		}
			

		protected override void OnDestroy ()
		{
			if (mWorker.WorkerSupportsCancellation == true)
			{
				mWorker.CancelAsync();
			}
			base.OnDestroy ();
		}
			
	}
}

