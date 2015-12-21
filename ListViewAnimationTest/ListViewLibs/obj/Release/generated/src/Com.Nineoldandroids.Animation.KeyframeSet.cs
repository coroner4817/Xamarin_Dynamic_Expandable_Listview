using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='KeyframeSet']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/KeyframeSet", DoNotGenerateAcw=true)]
	public partial class KeyframeSet : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/KeyframeSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyframeSet); }
		}

		protected KeyframeSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLcom_nineoldandroids_animation_Keyframe_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='KeyframeSet']/constructor[@name='KeyframeSet' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Keyframe...']]"
		[Register (".ctor", "([Lcom/nineoldandroids/animation/Keyframe;)V", "")]
		public unsafe KeyframeSet (params global:: Com.Nineoldandroids.Animation.Keyframe[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (KeyframeSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lcom/nineoldandroids/animation/Keyframe;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Lcom/nineoldandroids/animation/Keyframe;)V", __args);
					return;
				}

				if (id_ctor_arrayLcom_nineoldandroids_animation_Keyframe_ == IntPtr.Zero)
					id_ctor_arrayLcom_nineoldandroids_animation_Keyframe_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lcom/nineoldandroids/animation/Keyframe;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLcom_nineoldandroids_animation_Keyframe_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLcom_nineoldandroids_animation_Keyframe_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Com.Nineoldandroids.Animation.KeyframeSet __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.KeyframeSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='KeyframeSet']/method[@name='clone' and count(parameter)=0]"
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

		static Delegate cb_getValue_F;
#pragma warning disable 0169
		static Delegate GetGetValue_FHandler ()
		{
			if (cb_getValue_F == null)
				cb_getValue_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_GetValue_F);
			return cb_getValue_F;
		}

		static IntPtr n_GetValue_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.Animation.KeyframeSet __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.KeyframeSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetValue (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getValue_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='KeyframeSet']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getValue", "(F)Ljava/lang/Object;", "GetGetValue_FHandler")]
		public virtual unsafe global::Java.Lang.Object GetValue (float p0)
		{
			if (id_getValue_F == IntPtr.Zero)
				id_getValue_F = JNIEnv.GetMethodID (class_ref, "getValue", "(F)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getValue_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(F)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
#pragma warning disable 0169
		static Delegate GetSetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_Handler ()
		{
			if (cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ == null)
				cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_);
			return cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
		}

		static void n_SetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.KeyframeSet __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.KeyframeSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.ITypeEvaluator p0 = (global::Com.Nineoldandroids.Animation.ITypeEvaluator)global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ITypeEvaluator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEvaluator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='KeyframeSet']/method[@name='setEvaluator' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.TypeEvaluator']]"
		[Register ("setEvaluator", "(Lcom/nineoldandroids/animation/TypeEvaluator;)V", "GetSetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_Handler")]
		public virtual unsafe void SetEvaluator (global::Com.Nineoldandroids.Animation.ITypeEvaluator p0)
		{
			if (id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ == IntPtr.Zero)
				id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ = JNIEnv.GetMethodID (class_ref, "setEvaluator", "(Lcom/nineoldandroids/animation/TypeEvaluator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEvaluator", "(Lcom/nineoldandroids/animation/TypeEvaluator;)V"), __args);
			} finally {
			}
		}

	}
}
