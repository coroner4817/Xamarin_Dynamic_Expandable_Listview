using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorListenerAdapter']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorListenerAdapter", DoNotGenerateAcw=true)]
	public abstract partial class AnimatorListenerAdapter : global::Java.Lang.Object, global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorListenerAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorListenerAdapter); }
		}

		protected AnimatorListenerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorListenerAdapter']/constructor[@name='AnimatorListenerAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimatorListenerAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AnimatorListenerAdapter)) {
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

		static Delegate cb_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationCancel_Lcom_nineoldandroids_animation_Animator_Handler ()
		{
			if (cb_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ == null)
				cb_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationCancel_Lcom_nineoldandroids_animation_Animator_);
			return cb_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
		}

		static void n_OnAnimationCancel_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationCancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorListenerAdapter']/method[@name='onAnimationCancel' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
		[Register ("onAnimationCancel", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationCancel_Lcom_nineoldandroids_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationCancel (global::Com.Nineoldandroids.Animation.Animator p0)
		{
			if (id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationCancel", "(Lcom/nineoldandroids/animation/Animator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationCancel", "(Lcom/nineoldandroids/animation/Animator;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationEnd_Lcom_nineoldandroids_animation_Animator_Handler ()
		{
			if (cb_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ == null)
				cb_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationEnd_Lcom_nineoldandroids_animation_Animator_);
			return cb_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
		}

		static void n_OnAnimationEnd_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationEnd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorListenerAdapter']/method[@name='onAnimationEnd' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
		[Register ("onAnimationEnd", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationEnd_Lcom_nineoldandroids_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationEnd (global::Com.Nineoldandroids.Animation.Animator p0)
		{
			if (id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "(Lcom/nineoldandroids/animation/Animator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationEnd", "(Lcom/nineoldandroids/animation/Animator;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_Handler ()
		{
			if (cb_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ == null)
				cb_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_);
			return cb_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
		}

		static void n_OnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationRepeat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorListenerAdapter']/method[@name='onAnimationRepeat' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
		[Register ("onAnimationRepeat", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationRepeat_Lcom_nineoldandroids_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationRepeat (global::Com.Nineoldandroids.Animation.Animator p0)
		{
			if (id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationRepeat", "(Lcom/nineoldandroids/animation/Animator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationRepeat", "(Lcom/nineoldandroids/animation/Animator;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationStart_Lcom_nineoldandroids_animation_Animator_Handler ()
		{
			if (cb_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ == null)
				cb_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationStart_Lcom_nineoldandroids_animation_Animator_);
			return cb_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
		}

		static void n_OnAnimationStart_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationStart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorListenerAdapter']/method[@name='onAnimationStart' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
		[Register ("onAnimationStart", "(Lcom/nineoldandroids/animation/Animator;)V", "GetOnAnimationStart_Lcom_nineoldandroids_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationStart (global::Com.Nineoldandroids.Animation.Animator p0)
		{
			if (id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "onAnimationStart", "(Lcom/nineoldandroids/animation/Animator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationStart", "(Lcom/nineoldandroids/animation/Animator;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorListenerAdapter", DoNotGenerateAcw=true)]
	internal partial class AnimatorListenerAdapterInvoker : AnimatorListenerAdapter {

		public AnimatorListenerAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorListenerAdapterInvoker); }
		}

	}

}
