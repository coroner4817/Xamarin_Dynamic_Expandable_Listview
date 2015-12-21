using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']"
	[Register ("com/nhaarman/listviewanimations/util/ListViewWrapper", "", "Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker")]
	public partial interface IListViewWrapper : IJavaObject {

		global::Android.Widget.IListAdapter Adapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='getAdapter' and count(parameter)=0]"
			[Register ("getAdapter", "()Landroid/widget/ListAdapter;", "GetGetAdapterHandler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")] get;
		}

		int ChildCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='getChildCount' and count(parameter)=0]"
			[Register ("getChildCount", "()I", "GetGetChildCountHandler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")] get;
		}

		int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")] get;
		}

		int FirstVisiblePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='getFirstVisiblePosition' and count(parameter)=0]"
			[Register ("getFirstVisiblePosition", "()I", "GetGetFirstVisiblePositionHandler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")] get;
		}

		int HeaderViewsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='getHeaderViewsCount' and count(parameter)=0]"
			[Register ("getHeaderViewsCount", "()I", "GetGetHeaderViewsCountHandler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")] get;
		}

		int LastVisiblePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='getLastVisiblePosition' and count(parameter)=0]"
			[Register ("getLastVisiblePosition", "()I", "GetGetLastVisiblePositionHandler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")] get;
		}

		global::Android.Views.ViewGroup ListView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='getListView' and count(parameter)=0]"
			[Register ("getListView", "()Landroid/view/ViewGroup;", "GetGetListViewHandler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='getChildAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getChildAt", "(I)Landroid/view/View;", "GetGetChildAt_IHandler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")]
		global::Android.Views.View GetChildAt (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='getPositionForView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getPositionForView", "(Landroid/view/View;)I", "GetGetPositionForView_Landroid_view_View_Handler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")]
		int GetPositionForView (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='ListViewWrapper']/method[@name='smoothScrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("smoothScrollBy", "(II)V", "GetSmoothScrollBy_IIHandler:Com.Nhaarman.Listviewanimations.Util.IListViewWrapperInvoker, ListViewLibs")]
		void SmoothScrollBy (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/util/ListViewWrapper", DoNotGenerateAcw=true)]
	internal class IListViewWrapperInvoker : global::Java.Lang.Object, IListViewWrapper {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/util/ListViewWrapper");
		IntPtr class_ref;

		public static IListViewWrapper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IListViewWrapper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.util.ListViewWrapper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IListViewWrapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IListViewWrapperInvoker); }
		}

		static Delegate cb_getAdapter;
#pragma warning disable 0169
		static Delegate GetGetAdapterHandler ()
		{
			if (cb_getAdapter == null)
				cb_getAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdapter);
			return cb_getAdapter;
		}

		static IntPtr n_GetAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adapter);
		}
#pragma warning restore 0169

		IntPtr id_getAdapter;
		public unsafe global::Android.Widget.IListAdapter Adapter {
			get {
				if (id_getAdapter == IntPtr.Zero)
					id_getAdapter = JNIEnv.GetMethodID (class_ref, "getAdapter", "()Landroid/widget/ListAdapter;");
				return global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter> (JNIEnv.CallObjectMethod (Handle, id_getAdapter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getChildCount;
#pragma warning disable 0169
		static Delegate GetGetChildCountHandler ()
		{
			if (cb_getChildCount == null)
				cb_getChildCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChildCount);
			return cb_getChildCount;
		}

		static int n_GetChildCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChildCount;
		}
#pragma warning restore 0169

		IntPtr id_getChildCount;
		public unsafe int ChildCount {
			get {
				if (id_getChildCount == IntPtr.Zero)
					id_getChildCount = JNIEnv.GetMethodID (class_ref, "getChildCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getChildCount);
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		IntPtr id_getCount;
		public unsafe int Count {
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCount);
			}
		}

		static Delegate cb_getFirstVisiblePosition;
#pragma warning disable 0169
		static Delegate GetGetFirstVisiblePositionHandler ()
		{
			if (cb_getFirstVisiblePosition == null)
				cb_getFirstVisiblePosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFirstVisiblePosition);
			return cb_getFirstVisiblePosition;
		}

		static int n_GetFirstVisiblePosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstVisiblePosition;
		}
#pragma warning restore 0169

		IntPtr id_getFirstVisiblePosition;
		public unsafe int FirstVisiblePosition {
			get {
				if (id_getFirstVisiblePosition == IntPtr.Zero)
					id_getFirstVisiblePosition = JNIEnv.GetMethodID (class_ref, "getFirstVisiblePosition", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getFirstVisiblePosition);
			}
		}

		static Delegate cb_getHeaderViewsCount;
#pragma warning disable 0169
		static Delegate GetGetHeaderViewsCountHandler ()
		{
			if (cb_getHeaderViewsCount == null)
				cb_getHeaderViewsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderViewsCount);
			return cb_getHeaderViewsCount;
		}

		static int n_GetHeaderViewsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderViewsCount;
		}
