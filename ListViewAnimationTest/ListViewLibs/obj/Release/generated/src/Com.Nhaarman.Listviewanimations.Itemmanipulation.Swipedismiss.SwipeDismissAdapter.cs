using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissAdapter", DoNotGenerateAcw=true)]
	public partial class SwipeDismissAdapter : global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeDismissAdapter); }
		}

		protected SwipeDismissAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/constructor[@name='SwipeDismissAdapter' and count(parameter)=2 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.OnDismissCallback']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", "")]
		public unsafe SwipeDismissAdapter (global::Android.Widget.BaseAdapter p0, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IOnDismissCallback p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SwipeDismissAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ == IntPtr.Zero)
					id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_, __args);
			} finally {
			}
		}

		static Delegate cb_getDismissTouchListener;
#pragma warning disable 0169
		static Delegate GetGetDismissTouchListenerHandler ()
		{
			if (cb_getDismissTouchListener == null)
				cb_getDismissTouchListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDismissTouchListener);
			return cb_getDismissTouchListener;
		}

		static IntPtr n_GetDismissTouchListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DismissTouchListener);
		}
#pragma warning restore 0169

		static IntPtr id_getDismissTouchListener;
		public virtual unsafe global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener DismissTouchListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/method[@name='getDismissTouchListener' and count(parameter)=0]"
			[Register ("getDismissTouchListener", "()Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener;", "GetGetDismissTouchListenerHandler")]
			get {
				if (id_getDismissTouchListener == IntPtr.Zero)
					id_getDismissTouchListener = JNIEnv.GetMethodID (class_ref, "getDismissTouchListener", "()Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (JNIEnv.CallObjectMethod  (Handle, id_getDismissTouchListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDismissTouchListener", "()Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_dismiss_I;
#pragma warning disable 0169
		static Delegate GetDismiss_IHandler ()
		{
			if (cb_dismiss_I == null)
				cb_dismiss_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Dismiss_I);
			return cb_dismiss_I;
		}

		static void n_Dismiss_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dismiss_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/method[@name='dismiss' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("dismiss", "(I)V", "GetDismiss_IHandler")]
		public virtual unsafe void Dismiss (int p0)
		{
			if (id_dismiss_I == IntPtr.Zero)
				id_dismiss_I = JNIEnv.GetMethodID (class_ref, "dismiss", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dismiss_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dismiss", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
#pragma warning disable 0169
		static Delegate GetSetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_Handler ()
		{
			if (cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ == null)
				cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_);
			return cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
		}

		static void n_SetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDismissableManager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/method[@name='setDismissableManager' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.DismissableManager']]"
		[Register ("setDismissableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager;)V", "GetSetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_Handler")]
		public virtual unsafe void SetDismissableManager (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager p0)
		{
			if (id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ == IntPtr.Zero)
				id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ = JNIEnv.GetMethodID (class_ref, "setDismissableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDismissableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setParentIsHorizontalScrollContainer;
#pragma warning disable 0169
		static Delegate GetSetParentIsHorizontalScrollContainerHandler ()
		{
			if (cb_setParentIsHorizontalScrollContainer == null)
				cb_setParentIsHorizontalScrollContainer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetParentIsHorizontalScrollContainer);
			return cb_setParentIsHorizontalScrollContainer;
		}

		static void n_SetParentIsHorizontalScrollContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetParentIsHorizontalScrollContainer ();
		}
#pragma warning restore 0169

		static IntPtr id_setParentIsHorizontalScrollContainer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/method[@name='setParentIsHorizontalScrollContainer' and count(parameter)=0]"
		[Register ("setParentIsHorizontalScrollContainer", "()V", "GetSetParentIsHorizontalScrollContainerHandler")]
		public virtual unsafe void SetParentIsHorizontalScrollContainer ()
		{
			if (id_setParentIsHorizontalScrollContainer == IntPtr.Zero)
				id_setParentIsHorizontalScrollContainer = JNIEnv.GetMethodID (class_ref, "setParentIsHorizontalScrollContainer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setParentIsHorizontalScrollContainer);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParentIsHorizontalScrollContainer", "()V"));
			} finally {
			}
		}

		static Delegate cb_setSwipeTouchChildResId_I;
#pragma warning disable 0169
		static Delegate GetSetSwipeTouchChildResId_IHandler ()
		{
			if (cb_setSwipeTouchChildResId_I == null)
				cb_setSwipeTouchChildResId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSwipeTouchChildResId_I);
			return cb_setSwipeTouchChildResId_I;
		}

		static void n_SetSwipeTouchChildResId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSwipeTouchChildResId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSwipeTouchChildResId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/method[@name='setSwipeTouchChildResId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSwipeTouchChildResId", "(I)V", "GetSetSwipeTouchChildResId_IHandler")]
		public virtual unsafe void SetSwipeTouchChildResId (int p0)
		{
			if (id_setSwipeTouchChildResId_I == IntPtr.Zero)
				id_setSwipeTouchChildResId_I = JNIEnv.GetMethodID (class_ref, "setSwipeTouchChildResId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSwipeTouchChildResId_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSwipeTouchChildResId", "(I)V"), __args);
			} finally {
			}
		}

	}
}
