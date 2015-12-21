package mono.com.nineoldandroids.animation;


public class TimeAnimator_TimeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nineoldandroids.animation.TimeAnimator.TimeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onTimeUpdate:(Lcom/nineoldandroids/animation/TimeAnimator;JJ)V:GetOnTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJHandler:Com.Nineoldandroids.Animation.TimeAnimator/ITimeListenerInvoker, ListViewLibs\n" +
			"";
		mono.android.Runtime.register ("Com.Nineoldandroids.Animation.TimeAnimator/ITimeListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TimeAnimator_TimeListenerImplementor.class, __md_methods);
	}


	public TimeAnimator_TimeListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TimeAnimator_TimeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nineoldandroids.Animation.TimeAnimator/ITimeListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTimeUpdate (com.nineoldandroids.animation.TimeAnimator p0, long p1, long p2)
	{
		n_onTimeUpdate (p0, p1, p2);
	}

	private native void n_onTimeUpdate (com.nineoldandroids.animation.TimeAnimator p0, long p1, long p2);

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
