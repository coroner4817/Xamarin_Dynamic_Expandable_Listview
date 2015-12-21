package mono.com.nineoldandroids.animation;


public class ValueAnimator_AnimatorUpdateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nineoldandroids.animation.ValueAnimator.AnimatorUpdateListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnimationUpdate:(Lcom/nineoldandroids/animation/ValueAnimator;)V:GetOnAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_Handler:Com.Nineoldandroids.Animation.ValueAnimator/IAnimatorUpdateListenerInvoker, ListViewLibs\n" +
			"";
		mono.android.Runtime.register ("Com.Nineoldandroids.Animation.ValueAnimator/IAnimatorUpdateListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ValueAnimator_AnimatorUpdateListenerImplementor.class, __md_methods);
	}


	public ValueAnimator_AnimatorUpdateListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ValueAnimator_AnimatorUpdateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nineoldandroids.Animation.ValueAnimator/IAnimatorUpdateListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAnimationUpdate (com.nineoldandroids.animation.ValueAnimator p0)
	{
		n_onAnimationUpdate (p0);
	}

	private native void n_onAnimationUpdate (com.nineoldandroids.animation.ValueAnimator p0);

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
