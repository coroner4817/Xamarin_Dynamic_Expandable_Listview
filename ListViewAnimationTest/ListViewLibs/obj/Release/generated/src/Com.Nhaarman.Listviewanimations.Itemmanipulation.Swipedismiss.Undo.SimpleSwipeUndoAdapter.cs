using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SimpleSwipeUndoAdapter", DoNotGenerateAcw=true)]
	public partial class SimpleSwipeUndoAdapter : global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SwipeUndoAdapter, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter.UndoClickListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SimpleSwipeUndoAdapter$UndoClickListener", DoNotGenerateAcw=true)]
		public partial class UndoClickListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SimpleSwipeUndoAdapter$UndoClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UndoClickListener); }
			}

			protected UndoClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Handler ()
			{
				if (cb_onClick_Landroid_view_View_ == null)
					cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
				return cb_onClick_Landroid_view_View_;
			}

			static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter.UndoClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter.UndoClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onClick_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter.UndoClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
			public virtual unsafe void OnClick (global::Android.Views.View p0)
			{
				if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
					id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onClick_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/SimpleSwipeUndoAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleSwipeUndoAdapter); }
		}

		protected SimpleSwipeUndoAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter']/constructor[@name='SimpleSwipeUndoAdapter' and count(parameter)=3 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.OnDismissCallback']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;Landroid/content/Context;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", "")]
		public unsafe SimpleSwipeUndoAdapter (global::Android.Widget.BaseAdapter p0, global::Android.Content.Context p1, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IOnDismissCallback p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SimpleSwipeUndoAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;Landroid/content/Context;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;Landroid/content/Context;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ == IntPtr.Zero)
					id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;Landroid/content/Context;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_, __args);
			} finally {
			}
		}

		static Delegate cb_getPrimaryView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetPrimaryView_Landroid_view_View_Handler ()
		{
			if (cb_getPrimaryView_Landroid_view_View_ == null)
				cb_getPrimaryView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPrimaryView_Landroid_view_View_);
			return cb_getPrimaryView_Landroid_view_View_;
		}

		static IntPtr n_GetPrimaryView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPrimaryView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPrimaryView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter']/method[@name='getPrimaryView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getPrimaryView", "(Landroid/view/View;)Landroid/view/View;", "GetGetPrimaryView_Landroid_view_View_Handler")]
		public virtual unsafe global::Android.Views.View GetPrimaryView (global::Android.Views.View p0)
		{
			if (id_getPrimaryView_Landroid_view_View_ == IntPtr.Zero)
				id_getPrimaryView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getPrimaryView", "(Landroid/view/View;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getPrimaryView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrimaryView", "(Landroid/view/View;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getUndoView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetUndoView_Landroid_view_View_Handler ()
		{
			if (cb_getUndoView_Landroid_view_View_ == null)
				cb_getUndoView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUndoView_Landroid_view_View_);
			return cb_getUndoView_Landroid_view_View_;
		}

		static IntPtr n_GetUndoView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUndoView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUndoView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter']/method[@name='getUndoView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getUndoView", "(Landroid/view/View;)Landroid/view/View;", "GetGetUndoView_Landroid_view_View_Handler")]
		public virtual unsafe global::Android.Views.View GetUndoView (global::Android.Views.View p0)
		{
			if (id_getUndoView_Landroid_view_View_ == IntPtr.Zero)
				id_getUndoView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getUndoView", "(Landroid/view/View;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getUndoView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUndoView", "(Landroid/view/View;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onDismiss_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnDismiss_Landroid_view_View_IHandler ()
		{
			if (cb_onDismiss_Landroid_view_View_I == null)
				cb_onDismiss_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnDismiss_Landroid_view_View_I);
			return cb_onDismiss_Landroid_view_View_I;
		}

		static void n_OnDismiss_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDismiss (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDismiss_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter']/method[@name='onDismiss' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onDismiss", "(Landroid/view/View;I)V", "GetOnDismiss_Landroid_view_View_IHandler")]
		public virtual unsafe void OnDismiss (global::Android.Views.View p0, int p1)
		{
			if (id_onDismiss_Landroid_view_View_I == IntPtr.Zero)
				id_onDismiss_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onDismiss", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDismiss_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDismiss", "(Landroid/view/View;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDismiss_Landroid_view_ViewGroup_arrayI;
#pragma warning disable 0169
		static Delegate GetOnDismiss_Landroid_view_ViewGroup_arrayIHandler ()
		{
			if (cb_onDismiss_Landroid_view_ViewGroup_arrayI == null)
				cb_onDismiss_Landroid_view_ViewGroup_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDismiss_Landroid_view_ViewGroup_arrayI);
			return cb_onDismiss_Landroid_view_ViewGroup_arrayI;
		}

		static void n_OnDismiss_Landroid_view_ViewGroup_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnDismiss (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDismiss_Landroid_view_ViewGroup_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter']/method[@name='onDismiss' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int[]']]"
		[Register ("onDismiss", "(Landroid/view/ViewGroup;[I)V", "GetOnDismiss_Landroid_view_ViewGroup_arrayIHandler")]
		public virtual unsafe void OnDismiss (global::Android.Views.ViewGroup p0, int[] p1)
		{
			if (id_onDismiss_Landroid_view_ViewGroup_arrayI == IntPtr.Zero)
				id_onDismiss_Landroid_view_ViewGroup_arrayI = JNIEnv.GetMethodID (class_ref, "onDismiss", "(Landroid/view/ViewGroup;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDismiss_Landroid_view_ViewGroup_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDismiss", "(Landroid/view/ViewGroup;[I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_onUndo_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnUndo_Landroid_view_View_IHandler ()
		{
			if (cb_onUndo_Landroid_view_View_I == null)
				cb_onUndo_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnUndo_Landroid_view_View_I);
			return cb_onUndo_Landroid_view_View_I;
		}

		static void n_OnUndo_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUndo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onUndo_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter']/method[@name='onUndo' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onUndo", "(Landroid/view/View;I)V", "GetOnUndo_Landroid_view_View_IHandler")]
		public virtual unsafe void OnUndo (global::Android.Views.View p0, int p1)
		{
			if (id_onUndo_Landroid_view_View_I == IntPtr.Zero)
				id_onUndo_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onUndo", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUndo_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUndo", "(Landroid/view/View;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUndoShown_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnUndoShown_Landroid_view_View_IHandler ()
		{
			if (cb_onUndoShown_Landroid_view_View_I == null)
				cb_onUndoShown_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnUndoShown_Landroid_view_View_I);
			return cb_onUndoShown_Landroid_view_View_I;
		}

		static void n_OnUndoShown_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUndoShown (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onUndoShown_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='SimpleSwipeUndoAdapter']/method[@name='onUndoShown' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onUndoShown", "(Landroid/view/View;I)V", "GetOnUndoShown_Landroid_view_View_IHandler")]
		public virtual unsafe void OnUndoShown (global::Android.Views.View p0, int p1)
		{
			if (id_onUndoShown_Landroid_view_View_I == IntPtr.Zero)
				id_onUndoShown_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onUndoShown", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUndoShown_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUndoShown", "(Landroid/view/View;I)V"), __args);
			} finally {
			}
		}

	}
}
