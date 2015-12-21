using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']"
	[global::Android.Runtime.Register ("com/nineoldandroids/view/ViewPropertyAnimator", DoNotGenerateAcw=true)]
	public abstract partial class ViewPropertyAnimator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/view/ViewPropertyAnimator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewPropertyAnimator); }
		}

		protected ViewPropertyAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/constructor[@name='ViewPropertyAnimator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ViewPropertyAnimator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ViewPropertyAnimator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		public abstract long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")] get;
		}

		static Delegate cb_getStartDelay;
#pragma warning disable 0169
		static Delegate GetGetStartDelayHandler ()
		{
			if (cb_getStartDelay == null)
				cb_getStartDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartDelay);
			return cb_getStartDelay;
		}

		static long n_GetStartDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartDelay;
		}
#pragma warning restore 0169

		public abstract long StartDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='getStartDelay' and count(parameter)=0]"
			[Register ("getStartDelay", "()J", "GetGetStartDelayHandler")] get;
		}

		static Delegate cb_alpha_F;
#pragma warning disable 0169
		static Delegate GetAlpha_FHandler ()
		{
			if (cb_alpha_F == null)
				cb_alpha_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Alpha_F);
			return cb_alpha_F;
		}

		static IntPtr n_Alpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Alpha (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='alpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alpha", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetAlpha_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator Alpha (float p0);

		static Delegate cb_alphaBy_F;
#pragma warning disable 0169
		static Delegate GetAlphaBy_FHandler ()
		{
			if (cb_alphaBy_F == null)
				cb_alphaBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_AlphaBy_F);
			return cb_alphaBy_F;
		}

		static IntPtr n_AlphaBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AlphaBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='alphaBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alphaBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetAlphaBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator AlphaBy (float p0);

		static IntPtr id_animate_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='animate' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("animate", "(Landroid/view/View;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator Animate (global::Android.Views.View p0)
		{
			if (id_animate_Landroid_view_View_ == IntPtr.Zero)
				id_animate_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "animate", "(Landroid/view/View;)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Nineoldandroids.View.ViewPropertyAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_animate_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public abstract void Cancel ();

		static Delegate cb_rotation_F;
#pragma warning disable 0169
		static Delegate GetRotation_FHandler ()
		{
			if (cb_rotation_F == null)
				cb_rotation_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Rotation_F);
			return cb_rotation_F;
		}

		static IntPtr n_Rotation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rotation (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotation", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotation_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator Rotation (float p0);

		static Delegate cb_rotationBy_F;
#pragma warning disable 0169
		static Delegate GetRotationBy_FHandler ()
		{
			if (cb_rotationBy_F == null)
				cb_rotationBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationBy_F);
			return cb_rotationBy_F;
		}

		static IntPtr n_RotationBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationBy (float p0);

		static Delegate cb_rotationX_F;
#pragma warning disable 0169
		static Delegate GetRotationX_FHandler ()
		{
			if (cb_rotationX_F == null)
				cb_rotationX_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationX_F);
			return cb_rotationX_F;
		}

		static IntPtr n_RotationX_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationX (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationX_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationX (float p0);

		static Delegate cb_rotationXBy_F;
#pragma warning disable 0169
		static Delegate GetRotationXBy_FHandler ()
		{
			if (cb_rotationXBy_F == null)
				cb_rotationXBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationXBy_F);
			return cb_rotationXBy_F;
		}

		static IntPtr n_RotationXBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationXBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationXBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationXBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationXBy (float p0);

		static Delegate cb_rotationY_F;
#pragma warning disable 0169
		static Delegate GetRotationY_FHandler ()
		{
			if (cb_rotationY_F == null)
				cb_rotationY_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationY_F);
			return cb_rotationY_F;
		}

		static IntPtr n_RotationY_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationY (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationY_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationY (float p0);

		static Delegate cb_rotationYBy_F;
#pragma warning disable 0169
		static Delegate GetRotationYBy_FHandler ()
		{
			if (cb_rotationYBy_F == null)
				cb_rotationYBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_RotationYBy_F);
			return cb_rotationYBy_F;
		}

		static IntPtr n_RotationYBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotationYBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationYBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationYBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationYBy (float p0);

		static Delegate cb_scaleX_F;
