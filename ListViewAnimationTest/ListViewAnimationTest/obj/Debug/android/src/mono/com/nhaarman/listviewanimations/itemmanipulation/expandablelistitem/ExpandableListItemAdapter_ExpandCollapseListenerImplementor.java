package mono.com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem;


public class ExpandableListItemAdapter_ExpandCollapseListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem.ExpandableListItemAdapter.ExpandCollapseListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemCollapsed:(I)V:GetOnItemCollapsed_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter/IExpandCollapseListenerInvoker, ListViewLibs\n" +
			"n_onItemExpanded:(I)V:GetOnItemExpanded_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter/IExpandCollapseListenerInvoker, ListViewLibs\n" +
			"";
		mono.android.Runtime.register ("Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter/IExpandCollapseListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ExpandableListItemAdapter_ExpandCollapseListenerImplementor.class, __md_methods);
	}


	public ExpandableListItemAdapter_ExpandCollapseListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ExpandableListItemAdapter_ExpandCollapseListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter/IExpandCollapseListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onItemCollapsed (int p0)
	{
		n_onItemCollapsed (p0);
	}

	private native void n_onItemCollapsed (int p0);


	public void onItemExpanded (int p0)
	{
		n_onItemExpanded (p0);
	}

	private native void n_onItemExpanded (int p0);

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
