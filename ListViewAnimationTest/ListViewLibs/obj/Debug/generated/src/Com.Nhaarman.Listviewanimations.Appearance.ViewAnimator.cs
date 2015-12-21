using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Appearance {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/appearance/ViewAnimator", DoNotGenerateAcw=true)]
	public partial class ViewAnimator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/appearance/ViewAnimator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewAnimator); }
		}

		protected ViewAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/constructor[@name='ViewAnimator' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.util.ListViewWrapper']]"
		[Register (".ctor", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", "")]
		public unsafe ViewAnimator (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ViewAnimator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ == IntPtr.Zero)
					id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_, __args);
			} finally {
			}
		}

		static Delegate cb_animateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetAnimateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_Handler ()
		{
			if (cb_animateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_ == null)
				cb_animateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_AnimateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_);
			return cb_animateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_;
		}

		static void n_AnimateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Animator[] p2 = (global::Com.Nineoldandroids.Animation.Animator[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Nineoldandroids.Animation.Animator));
			__this.AnimateViewIfNecessary (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_animateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='animateViewIfNecessary' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.nineoldandroids.animation.Animator[]']]"
		[Register ("animateViewIfNecessary", "(ILandroid/view/View;[Lcom/nineoldandroids/animation/Animator;)V", "GetAnimateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_Handler")]
		public virtual unsafe void AnimateViewIfNecessary (int p0, global::Android.Views.View p1, global::Com.Nineoldandroids.Animation.Animator[] p2)
		{
			if (id_animateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_animateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_ = JNIEnv.GetMethodID (class_ref, "animateViewIfNecessary", "(ILandroid/view/View;[Lcom/nineoldandroids/animation/Animator;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_animateViewIfNecessary_ILandroid_view_View_arrayLcom_nineoldandroids_animation_Animator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateViewIfNecessary", "(ILandroid/view/View;[Lcom/nineoldandroids/animation/Animator;)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_disableAnimations;
#pragma warning disable 0169
		static Delegate GetDisableAnimationsHandler ()
		{
			if (cb_disableAnimations == null)
				cb_disableAnimations = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableAnimations);
			return cb_disableAnimations;
		}

		static void n_DisableAnimations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableAnimations ();
		}
#pragma warning restore 0169

		static IntPtr id_disableAnimations;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='disableAnimations' and count(parameter)=0]"
		[Register ("disableAnimations", "()V", "GetDisableAnimationsHandler")]
		public virtual unsafe void DisableAnimations ()
		{
			if (id_disableAnimations == IntPtr.Zero)
				id_disableAnimations = JNIEnv.GetMethodID (class_ref, "disableAnimations", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disableAnimations);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableAnimations", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableAnimations;
#pragma warning disable 0169
		static Delegate GetEnableAnimationsHandler ()
		{
			if (cb_enableAnimations == null)
				cb_enableAnimations = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableAnimations);
			return cb_enableAnimations;
		}

		static void n_EnableAnimations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableAnimations ();
		}
