using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Appearance {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ResourceAnimationAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/appearance/ResourceAnimationAdapter", DoNotGenerateAcw=true)]
	public abstract partial class ResourceAnimationAdapter : global::Com.Nhaarman.Listviewanimations.Appearance.AnimationAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/appearance/ResourceAnimationAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceAnimationAdapter); }
		}

		protected ResourceAnimationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ResourceAnimationAdapter']/constructor[@name='ResourceAnimationAdapter' and count(parameter)=2 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;Landroid/content/Context;)V", "")]
		protected unsafe ResourceAnimationAdapter (global::Android.Widget.BaseAdapter p0, global::Android.Content.Context p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ResourceAnimationAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAnimationResourceId;
#pragma warning disable 0169
		static Delegate GetGetAnimationResourceIdHandler ()
		{
			if (cb_getAnimationResourceId == null)
				cb_getAnimationResourceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAnimationResourceId);
			return cb_getAnimationResourceId;
		}

		static int n_GetAnimationResourceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ResourceAnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ResourceAnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnimationResourceId;
		}
#pragma warning restore 0169

		protected abstract int AnimationResourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ResourceAnimationAdapter']/method[@name='getAnimationResourceId' and count(parameter)=0]"
			[Register ("getAnimationResourceId", "()I", "GetGetAnimationResourceIdHandler")] get;
		}

		static Delegate cb_getAnimators_Landroid_view_ViewGroup_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetAnimators_Landroid_view_ViewGroup_Landroid_view_View_Handler ()
		{
			if (cb_getAnimators_Landroid_view_ViewGroup_Landroid_view_View_ == null)
				cb_getAnimators_Landroid_view_ViewGroup_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAnimators_Landroid_view_ViewGroup_Landroid_view_View_);
			return cb_getAnimators_Landroid_view_ViewGroup_Landroid_view_View_;
		}

		static IntPtr n_GetAnimators_Landroid_view_ViewGroup_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Appearance.ResourceAnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Appearance.ResourceAnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAnimators (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAnimators_Landroid_view_ViewGroup_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ResourceAnimationAdapter']/method[@name='getAnimators' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='android.view.View']]"
		[Register ("getAnimators", "(Landroid/view/ViewGroup;Landroid/view/View;)[Lcom/nineoldandroids/animation/Animator;", "GetGetAnimators_Landroid_view_ViewGroup_Landroid_view_View_Handler")]
		public override unsafe global::Com.Nineoldandroids.Animation.Animator[] GetAnimators (global::Android.Views.ViewGroup p0, global::Android.Views.View p1)
		{
			if (id_getAnimators_Landroid_view_ViewGroup_Landroid_view_View_ == IntPtr.Zero)
				id_getAnimators_Landroid_view_ViewGroup_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getAnimators", "(Landroid/view/ViewGroup;Landroid/view/View;)[Lcom/nineoldandroids/animation/Animator;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Nineoldandroids.Animation.Animator[] __ret;
				if (GetType () == ThresholdType)
					__ret = (global::Com.Nineoldandroids.Animation.Animator[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAnimators_Landroid_view_ViewGroup_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nineoldandroids.Animation.Animator));
				else
					__ret = (global::Com.Nineoldandroids.Animation.Animator[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnimators", "(Landroid/view/ViewGroup;Landroid/view/View;)[Lcom/nineoldandroids/animation/Animator;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nineoldandroids.Animation.Animator));
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/appearance/ResourceAnimationAdapter", DoNotGenerateAcw=true)]
	internal partial class ResourceAnimationAdapterInvoker : ResourceAnimationAdapter {

		public ResourceAnimationAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceAnimationAdapterInvoker); }
		}

		static IntPtr id_getAnimationResourceId;
		protected override unsafe int AnimationResourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.appearance']/class[@name='ResourceAnimationAdapter']/method[@name='getAnimationResourceId' and count(parameter)=0]"
			[Register ("getAnimationResourceId", "()I", "GetGetAnimationResourceIdHandler")]
			get {
				if (id_getAnimationResourceId == IntPtr.Zero)
					id_getAnimationResourceId = JNIEnv.GetMethodID (class_ref, "getAnimationResourceId", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getAnimationResourceId);
				} finally {
				}
			}
		}

	}

}