#pragma warning disable 0169
		static Delegate GetScaleX_FHandler ()
		{
			if (cb_scaleX_F == null)
				cb_scaleX_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_ScaleX_F);
			return cb_scaleX_F;
		}

		static IntPtr n_ScaleX_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleX (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='scaleX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleX_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleX (float p0);

		static Delegate cb_scaleXBy_F;
#pragma warning disable 0169
		static Delegate GetScaleXBy_FHandler ()
		{
			if (cb_scaleXBy_F == null)
				cb_scaleXBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_ScaleXBy_F);
			return cb_scaleXBy_F;
		}

		static IntPtr n_ScaleXBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleXBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='scaleXBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleXBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleXBy (float p0);

		static Delegate cb_scaleY_F;
#pragma warning disable 0169
		static Delegate GetScaleY_FHandler ()
		{
			if (cb_scaleY_F == null)
				cb_scaleY_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_ScaleY_F);
			return cb_scaleY_F;
		}

		static IntPtr n_ScaleY_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleY (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='scaleY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleY_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleY (float p0);

		static Delegate cb_scaleYBy_F;
#pragma warning disable 0169
		static Delegate GetScaleYBy_FHandler ()
		{
			if (cb_scaleYBy_F == null)
				cb_scaleYBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_ScaleYBy_F);
			return cb_scaleYBy_F;
		}

		static IntPtr n_ScaleYBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleYBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='scaleYBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleYBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleYBy (float p0);

		static Delegate cb_setDuration_J;
#pragma warning disable 0169
		static Delegate GetSetDuration_JHandler ()
		{
			if (cb_setDuration_J == null)
				cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDuration_J);
			return cb_setDuration_J;
		}

		static IntPtr n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDuration (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetDuration_JHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator SetDuration (long p0);

		static Delegate cb_setInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setInterpolator_Landroid_view_animation_Interpolator_;
		}

		static IntPtr n_SetInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInterpolator (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator SetInterpolator (global::Android.Views.Animations.IInterpolator p0);

		static Delegate cb_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler ()
		{
			if (cb_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ == null)
				cb_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_);
			return cb_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
		}

		static IntPtr n_SetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0 = (global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener)global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator.AnimatorListener']]"
		[Register ("setListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator SetListener (global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0);

		static Delegate cb_setStartDelay_J;
#pragma warning disable 0169
		static Delegate GetSetStartDelay_JHandler ()
		{
			if (cb_setStartDelay_J == null)
				cb_setStartDelay_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetStartDelay_J);
			return cb_setStartDelay_J;
		}

		static IntPtr n_SetStartDelay_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStartDelay (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='setStartDelay' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setStartDelay", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetStartDelay_JHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator SetStartDelay (long p0);

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public abstract void Start ();

		static Delegate cb_translationX_F;
#pragma warning disable 0169
		static Delegate GetTranslationX_FHandler ()
		{
			if (cb_translationX_F == null)
				cb_translationX_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TranslationX_F);
			return cb_translationX_F;
		}

		static IntPtr n_TranslationX_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TranslationX (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='translationX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("translationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationX_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationX (float p0);

		static Delegate cb_translationXBy_F;
#pragma warning disable 0169
		static Delegate GetTranslationXBy_FHandler ()
		{
			if (cb_translationXBy_F == null)
				cb_translationXBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TranslationXBy_F);
			return cb_translationXBy_F;
		}

		static IntPtr n_TranslationXBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TranslationXBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='translationXBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("translationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationXBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationXBy (float p0);

		static Delegate cb_translationY_F;
#pragma warning disable 0169
		static Delegate GetTranslationY_FHandler ()
		{
			if (cb_translationY_F == null)
				cb_translationY_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TranslationY_F);
			return cb_translationY_F;
		}

		static IntPtr n_TranslationY_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TranslationY (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='translationY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("translationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationY_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationY (float p0);

		static Delegate cb_translationYBy_F;
#pragma warning disable 0169
		static Delegate GetTranslationYBy_FHandler ()
		{
			if (cb_translationYBy_F == null)
				cb_translationYBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_TranslationYBy_F);
			return cb_translationYBy_F;
		}

		static IntPtr n_TranslationYBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TranslationYBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='translationYBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("translationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationYBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationYBy (float p0);

		static Delegate cb_x_F;
