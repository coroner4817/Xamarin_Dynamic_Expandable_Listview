using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoTouchListener']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SwipeUndoTouchListener", DoNotGenerateAcw=true)]
	public partial class SwipeUndoTouchListener : global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoTouchListener.UndoAnimatorListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SwipeUndoTouchListener$UndoAnimatorListener", DoNotGenerateAcw=true)]
		public partial class UndoAnimatorListener : global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter {

			protected UndoAnimatorListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SwipeUndoTouchListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeUndoTouchListener); }
		}

		protected SwipeUndoTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoTouchListener']/constructor[@name='SwipeUndoTouchListener' and count(parameter)=2 and parameter[1][@type='com.nhaarman.listviewanimations.util.ListViewWrapper'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo.UndoCallback']]"
		[Register (".ctor", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V", "")]
		public unsafe SwipeUndoTouchListener (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SwipeUndoTouchListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ == IntPtr.Zero)
					id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_, __args);
			} finally {
			}
		}

		static Delegate cb_hasPendingItems;
#pragma warning disable 0169
		static Delegate GetHasPendingItemsHandler ()
		{
			if (cb_hasPendingItems == null)
				cb_hasPendingItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPendingItems);
			return cb_hasPendingItems;
		}

		static bool n_HasPendingItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPendingItems;
		}
#pragma warning restore 0169

		static IntPtr id_hasPendingItems;
		public virtual unsafe bool HasPendingItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoTouchListener']/method[@name='hasPendingItems' and count(parameter)=0]"
			[Register ("hasPendingItems", "()Z", "GetHasPendingItemsHandler")]
			get {
				if (id_hasPendingItems == IntPtr.Zero)
					id_hasPendingItems = JNIEnv.GetMethodID (class_ref, "hasPendingItems", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasPendingItems);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasPendingItems", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_dimissPending;
#pragma warning disable 0169
		static Delegate GetDimissPendingHandler ()
		{
			if (cb_dimissPending == null)
				cb_dimissPending = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DimissPending);
			return cb_dimissPending;
		}

		static void n_DimissPending (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DimissPending ();
		}
#pragma warning restore 0169

		static IntPtr id_dimissPending;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoTouchListener']/method[@name='dimissPending' and count(parameter)=0]"
		[Register ("dimissPending", "()V", "GetDimissPendingHandler")]
		public virtual unsafe void DimissPending ()
		{
			if (id_dimissPending == IntPtr.Zero)
				id_dimissPending = JNIEnv.GetMethodID (class_ref, "dimissPending", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dimissPending);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dimissPending", "()V"));
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Undo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_undo_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SwipeUndoTouchListener']/method[@name='undo' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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
}
