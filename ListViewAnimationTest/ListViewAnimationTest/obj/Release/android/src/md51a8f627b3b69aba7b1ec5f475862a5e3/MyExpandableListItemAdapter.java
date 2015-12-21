package md51a8f627b3b69aba7b1ec5f475862a5e3;


public class MyExpandableListItemAdapter
	extends com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem.ExpandableListItemAdapter
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getTitleView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetTitleView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"n_getContentView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetContentView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"";
		mono.android.Runtime.register ("ListViewAnimationTest.ExpandableListView.MyExpandableListItemAdapter, ListViewAnimationTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyExpandableListItemAdapter.class, __md_methods);
	}


	public MyExpandableListItemAdapter (android.content.Context p0, int p1, int p2, int p3, java.util.List p4) throws java.lang.Throwable
	{
		super (p0, p1, p2, p3, p4);
		if (getClass () == MyExpandableListItemAdapter.class)
			mono.android.TypeManager.Activate ("ListViewAnimationTest.ExpandableListView.MyExpandableListItemAdapter, ListViewAnimationTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Collections.IList, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3, p4 });
	}


	public MyExpandableListItemAdapter (android.content.Context p0, int p1, int p2, int p3) throws java.lang.Throwable
	{
		super (p0, p1, p2, p3);
		if (getClass () == MyExpandableListItemAdapter.class)
			mono.android.TypeManager.Activate ("ListViewAnimationTest.ExpandableListView.MyExpandableListItemAdapter, ListViewAnimationTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public MyExpandableListItemAdapter (android.content.Context p0, java.util.List p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == MyExpandableListItemAdapter.class)
			mono.android.TypeManager.Activate ("ListViewAnimationTest.ExpandableListView.MyExpandableListItemAdapter, ListViewAnimationTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Collections.IList, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public MyExpandableListItemAdapter (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MyExpandableListItemAdapter.class)
			mono.android.TypeManager.Activate ("ListViewAnimationTest.ExpandableListView.MyExpandableListItemAdapter, ListViewAnimationTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public android.view.View getTitleView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getTitleView (p0, p1, p2);
	}

	private native android.view.View n_getTitleView (int p0, android.view.View p1, android.view.ViewGroup p2);


	public android.view.View getContentView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getContentView (p0, p1, p2);
	}

	private native android.view.View n_getContentView (int p0, android.view.View p1, android.view.ViewGroup p2);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
