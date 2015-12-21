package mono.com.nhaarman.listviewanimations.itemmanipulation.dragdrop;


public class OnItemMovedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nhaarman.listviewanimations.itemmanipulation.dragdrop.OnItemMovedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemMoved:(II)V:GetOnItemMoved_IIHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerInvoker, ListViewLibs\n" +
			"";
		mono.android.Runtime.register ("Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnItemMovedListenerImplementor.class, __md_methods);
	}


	public OnItemMovedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnItemMovedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onItemMoved (int p0, int p1)
	{
		n_onItemMoved (p0, p1);
	}

	private native void n_onItemMoved (int p0, int p1);

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
