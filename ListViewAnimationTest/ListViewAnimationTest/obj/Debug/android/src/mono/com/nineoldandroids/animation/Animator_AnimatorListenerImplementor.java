package mono.com.nineoldandroids.animation;


public class Animator_AnimatorListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nineoldandroids.animation.Animator.AnimatorListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnimationCancel:(Lcom/nineoldandroids/animation/Animator;)V:GetOnAnimationCancel_Lcom_nineoldandroids_animation_Animator_Handler:Com.Nineoldandroids.Animation.Animator/IAnimatorListenerInvoker, ListViewLibs\n" +
			"n_onAnimationEnd:(Lcom/nineoldandroids/animation/Animator;)V:GetOnAnimationEnd_Lcom_nineoldandroids_animation_Animator_Handler:Com.Nineoldandroids.Animation.Animator/IAnimatorListenerInvoker, ListViewLibs\n" +
			"n_onAnimationRepeat:(Lcom/nineoldandroids/animation/Animator;)V:GetOnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_Handler:Com.Nineoldandroids.Animation.Animator/IAnimatorListenerInvoker, ListViewLibs\n" +
			"n_onAnimationStart:(Lcom/nineoldandroids/animation/Animator;)V:GetOnAnimationStart_Lcom_nineoldandroids_animation_Animator_Handler:Com.Nineoldandroids.Animation.Animator/IAnimatorListenerInvoker, ListViewLibs\n" +
			"";
		mono.android.Runtime.register ("Com.Nineoldandroids.Animation.Animator/IAnimatorListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Animator_AnimatorListenerImplementor.class, __md_methods);
	}


	public Animator_AnimatorListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Animator_AnimatorListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nineoldandroids.Animation.Animator/IAnimatorListenerImplementor, ListViewLibs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAnimationCancel (com.nineoldandroids.animation.Animator p0)
	{
		n_onAnimationCancel (p0);
	}

	private native void n_onAnimationCancel (com.nineoldandroids.animation.Animator p0);


	public void onAnimationEnd (com.nineoldandroids.animation.Animator p0)
	{
		n_onAnimationEnd (p0);
	}

	private native void n_onAnimationEnd (com.nineoldandroids.animation.Animator p0);


	public void onAnimationRepeat (com.nineoldandroids.animation.Animator p0)
	{
		n_onAnimationRepeat (p0);
	}

	private native void n_onAnimationRepeat (com.nineoldandroids.animation.Animator p0);


	public void onAnimationStart (com.nineoldandroids.animation.Animator p0)
	{
		n_onAnimationStart (p0);
	}

	private native void n_onAnimationStart (com.nineoldandroids.animation.Animator p0);

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