#pragma warning restore 0169

		IntPtr id_getHeaderViewsCount;
		public unsafe int HeaderViewsCount {
			get {
				if (id_getHeaderViewsCount == IntPtr.Zero)
					id_getHeaderViewsCount = JNIEnv.GetMethodID (class_ref, "getHeaderViewsCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getHeaderViewsCount);
			}
		}

		static Delegate cb_getLastVisiblePosition;
#pragma warning disable 0169
		static Delegate GetGetLastVisiblePositionHandler ()
		{
			if (cb_getLastVisiblePosition == null)
				cb_getLastVisiblePosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastVisiblePosition);
			return cb_getLastVisiblePosition;
		}

		static int n_GetLastVisiblePosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastVisiblePosition;
		}
#pragma warning restore 0169

		IntPtr id_getLastVisiblePosition;
		public unsafe int LastVisiblePosition {
			get {
				if (id_getLastVisiblePosition == IntPtr.Zero)
					id_getLastVisiblePosition = JNIEnv.GetMethodID (class_ref, "getLastVisiblePosition", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLastVisiblePosition);
			}
		}

		static Delegate cb_getListView;
#pragma warning disable 0169
		static Delegate GetGetListViewHandler ()
		{
			if (cb_getListView == null)
				cb_getListView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListView);
			return cb_getListView;
		}

		static IntPtr n_GetListView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListView);
		}
#pragma warning restore 0169

		IntPtr id_getListView;
		public unsafe global::Android.Views.ViewGroup ListView {
			get {
				if (id_getListView == IntPtr.Zero)
					id_getListView = JNIEnv.GetMethodID (class_ref, "getListView", "()Landroid/view/ViewGroup;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (JNIEnv.CallObjectMethod (Handle, id_getListView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getChildAt_I;
#pragma warning disable 0169
		static Delegate GetGetChildAt_IHandler ()
		{
			if (cb_getChildAt_I == null)
				cb_getChildAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetChildAt_I);
			return cb_getChildAt_I;
		}

		static IntPtr n_GetChildAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetChildAt (p0));
		}
#pragma warning restore 0169

		IntPtr id_getChildAt_I;
		public unsafe global::Android.Views.View GetChildAt (int p0)
		{
			if (id_getChildAt_I == IntPtr.Zero)
				id_getChildAt_I = JNIEnv.GetMethodID (class_ref, "getChildAt", "(I)Landroid/view/View;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getChildAt_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getPositionForView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetPositionForView_Landroid_view_View_Handler ()
		{
			if (cb_getPositionForView_Landroid_view_View_ == null)
				cb_getPositionForView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetPositionForView_Landroid_view_View_);
			return cb_getPositionForView_Landroid_view_View_;
		}

		static int n_GetPositionForView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPositionForView (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPositionForView_Landroid_view_View_;
		public unsafe int GetPositionForView (global::Android.Views.View p0)
		{
			if (id_getPositionForView_Landroid_view_View_ == IntPtr.Zero)
				id_getPositionForView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getPositionForView", "(Landroid/view/View;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			int __ret = JNIEnv.CallIntMethod (Handle, id_getPositionForView_Landroid_view_View_, __args);
			return __ret;
		}

		static Delegate cb_smoothScrollBy_II;
#pragma warning disable 0169
		static Delegate GetSmoothScrollBy_IIHandler ()
		{
			if (cb_smoothScrollBy_II == null)
				cb_smoothScrollBy_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SmoothScrollBy_II);
			return cb_smoothScrollBy_II;
		}

		static void n_SmoothScrollBy_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollBy (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_smoothScrollBy_II;
		public unsafe void SmoothScrollBy (int p0, int p1)
		{
			if (id_smoothScrollBy_II == IntPtr.Zero)
				id_smoothScrollBy_II = JNIEnv.GetMethodID (class_ref, "smoothScrollBy", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_smoothScrollBy_II, __args);
		}

	}

}
