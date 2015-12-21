using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet", DoNotGenerateAcw=true)]
	public sealed partial class AnimatorSet : global::Com.Nineoldandroids.Animation.Animator {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.AnimatorSetListener']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$AnimatorSetListener", DoNotGenerateAcw=true)]
		public partial class AnimatorSetListener : global::Java.Lang.Object, global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$AnimatorSetListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AnimatorSetListener); }
			}

			protected AnimatorSetListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationCancel (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.AnimatorSetListener']/method[@name='onAnimationCancel' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationEnd (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.AnimatorSetListener']/method[@name='onAnimationEnd' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationRepeat (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.AnimatorSetListener']/method[@name='onAnimationRepeat' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.AnimatorSetListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationStart (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.AnimatorSetListener']/method[@name='onAnimationStart' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Builder']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_after_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetAfter_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_after_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_after_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_After_Lcom_nineoldandroids_animation_Animator_);
				return cb_after_Lcom_nineoldandroids_animation_Animator_;
			}

			static IntPtr n_After_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.After (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_after_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Builder']/method[@name='after' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
			[Register ("after", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "GetAfter_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual unsafe global::Com.Nineoldandroids.Animation.AnimatorSet.Builder After (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_after_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_after_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "after", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_after_Lcom_nineoldandroids_animation_Animator_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "after", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_after_J;
#pragma warning disable 0169
			static Delegate GetAfter_JHandler ()
			{
				if (cb_after_J == null)
					cb_after_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_After_J);
				return cb_after_J;
			}

			static IntPtr n_After_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.After (p0));
			}
#pragma warning restore 0169

			static IntPtr id_after_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Builder']/method[@name='after' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("after", "(J)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "GetAfter_JHandler")]
			public virtual unsafe global::Com.Nineoldandroids.Animation.AnimatorSet.Builder After (long p0)
			{
				if (id_after_J == IntPtr.Zero)
					id_after_J = JNIEnv.GetMethodID (class_ref, "after", "(J)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_after_J, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "after", "(J)Lcom/nineoldandroids/animation/AnimatorSet$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_before_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetBefore_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_before_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_before_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Before_Lcom_nineoldandroids_animation_Animator_);
				return cb_before_Lcom_nineoldandroids_animation_Animator_;
			}

			static IntPtr n_Before_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Before (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_before_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Builder']/method[@name='before' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
			[Register ("before", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "GetBefore_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual unsafe global::Com.Nineoldandroids.Animation.AnimatorSet.Builder Before (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_before_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_before_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "before", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_before_Lcom_nineoldandroids_animation_Animator_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "before", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_with_Lcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
			static Delegate GetWith_Lcom_nineoldandroids_animation_Animator_Handler ()
			{
				if (cb_with_Lcom_nineoldandroids_animation_Animator_ == null)
					cb_with_Lcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_With_Lcom_nineoldandroids_animation_Animator_);
				return cb_with_Lcom_nineoldandroids_animation_Animator_;
			}

			static IntPtr n_With_Lcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.With (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_with_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Builder']/method[@name='with' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
			[Register ("with", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "GetWith_Lcom_nineoldandroids_animation_Animator_Handler")]
			public virtual unsafe global::Com.Nineoldandroids.Animation.AnimatorSet.Builder With (global::Com.Nineoldandroids.Animation.Animator p0)
			{
				if (id_with_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
					id_with_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "with", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_with_Lcom_nineoldandroids_animation_Animator_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "with", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Dependency']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$Dependency", DoNotGenerateAcw=true)]
		public partial class Dependency : global::Java.Lang.Object {


			static IntPtr node_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Dependency']/field[@name='node']"
			[Register ("node")]
			public global::Com.Nineoldandroids.Animation.AnimatorSet.Node Node {
				get {
					if (node_jfieldId == IntPtr.Zero)
						node_jfieldId = JNIEnv.GetFieldID (class_ref, "node", "Lcom/nineoldandroids/animation/AnimatorSet$Node;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, node_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Node> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (node_jfieldId == IntPtr.Zero)
						node_jfieldId = JNIEnv.GetFieldID (class_ref, "node", "Lcom/nineoldandroids/animation/AnimatorSet$Node;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, node_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr rule_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Dependency']/field[@name='rule']"
			[Register ("rule")]
			public int Rule {
				get {
					if (rule_jfieldId == IntPtr.Zero)
						rule_jfieldId = JNIEnv.GetFieldID (class_ref, "rule", "I");
					return JNIEnv.GetIntField (Handle, rule_jfieldId);
				}
				set {
					if (rule_jfieldId == IntPtr.Zero)
						rule_jfieldId = JNIEnv.GetFieldID (class_ref, "rule", "I");
					try {
						JNIEnv.SetField (Handle, rule_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$Dependency", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Dependency); }
			}

			protected Dependency (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Node_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Dependency']/constructor[@name='AnimatorSet.Dependency' and count(parameter)=2 and parameter[1][@type='com.nineoldandroids.animation.AnimatorSet.Node'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", "")]
			public unsafe Dependency (global::Com.Nineoldandroids.Animation.AnimatorSet.Node p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Dependency)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", __args);
						return;
					}

					if (id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Node_I == IntPtr.Zero)
						id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Node_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Node_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Node_I, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.DependencyListener']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$DependencyListener", DoNotGenerateAcw=true)]
		public partial class DependencyListener : global::Java.Lang.Object, global::Com.Nineoldandroids.Animation.Animator.IAnimatorListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$DependencyListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DependencyListener); }
			}

			protected DependencyListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Lcom_nineoldandroids_animation_AnimatorSet_Node_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.DependencyListener']/constructor[@name='AnimatorSet.DependencyListener' and count(parameter)=3 and parameter[1][@type='com.nineoldandroids.animation.AnimatorSet'] and parameter[2][@type='com.nineoldandroids.animation.AnimatorSet.Node'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lcom/nineoldandroids/animation/AnimatorSet;Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", "")]
			public unsafe DependencyListener (global::Com.Nineoldandroids.Animation.AnimatorSet p0, global::Com.Nineoldandroids.Animation.AnimatorSet.Node p1, int p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (DependencyListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nineoldandroids/animation/AnimatorSet;Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nineoldandroids/animation/AnimatorSet;Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V", __args);
						return;
					}

					if (id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Lcom_nineoldandroids_animation_AnimatorSet_Node_I == IntPtr.Zero)
						id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Lcom_nineoldandroids_animation_AnimatorSet_Node_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/animation/AnimatorSet;Lcom/nineoldandroids/animation/AnimatorSet$Node;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Lcom_nineoldandroids_animation_AnimatorSet_Node_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nineoldandroids_animation_AnimatorSet_Lcom_nineoldandroids_animation_AnimatorSet_Node_I, __args);
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationCancel (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationCancel_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.DependencyListener']/method[@name='onAnimationCancel' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationEnd (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationEnd_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.DependencyListener']/method[@name='onAnimationEnd' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationRepeat (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationRepeat_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.DependencyListener']/method[@name='onAnimationRepeat' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
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
				global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.DependencyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.Animator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationStart (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationStart_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.DependencyListener']/method[@name='onAnimationStart' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Node']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorSet$Node", DoNotGenerateAcw=true)]
		public partial class Node : global::Java.Lang.Object, global::Java.Lang.ICloneable {


			static IntPtr animation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Node']/field[@name='animation']"
			[Register ("animation")]
			public global::Com.Nineoldandroids.Animation.Animator Animation {
				get {
					if (animation_jfieldId == IntPtr.Zero)
						animation_jfieldId = JNIEnv.GetFieldID (class_ref, "animation", "Lcom/nineoldandroids/animation/Animator;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, animation_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (animation_jfieldId == IntPtr.Zero)
						animation_jfieldId = JNIEnv.GetFieldID (class_ref, "animation", "Lcom/nineoldandroids/animation/Animator;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, animation_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr dependencies_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Node']/field[@name='dependencies']"
			[Register ("dependencies")]
			public global::System.Collections.IList Dependencies {
				get {
					if (dependencies_jfieldId == IntPtr.Zero)
						dependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "dependencies", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, dependencies_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (dependencies_jfieldId == IntPtr.Zero)
						dependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "dependencies", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, dependencies_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr done_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Node']/field[@name='done']"
			[Register ("done")]
			public bool Done {
				get {
					if (done_jfieldId == IntPtr.Zero)
						done_jfieldId = JNIEnv.GetFieldID (class_ref, "done", "Z");
					return JNIEnv.GetBooleanField (Handle, done_jfieldId);
				}
				set {
					if (done_jfieldId == IntPtr.Zero)
						done_jfieldId = JNIEnv.GetFieldID (class_ref, "done", "Z");
					try {
						JNIEnv.SetField (Handle, done_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr nodeDependencies_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Node']/field[@name='nodeDependencies']"
			[Register ("nodeDependencies")]
			public global::System.Collections.IList NodeDependencies {
				get {
					if (nodeDependencies_jfieldId == IntPtr.Zero)
						nodeDependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeDependencies", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, nodeDependencies_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nodeDependencies_jfieldId == IntPtr.Zero)
						nodeDependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeDependencies", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, nodeDependencies_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr nodeDependents_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Node']/field[@name='nodeDependents']"
			[Register ("nodeDependents")]
			public global::System.Collections.IList NodeDependents {
				get {
					if (nodeDependents_jfieldId == IntPtr.Zero)
						nodeDependents_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeDependents", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, nodeDependents_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nodeDependents_jfieldId == IntPtr.Zero)
						nodeDependents_jfieldId = JNIEnv.GetFieldID (class_ref, "nodeDependents", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, nodeDependents_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr tmpDependencies_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Node']/field[@name='tmpDependencies']"
			[Register ("tmpDependencies")]
			public global::System.Collections.IList TmpDependencies {
				get {
					if (tmpDependencies_jfieldId == IntPtr.Zero)
						tmpDependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "tmpDependencies", "Ljava/util/ArrayList;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, tmpDependencies_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (tmpDependencies_jfieldId == IntPtr.Zero)
						tmpDependencies_jfieldId = JNIEnv.GetFieldID (class_ref, "tmpDependencies", "Ljava/util/ArrayList;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, tmpDependencies_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet$Node", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Node); }
			}

			protected Node (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nineoldandroids_animation_Animator_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Node']/constructor[@name='AnimatorSet.Node' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
			[Register (".ctor", "(Lcom/nineoldandroids/animation/Animator;)V", "")]
			public unsafe Node (global::Com.Nineoldandroids.Animation.Animator p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (Node)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nineoldandroids/animation/Animator;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nineoldandroids/animation/Animator;)V", __args);
						return;
					}

					if (id_ctor_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
						id_ctor_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/animation/Animator;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nineoldandroids_animation_Animator_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nineoldandroids_animation_Animator_, __args);
				} finally {
				}
			}

			static Delegate cb_clone;
#pragma warning disable 0169
			static Delegate GetCloneHandler ()
			{
				if (cb_clone == null)
					cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
				return cb_clone;
			}

			static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nineoldandroids.Animation.AnimatorSet.Node __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Clone ());
			}
#pragma warning restore 0169

			static IntPtr id_clone;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet.Node']/method[@name='clone' and count(parameter)=0]"
			[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
			public virtual unsafe global::Java.Lang.Object Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorSet); }
		}

		internal AnimatorSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/constructor[@name='AnimatorSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimatorSet ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AnimatorSet)) {
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

		static IntPtr id_getChildAnimations;
		public unsafe global::System.Collections.Generic.IList<global::Com.Nineoldandroids.Animation.Animator> ChildAnimations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='getChildAnimations' and count(parameter)=0]"
			[Register ("getChildAnimations", "()Ljava/util/ArrayList;", "GetGetChildAnimationsHandler")]
			get {
				if (id_getChildAnimations == IntPtr.Zero)
					id_getChildAnimations = JNIEnv.GetMethodID (class_ref, "getChildAnimations", "()Ljava/util/ArrayList;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Nineoldandroids.Animation.Animator>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getChildAnimations), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDuration;
		public override unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='getDuration' and count(parameter)=0]"
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

		static IntPtr id_isRunning;
		public override unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
				} finally {
				}
			}
		}

		static IntPtr id_getStartDelay;
		static IntPtr id_setStartDelay_J;
		public override unsafe long StartDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='getStartDelay' and count(parameter)=0]"
			[Register ("getStartDelay", "()J", "GetGetStartDelayHandler")]
			get {
				if (id_getStartDelay == IntPtr.Zero)
					id_getStartDelay = JNIEnv.GetMethodID (class_ref, "getStartDelay", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_getStartDelay);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='setStartDelay' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setStartDelay", "(J)V", "GetSetStartDelay_JHandler")]
			set {
				if (id_setStartDelay_J == IntPtr.Zero)
					id_setStartDelay_J = JNIEnv.GetMethodID (class_ref, "setStartDelay", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setStartDelay_J, __args);
				} finally {
				}
			}
		}

		static IntPtr id_play_Lcom_nineoldandroids_animation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='play' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator']]"
		[Register ("play", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;", "")]
		public unsafe global::Com.Nineoldandroids.Animation.AnimatorSet.Builder Play (global::Com.Nineoldandroids.Animation.Animator p0)
		{
			if (id_play_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_play_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "play", "(Lcom/nineoldandroids/animation/Animator;)Lcom/nineoldandroids/animation/AnimatorSet$Builder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Nineoldandroids.Animation.AnimatorSet.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.AnimatorSet.Builder> (JNIEnv.CallObjectMethod  (Handle, id_play_Lcom_nineoldandroids_animation_Animator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_playSequentially_arrayLcom_nineoldandroids_animation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='playSequentially' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator...']]"
		[Register ("playSequentially", "([Lcom/nineoldandroids/animation/Animator;)V", "")]
		public unsafe void PlaySequentially (params global:: Com.Nineoldandroids.Animation.Animator[] p0)
		{
			if (id_playSequentially_arrayLcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_playSequentially_arrayLcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "playSequentially", "([Lcom/nineoldandroids/animation/Animator;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_playSequentially_arrayLcom_nineoldandroids_animation_Animator_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_playSequentially_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='playSequentially' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.nineoldandroids.animation.Animator&gt;']]"
		[Register ("playSequentially", "(Ljava/util/List;)V", "")]
		public unsafe void PlaySequentially (global::System.Collections.Generic.IList<global::Com.Nineoldandroids.Animation.Animator> p0)
		{
			if (id_playSequentially_Ljava_util_List_ == IntPtr.Zero)
				id_playSequentially_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "playSequentially", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Nineoldandroids.Animation.Animator>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_playSequentially_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_playTogether_arrayLcom_nineoldandroids_animation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='playTogether' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Animator...']]"
		[Register ("playTogether", "([Lcom/nineoldandroids/animation/Animator;)V", "")]
		public unsafe void PlayTogether (params global:: Com.Nineoldandroids.Animation.Animator[] p0)
		{
			if (id_playTogether_arrayLcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_playTogether_arrayLcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "playTogether", "([Lcom/nineoldandroids/animation/Animator;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_playTogether_arrayLcom_nineoldandroids_animation_Animator_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_playTogether_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='playTogether' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;com.nineoldandroids.animation.Animator&gt;']]"
		[Register ("playTogether", "(Ljava/util/Collection;)V", "")]
		public unsafe void PlayTogether (global::System.Collections.Generic.ICollection<global::Com.Nineoldandroids.Animation.Animator> p0)
		{
			if (id_playTogether_Ljava_util_Collection_ == IntPtr.Zero)
				id_playTogether_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "playTogether", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Com.Nineoldandroids.Animation.Animator>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_playTogether_Ljava_util_Collection_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)Lcom/nineoldandroids/animation/Animator;", "")]
		public override unsafe global::Com.Nineoldandroids.Animation.Animator SetDuration (long p0)
		{
			if (id_setDuration_J == IntPtr.Zero)
				id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)Lcom/nineoldandroids/animation/Animator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallObjectMethod  (Handle, id_setDuration_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorSet']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "")]
		public override unsafe void SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			if (id_setInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
				id_setInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setInterpolator_Landroid_view_animation_Interpolator_, __args);
			} finally {
			}
		}

	}
}
