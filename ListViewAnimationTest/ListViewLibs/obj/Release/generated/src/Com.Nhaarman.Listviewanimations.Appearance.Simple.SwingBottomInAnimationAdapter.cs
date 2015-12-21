using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Appearance.Simple {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance.simple']/class[@name='SwingBottomInAnimationAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/appearance/simple/SwingBottomInAnimationAdapter", DoNotGenerateAcw=true)]
	public partial class SwingBottomInAnimationAdapter : global::Com.Nhaarman.Listviewanimations.Appearance.SingleAnimationAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/appearance/simple/SwingBottomInAnimationAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwingBottomInAnimationAdapter); }
		}

		protected SwingBottomInAnimationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance.simple']/class[@name='SwingBottomInAnimationAdapter']/constructor[@name='SwingBottomInAnimationAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		public unsafe SwingBottomInAnimationAdapter (global::Android.Widget.BaseAdapter p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SwingBottomInAnimationAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_BaseAdapter_ == IntPtr.Zero)
					id_ctor_Landroid_widget_BaseAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_, __args);
			} finally {
			}
		}

		static Delegate cb_getAnimator_Landroid_view_ViewGroup_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetAnimator_Landroid_view_ViewGroup_Landroid_view_View_Handler ()
		{
			if (cb_getAnimator_Landroid_view_ViewGroup_Landroid_view_View_ == null)
				cb_getAnimator_Landroid_view_ViewGroup_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAnimator_Landroid_view_ViewGroup_Landroid_view_View_);
			return cb_getAnimator_Landroid_view_ViewGroup_Landroid_view_View_;
		}

		static IntPtr n_GetAnimator_Landroid_view_ViewGroup_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.Simple.SwingBottomInAnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.Simple.SwingBottomInAnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAnimator (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAnimator_Landroid_view_ViewGroup_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance.simple']/class[@name='SwingBottomInAnimationAdapter']/method[@name='getAnimator' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='android.view.View']]"
		[Register ("getAnimator", "(Landroid/view/ViewGroup;Landroid/view/View;)Lcom/nineoldandroids/animation/Animator;", "GetGetAnimator_Landroid_view_ViewGroup_Landroid_view_View_Handler")]
		protected override unsafe global::Com.Nineoldandroids.Animation.Animator GetAnimator (global::Android.Views.ViewGroup p0, global::Android.Views.View p1)
		{
			if (id_getAnimator_Landroid_view_ViewGroup_Landroid_view_View_ == IntPtr.Zero)
				id_getAnimator_Landroid_view_ViewGroup_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getAnimator", "(Landroid/view/ViewGroup;Landroid/view/View;)Lcom/nineoldandroids/animation/Animator;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Nineoldandroids.Animation.Animator __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallObjectMethod  (Handle, id_getAnimator_Landroid_view_ViewGroup_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnimator", "(Landroid/view/ViewGroup;Landroid/view/View;)Lcom/nineoldandroids/animation/Animator;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
