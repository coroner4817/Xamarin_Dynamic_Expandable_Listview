using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/interface[@name='UndoAdapter']"
	[Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoAdapter", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoAdapterInvoker")]
	public partial interface IUndoAdapter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/interface[@name='UndoAdapter']/method[@name='getUndoClickView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getUndoClickView", "(Landroid/view/View;)Landroid/view/View;", "GetGetUndoClickView_Landroid_view_View_Handler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoAdapterInvoker, ListViewLibs")]
		global::Android.Views.View GetUndoClickView (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/interface[@name='UndoAdapter']/method[@name='getUndoView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getUndoView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetUndoView_ILandroid_view_View_Landroid_view_ViewGroup_Handler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoAdapterInvoker, ListViewLibs")]
		global::Android.Views.View GetUndoView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoAdapter", DoNotGenerateAcw=true)]
	internal class IUndoAdapterInvoker : global::Java.Lang.Object, IUndoAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoAdapter");
		IntPtr class_ref;

		public static IUndoAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUndoAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo.UndoAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUndoAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUndoAdapterInvoker); }
		}

		static Delegate cb_getUndoClickView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetUndoClickView_Landroid_view_View_Handler ()
		{
			if (cb_getUndoClickView_Landroid_view_View_ == null)
				cb_getUndoClickView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUndoClickView_Landroid_view_View_);
			return cb_getUndoClickView_Landroid_view_View_;
		}

		static IntPtr n_GetUndoClickView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUndoClickView (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getUndoClickView_Landroid_view_View_;
		public unsafe global::Android.Views.View GetUndoClickView (global::Android.Views.View p0)
		{
			if (id_getUndoClickView_Landroid_view_View_ == IntPtr.Zero)
				id_getUndoClickView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getUndoClickView", "(Landroid/view/View;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getUndoClickView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getUndoView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetUndoView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getUndoView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getUndoView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetUndoView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getUndoView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetUndoView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUndoView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getUndoView_ILandroid_view_View_Landroid_view_ViewGroup_;
		public unsafe global::Android.Views.View GetUndoView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getUndoView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getUndoView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getUndoView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getUndoView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