#pragma warning disable 0169
		static Delegate GetX_FHandler ()
		{
			if (cb_x_F == null)
				cb_x_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_X_F);
			return cb_x_F;
		}

		static IntPtr n_X_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.X (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='x' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("x", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetX_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator X (float p0);

		static Delegate cb_xBy_F;
#pragma warning disable 0169
		static Delegate GetXBy_FHandler ()
		{
			if (cb_xBy_F == null)
				cb_xBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_XBy_F);
			return cb_xBy_F;
		}

		static IntPtr n_XBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.XBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='xBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("xBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetXBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator XBy (float p0);

		static Delegate cb_y_F;
#pragma warning disable 0169
		static Delegate GetY_FHandler ()
		{
			if (cb_y_F == null)
				cb_y_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Y_F);
			return cb_y_F;
		}

		static IntPtr n_Y_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Y (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='y' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("y", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetY_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator Y (float p0);

		static Delegate cb_yBy_F;
#pragma warning disable 0169
		static Delegate GetYBy_FHandler ()
		{
			if (cb_yBy_F == null)
				cb_yBy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_YBy_F);
			return cb_yBy_F;
		}

		static IntPtr n_YBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.View.ViewPropertyAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.YBy (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='yBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("yBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetYBy_FHandler")]
		public abstract global::Com.Nineoldandroids.View.ViewPropertyAnimator YBy (float p0);

	}

	[global::Android.Runtime.Register ("com/nineoldandroids/view/ViewPropertyAnimator", DoNotGenerateAcw=true)]
	internal partial class ViewPropertyAnimatorInvoker : ViewPropertyAnimator {

		public ViewPropertyAnimatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewPropertyAnimatorInvoker); }
		}

		static IntPtr id_getDuration;
		public override unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_getDuration);
				} finally {
				}
			}
		}

		static IntPtr id_getStartDelay;
		public override unsafe long StartDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='getStartDelay' and count(parameter)=0]"
			[Register ("getStartDelay", "()J", "GetGetStartDelayHandler")]
			get {
				if (id_getStartDelay == IntPtr.Zero)
					id_getStartDelay = JNIEnv.GetMethodID (class_ref, "getStartDelay", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_getStartDelay);
				} finally {
				}
			}
		}

		static IntPtr id_alpha_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='alpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alpha", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetAlpha_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator Alpha (float p0)
		{
			if (id_alpha_F == IntPtr.Zero)
				id_alpha_F = JNIEnv.GetMethodID (class_ref, "alpha", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_alpha_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_alphaBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='alphaBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alphaBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetAlphaBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator AlphaBy (float p0)
		{
			if (id_alphaBy_F == IntPtr.Zero)
				id_alphaBy_F = JNIEnv.GetMethodID (class_ref, "alphaBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_alphaBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public override unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_cancel);
			} finally {
			}
		}

		static IntPtr id_rotation_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotation", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotation_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator Rotation (float p0)
		{
			if (id_rotation_F == IntPtr.Zero)
				id_rotation_F = JNIEnv.GetMethodID (class_ref, "rotation", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotation_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotationBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationBy (float p0)
		{
			if (id_rotationBy_F == IntPtr.Zero)
				id_rotationBy_F = JNIEnv.GetMethodID (class_ref, "rotationBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotationX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationX_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationX (float p0)
		{
			if (id_rotationX_F == IntPtr.Zero)
				id_rotationX_F = JNIEnv.GetMethodID (class_ref, "rotationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationX_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotationXBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationXBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationXBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationXBy (float p0)
		{
			if (id_rotationXBy_F == IntPtr.Zero)
				id_rotationXBy_F = JNIEnv.GetMethodID (class_ref, "rotationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationXBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotationY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationY_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationY (float p0)
		{
			if (id_rotationY_F == IntPtr.Zero)
				id_rotationY_F = JNIEnv.GetMethodID (class_ref, "rotationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationY_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotationYBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='rotationYBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetRotationYBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator RotationYBy (float p0)
		{
			if (id_rotationYBy_F == IntPtr.Zero)
				id_rotationYBy_F = JNIEnv.GetMethodID (class_ref, "rotationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_rotationYBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scaleX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='scaleX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleX_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleX (float p0)
		{
			if (id_scaleX_F == IntPtr.Zero)
				id_scaleX_F = JNIEnv.GetMethodID (class_ref, "scaleX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_scaleX_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scaleXBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='scaleXBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleXBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleXBy (float p0)
		{
			if (id_scaleXBy_F == IntPtr.Zero)
				id_scaleXBy_F = JNIEnv.GetMethodID (class_ref, "scaleXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_scaleXBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scaleY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='scaleY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleY_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleY (float p0)
		{
			if (id_scaleY_F == IntPtr.Zero)
				id_scaleY_F = JNIEnv.GetMethodID (class_ref, "scaleY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_scaleY_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scaleYBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='scaleYBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetScaleYBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator ScaleYBy (float p0)
		{
			if (id_scaleYBy_F == IntPtr.Zero)
				id_scaleYBy_F = JNIEnv.GetMethodID (class_ref, "scaleYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_scaleYBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetDuration_JHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator SetDuration (long p0)
		{
			if (id_setDuration_J == IntPtr.Zero)
				id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_setDuration_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			if (id_setInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
				id_setInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Nineoldandroids.View.ViewPropertyAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_setInterpolator_Landroid_view_animation_Interpolator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator.AnimatorListener']]"
		[Register ("setListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_Handler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator SetListener (global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener p0)
		{
			if (id_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ == IntPtr.Zero)
				id_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/nineoldandroids/animation/Animator$AnimatorListener;)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Nineoldandroids.View.ViewPropertyAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_setListener_Lcom_nineoldandroids_animation_Animator_AnimatorListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setStartDelay_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='setStartDelay' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setStartDelay", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetSetStartDelay_JHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator SetStartDelay (long p0)
		{
			if (id_setStartDelay_J == IntPtr.Zero)
				id_setStartDelay_J = JNIEnv.GetMethodID (class_ref, "setStartDelay", "(J)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_setStartDelay_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_start);
			} finally {
			}
		}

		static IntPtr id_translationX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='translationX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("translationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationX_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationX (float p0)
		{
			if (id_translationX_F == IntPtr.Zero)
				id_translationX_F = JNIEnv.GetMethodID (class_ref, "translationX", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_translationX_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_translationXBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='translationXBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("translationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationXBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationXBy (float p0)
		{
			if (id_translationXBy_F == IntPtr.Zero)
				id_translationXBy_F = JNIEnv.GetMethodID (class_ref, "translationXBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_translationXBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_translationY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='translationY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("translationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationY_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationY (float p0)
		{
			if (id_translationY_F == IntPtr.Zero)
				id_translationY_F = JNIEnv.GetMethodID (class_ref, "translationY", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_translationY_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_translationYBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='translationYBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("translationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetTranslationYBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator TranslationYBy (float p0)
		{
			if (id_translationYBy_F == IntPtr.Zero)
				id_translationYBy_F = JNIEnv.GetMethodID (class_ref, "translationYBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_translationYBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_x_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='x' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("x", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetX_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator X (float p0)
		{
			if (id_x_F == IntPtr.Zero)
				id_x_F = JNIEnv.GetMethodID (class_ref, "x", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_x_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_xBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='xBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("xBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetXBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator XBy (float p0)
		{
			if (id_xBy_F == IntPtr.Zero)
				id_xBy_F = JNIEnv.GetMethodID (class_ref, "xBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_xBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_y_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='y' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("y", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetY_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator Y (float p0)
		{
			if (id_y_F == IntPtr.Zero)
				id_y_F = JNIEnv.GetMethodID (class_ref, "y", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_y_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_yBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewPropertyAnimator']/method[@name='yBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("yBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;", "GetYBy_FHandler")]
		public override unsafe global::Com.Nineoldandroids.View.ViewPropertyAnimator YBy (float p0)
		{
			if (id_yBy_F == IntPtr.Zero)
				id_yBy_F = JNIEnv.GetMethodID (class_ref, "yBy", "(F)Lcom/nineoldandroids/view/ViewPropertyAnimator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.ViewPropertyAnimator> (JNIEnv.CallObjectMethod  (Handle, id_yBy_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
