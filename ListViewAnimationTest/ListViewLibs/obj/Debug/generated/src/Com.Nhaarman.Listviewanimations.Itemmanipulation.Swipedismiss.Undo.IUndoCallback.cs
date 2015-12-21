using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/interface[@name='UndoCallback']"
	[Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallbackInvoker")]
	public partial interface IUndoCallback : global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IOnDismissCallback {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/interface[@name='UndoCallback']/method[@name='getPrimaryView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getPrimaryView", "(Landroid/view/View;)Landroid/view/View;", "GetGetPrimaryView_Landroid_view_View_Handler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallbackInvoker, ListViewLibs")]
		global::Android.Views.View GetPrimaryView (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/interface[@name='UndoCallback']/method[@name='getUndoView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getUndoView", "(Landroid/view/View;)Landroid/view/View;", "GetGetUndoView_Landroid_view_View_Handler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallbackInvoker, ListViewLibs")]
		global::Android.Views.View GetUndoView (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/interface[@name='UndoCallback']/method[@name='onDismiss' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onDismiss", "(Landroid/view/View;I)V", "GetOnDismiss_Landroid_view_View_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallbackInvoker, ListViewLibs")]
		void OnDismiss (global::Android.Views.View p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/interface[@name='UndoCallback']/method[@name='onUndo' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onUndo", "(Landroid/view/View;I)V", "GetOnUndo_Landroid_view_View_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallbackInvoker, ListViewLibs")]
		void OnUndo (global::Android.Views.View p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/interface[@name='UndoCallback']/method[@name='onUndoShown' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onUndoShown", "(Landroid/view/View;I)V", "GetOnUndoShown_Landroid_view_View_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallbackInvoker, ListViewLibs")]
		void OnUndoShown (global::Android.Views.View p0, int p1);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback", DoNotGenerateAcw=true)]
	internal class IUndoCallbackInvoker : global::Java.Lang.Object, IUndoCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback");
		IntPtr class_ref;

		public static IUndoCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUndoCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo.UndoCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUndoCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUndoCallbackInvoker); }
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPrimaryView (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPrimaryView_Landroid_view_View_;
		public unsafe global::Android.Views.View GetPrimaryView (global::Android.Views.View p0)
		{
			if (id_getPrimaryView_Landroid_view_View_ == IntPtr.Zero)
				id_getPrimaryView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getPrimaryView", "(Landroid/view/View;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getPrimaryView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUndoView (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getUndoView_Landroid_view_View_;
		public unsafe global::Android.Views.View GetUndoView (global::Android.Views.View p0)
		{
			if (id_getUndoView_Landroid_view_View_ == IntPtr.Zero)
				id_getUndoView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getUndoView", "(Landroid/view/View;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getUndoView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDismiss (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDismiss_Landroid_view_View_I;
		public unsafe void OnDismiss (global::Android.Views.View p0, int p1)
		{
			if (id_onDismiss_Landroid_view_View_I == IntPtr.Zero)
				id_onDismiss_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onDismiss", "(Landroid/view/View;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onDismiss_Landroid_view_View_I, __args);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUndo (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onUndo_Landroid_view_View_I;
		public unsafe void OnUndo (global::Android.Views.View p0, int p1)
		{
			if (id_onUndo_Landroid_view_View_I == IntPtr.Zero)
				id_onUndo_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onUndo", "(Landroid/view/View;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onUndo_Landroid_view_View_I, __args);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUndoShown (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onUndoShown_Landroid_view_View_I;
		public unsafe void OnUndoShown (global::Android.Views.View p0, int p1)
		{
			if (id_onUndoShown_Landroid_view_View_I == IntPtr.Zero)
				id_onUndoShown_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onUndoShown", "(Landroid/view/View;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onUndoShown_Landroid_view_View_I, __args);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnDismiss (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onDismiss_Landroid_view_ViewGroup_arrayI;
		public unsafe void OnDismiss (global::Android.Views.ViewGroup p0, int[] p1)
		{
			if (id_onDismiss_Landroid_view_ViewGroup_arrayI == IntPtr.Zero)
				id_onDismiss_Landroid_view_ViewGroup_arrayI = JNIEnv.GetMethodID (class_ref, "onDismiss", "(Landroid/view/ViewGroup;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_onDismiss_Landroid_view_ViewGroup_arrayI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
