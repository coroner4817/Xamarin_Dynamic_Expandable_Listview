using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapperSetter']"
	[Register ("com/nhaarman/listviewanimations/util/ListViewWrapperSetter", "", "Com.Nhaarman.Listviewanimations.Util.IListViewWrapperSetterInvoker")]
	public partial interface IListViewWrapperSetter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapperSetter']/method[@name='setListViewWrapper' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.util.ListViewWrapper']]"
		[Register ("setListViewWrapper", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", "GetSetListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Handler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperSetterInvoker, ListViewLibs")]
		void SetListViewWrapper (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/util/ListViewWrapperSetter", DoNotGenerateAcw=true)]
	internal class IListViewWrapperSetterInvoker : global::Java.Lang.Object, IListViewWrapperSetter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/util/ListViewWrapperSetter");
		IntPtr class_ref;

		public static IListViewWrapperSetter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IListViewWrapperSetter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.util.ListViewWrapperSetter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IListViewWrapperSetterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IListViewWrapperSetterInvoker); }
		}

		static Delegate cb_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_;
#pragma warning disable 0169
		static Delegate GetSetListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Handler ()
		{
			if (cb_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ == null)
				cb_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_);
			return cb_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_;
		}

		static void n_SetListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapperSetter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapperSetter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0 = (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListViewWrapper (p0);
		}
#pragma warning restore 0169

		IntPtr id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_;
		public unsafe void SetListViewWrapper (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0)
		{
			if (id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ == IntPtr.Zero)
				id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ = JNIEnv.GetMethodID (class_ref, "setListViewWrapper", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_, __args);
		}

	}

}
