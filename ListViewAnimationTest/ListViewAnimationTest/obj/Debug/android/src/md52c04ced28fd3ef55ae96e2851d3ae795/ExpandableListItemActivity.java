package md52c04ced28fd3ef55ae96e2851d3ae795;


public class ExpandableListItemActivity
	extends md51a8f627b3b69aba7b1ec5f475862a5e3.MyListActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"";
		mono.android.Runtime.register ("ListViewAnimationTest.ExpandableListItemActivity, ListViewAnimationTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ExpandableListItemActivity.class, __md_methods);
	}


	public ExpandableListItemActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ExpandableListItemActivity.class)
			mono.android.TypeManager.Activate ("ListViewAnimationTest.ExpandableListItemActivity, ListViewAnimationTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();

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