#pragma warning restore 0169

		static IntPtr id_enableAnimations;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='enableAnimations' and count(parameter)=0]"
		[Register ("enableAnimations", "()V", "GetEnableAnimationsHandler")]
		public virtual unsafe void EnableAnimations ()
		{
			if (id_enableAnimations == IntPtr.Zero)
				id_enableAnimations = JNIEnv.GetMethodID (class_ref, "enableAnimations", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableAnimations);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableAnimations", "()V"));
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRestoreInstanceState_Landroid_os_Parcelable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			if (id_onSaveInstanceState == IntPtr.Zero)
				id_onSaveInstanceState = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod  (Handle, id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAnimationDelayMillis_I;
#pragma warning disable 0169
		static Delegate GetSetAnimationDelayMillis_IHandler ()
		{
			if (cb_setAnimationDelayMillis_I == null)
				cb_setAnimationDelayMillis_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAnimationDelayMillis_I);
			return cb_setAnimationDelayMillis_I;
		}

		static void n_SetAnimationDelayMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationDelayMillis (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimationDelayMillis_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='setAnimationDelayMillis' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAnimationDelayMillis", "(I)V", "GetSetAnimationDelayMillis_IHandler")]
		public virtual unsafe void SetAnimationDelayMillis (int p0)
		{
			if (id_setAnimationDelayMillis_I == IntPtr.Zero)
				id_setAnimationDelayMillis_I = JNIEnv.GetMethodID (class_ref, "setAnimationDelayMillis", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAnimationDelayMillis_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationDelayMillis", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAnimationDurationMillis_I;
#pragma warning disable 0169
		static Delegate GetSetAnimationDurationMillis_IHandler ()
		{
			if (cb_setAnimationDurationMillis_I == null)
				cb_setAnimationDurationMillis_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAnimationDurationMillis_I);
			return cb_setAnimationDurationMillis_I;
		}

		static void n_SetAnimationDurationMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationDurationMillis (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimationDurationMillis_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='setAnimationDurationMillis' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAnimationDurationMillis", "(I)V", "GetSetAnimationDurationMillis_IHandler")]
		public virtual unsafe void SetAnimationDurationMillis (int p0)
		{
			if (id_setAnimationDurationMillis_I == IntPtr.Zero)
				id_setAnimationDurationMillis_I = JNIEnv.GetMethodID (class_ref, "setAnimationDurationMillis", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAnimationDurationMillis_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationDurationMillis", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setInitialDelayMillis_I;
#pragma warning disable 0169
		static Delegate GetSetInitialDelayMillis_IHandler ()
		{
			if (cb_setInitialDelayMillis_I == null)
				cb_setInitialDelayMillis_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetInitialDelayMillis_I);
			return cb_setInitialDelayMillis_I;
		}

		static void n_SetInitialDelayMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInitialDelayMillis (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInitialDelayMillis_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='setInitialDelayMillis' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setInitialDelayMillis", "(I)V", "GetSetInitialDelayMillis_IHandler")]
		public virtual unsafe void SetInitialDelayMillis (int p0)
		{
			if (id_setInitialDelayMillis_I == IntPtr.Zero)
				id_setInitialDelayMillis_I = JNIEnv.GetMethodID (class_ref, "setInitialDelayMillis", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInitialDelayMillis_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialDelayMillis", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShouldAnimateFromPosition_I;
#pragma warning disable 0169
		static Delegate GetSetShouldAnimateFromPosition_IHandler ()
		{
			if (cb_setShouldAnimateFromPosition_I == null)
				cb_setShouldAnimateFromPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShouldAnimateFromPosition_I);
			return cb_setShouldAnimateFromPosition_I;
		}

		static void n_SetShouldAnimateFromPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldAnimateFromPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShouldAnimateFromPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='setShouldAnimateFromPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShouldAnimateFromPosition", "(I)V", "GetSetShouldAnimateFromPosition_IHandler")]
		public virtual unsafe void SetShouldAnimateFromPosition (int p0)
		{
			if (id_setShouldAnimateFromPosition_I == IntPtr.Zero)
				id_setShouldAnimateFromPosition_I = JNIEnv.GetMethodID (class_ref, "setShouldAnimateFromPosition", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShouldAnimateFromPosition_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldAnimateFromPosition", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShouldAnimateNotVisible;
#pragma warning disable 0169
		static Delegate GetSetShouldAnimateNotVisibleHandler ()
		{
			if (cb_setShouldAnimateNotVisible == null)
				cb_setShouldAnimateNotVisible = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetShouldAnimateNotVisible);
			return cb_setShouldAnimateNotVisible;
		}

		static void n_SetShouldAnimateNotVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldAnimateNotVisible ();
		}
#pragma warning restore 0169

		static IntPtr id_setShouldAnimateNotVisible;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ViewAnimator']/method[@name='setShouldAnimateNotVisible' and count(parameter)=0]"
		[Register ("setShouldAnimateNotVisible", "()V", "GetSetShouldAnimateNotVisibleHandler")]
		public virtual unsafe void SetShouldAnimateNotVisible ()
		{
			if (id_setShouldAnimateNotVisible == IntPtr.Zero)
				id_setShouldAnimateNotVisible = JNIEnv.GetMethodID (class_ref, "setShouldAnimateNotVisible", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShouldAnimateNotVisible);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldAnimateNotVisible", "()V"));
			} finally {
			}
		}

	}
}
