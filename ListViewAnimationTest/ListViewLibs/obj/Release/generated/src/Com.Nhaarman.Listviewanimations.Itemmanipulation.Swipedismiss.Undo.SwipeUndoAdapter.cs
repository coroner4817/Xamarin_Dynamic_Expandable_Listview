using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SwipeUndoAdapter", DoNotGenerateAcw=true)]
	public abstract partial class SwipeUndoAdapter : global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SwipeUndoAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeUndoAdapter); }
		}

		protected SwipeUndoAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoAdapter']/constructor[@name='SwipeUndoAdapter' and count(parameter)=2 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo.UndoCallback']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V", "")]
		protected unsafe SwipeUndoAdapter (global::Android.Widget.BaseAdapter p0, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SwipeUndoAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ == IntPtr.Zero)
					id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_, __args);
			} finally {
			}
		}

		static Delegate cb_getUndoCallback;
#pragma warning disable 0169
		static Delegate GetGetUndoCallbackHandler ()
		{
			if (cb_getUndoCallback == null)
				cb_getUndoCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUndoCallback);
			return cb_getUndoCallback;
		}

		static IntPtr n_GetUndoCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UndoCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_;
#pragma warning disable 0169
		static Delegate GetSetUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_Handler ()
		{
			if (cb_setUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ == null)
				cb_setUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_);
			return cb_setUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_;
		}

		static void n_SetUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UndoCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUndoCallback;
		static IntPtr id_setUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_;
		public virtual unsafe global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback UndoCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoAdapter']/method[@name='getUndoCallback' and count(parameter)=0]"
			[Register ("getUndoCallback", "()Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;", "GetGetUndoCallbackHandler")]
			get {
				if (id_getUndoCallback == IntPtr.Zero)
					id_getUndoCallback = JNIEnv.GetMethodID (class_ref, "getUndoCallback", "()Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (JNIEnv.CallObjectMethod  (Handle, id_getUndoCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUndoCallback", "()Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoAdapter']/method[@name='setUndoCallback' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo.UndoCallback']]"
			[Register ("setUndoCallback", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V", "GetSetUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_Handler")]
			set {
				if (id_setUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ == IntPtr.Zero)
					id_setUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ = JNIEnv.GetMethodID (class_ref, "setUndoCallback", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUndoCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUndoCallback", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V"), __args);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dismiss_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoAdapter']/method[@name='dismiss' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDismissableManager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoAdapter']/method[@name='setDismissableManager' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.DismissableManager']]"
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

		static Delegate cb_setSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_;
#pragma warning disable 0169
		static Delegate GetSetSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_Handler ()
		{
			if (cb_setSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_ == null)
				cb_setSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_);
			return cb_setSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_;
		}

		static void n_SetSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoTouchListener p0 = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoTouchListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSwipeUndoTouchListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoAdapter']/method[@name='setSwipeUndoTouchListener' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo.SwipeUndoTouchListener']]"
		[Register ("setSwipeUndoTouchListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SwipeUndoTouchListener;)V", "GetSetSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_Handler")]
		public virtual unsafe void SetSwipeUndoTouchListener (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoTouchListener p0)
		{
			if (id_setSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_ == IntPtr.Zero)
				id_setSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_ = JNIEnv.GetMethodID (class_ref, "setSwipeUndoTouchListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SwipeUndoTouchListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSwipeUndoTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_SwipeUndoTouchListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSwipeUndoTouchListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SwipeUndoTouchListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_undo_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetUndo_Landroid_view_View_Handler ()
		{
			if (cb_undo_Landroid_view_View_ == null)
				cb_undo_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Undo_Landroid_view_View_);
			return cb_undo_Landroid_view_View_;
		}

		static void n_Undo_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Undo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_undo_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoAdapter']/method[@name='undo' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("undo", "(Landroid/view/View;)V", "GetUndo_Landroid_view_View_Handler")]
		public virtual unsafe void Undo (global::Android.Views.View p0)
		{
			if (id_undo_Landroid_view_View_ == IntPtr.Zero)
				id_undo_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "undo", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_undo_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "undo", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SwipeUndoAdapter", DoNotGenerateAcw=true)]
	internal partial class SwipeUndoAdapterInvoker : SwipeUndoAdapter {

		public SwipeUndoAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeUndoAdapterInvoker); }
		}

	}

}
