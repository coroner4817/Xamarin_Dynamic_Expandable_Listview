using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/util/AbsListViewWrapper", DoNotGenerateAcw=true)]
	public partial class AbsListViewWrapper : global::Java.Lang.Object, global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/util/AbsListViewWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbsListViewWrapper); }
		}

		protected AbsListViewWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_AbsListView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/constructor[@name='AbsListViewWrapper' and count(parameter)=1 and parameter[1][@type='android.widget.AbsListView']]"
		[Register (".ctor", "(Landroid/widget/AbsListView;)V", "")]
		public unsafe AbsListViewWrapper (global::Android.Widget.AbsListView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AbsListViewWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/AbsListView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/AbsListView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_AbsListView_ == IntPtr.Zero)
					id_ctor_Landroid_widget_AbsListView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/AbsListView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_AbsListView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_AbsListView_, __args);
			} finally {
			}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adapter);
		}
#pragma warning restore 0169

		static IntPtr id_getAdapter;
		public virtual unsafe global::Android.Widget.IListAdapter Adapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='getAdapter' and count(parameter)=0]"
			[Register ("getAdapter", "()Landroid/widget/ListAdapter;", "GetGetAdapterHandler")]
			get {
				if (id_getAdapter == IntPtr.Zero)
					id_getAdapter = JNIEnv.GetMethodID (class_ref, "getAdapter", "()Landroid/widget/ListAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter> (JNIEnv.CallObjectMethod  (Handle, id_getAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapter", "()Landroid/widget/ListAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChildCount;
		}
#pragma warning restore 0169

		static IntPtr id_getChildCount;
		public virtual unsafe int ChildCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='getChildCount' and count(parameter)=0]"
			[Register ("getChildCount", "()I", "GetGetChildCountHandler")]
			get {
				if (id_getChildCount == IntPtr.Zero)
					id_getChildCount = JNIEnv.GetMethodID (class_ref, "getChildCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getChildCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChildCount", "()I"));
				} finally {
				}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstVisiblePosition;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstVisiblePosition;
		public virtual unsafe int FirstVisiblePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='getFirstVisiblePosition' and count(parameter)=0]"
			[Register ("getFirstVisiblePosition", "()I", "GetGetFirstVisiblePositionHandler")]
			get {
				if (id_getFirstVisiblePosition == IntPtr.Zero)
					id_getFirstVisiblePosition = JNIEnv.GetMethodID (class_ref, "getFirstVisiblePosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFirstVisiblePosition);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstVisiblePosition", "()I"));
				} finally {
				}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderViewsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderViewsCount;
		public virtual unsafe int HeaderViewsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='getHeaderViewsCount' and count(parameter)=0]"
			[Register ("getHeaderViewsCount", "()I", "GetGetHeaderViewsCountHandler")]
			get {
				if (id_getHeaderViewsCount == IntPtr.Zero)
					id_getHeaderViewsCount = JNIEnv.GetMethodID (class_ref, "getHeaderViewsCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeaderViewsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderViewsCount", "()I"));
				} finally {
				}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastVisiblePosition;
		}
#pragma warning restore 0169

		static IntPtr id_getLastVisiblePosition;
		public virtual unsafe int LastVisiblePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='getLastVisiblePosition' and count(parameter)=0]"
			[Register ("getLastVisiblePosition", "()I", "GetGetLastVisiblePositionHandler")]
			get {
				if (id_getLastVisiblePosition == IntPtr.Zero)
					id_getLastVisiblePosition = JNIEnv.GetMethodID (class_ref, "getLastVisiblePosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLastVisiblePosition);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastVisiblePosition", "()I"));
				} finally {
				}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListView);
		}
#pragma warning restore 0169

		static IntPtr id_getListView;
		public virtual unsafe global::Android.Views.ViewGroup ListView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='getListView' and count(parameter)=0]"
			[Register ("getListView", "()Landroid/widget/AbsListView;", "GetGetListViewHandler")]
			get {
				if (id_getListView == IntPtr.Zero)
					id_getListView = JNIEnv.GetMethodID (class_ref, "getListView", "()Landroid/widget/AbsListView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (JNIEnv.CallObjectMethod  (Handle, id_getListView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListView", "()Landroid/widget/AbsListView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetChildAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getChildAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='getChildAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getChildAt", "(I)Landroid/view/View;", "GetGetChildAt_IHandler")]
		public virtual unsafe global::Android.Views.View GetChildAt (int p0)
		{
			if (id_getChildAt_I == IntPtr.Zero)
				id_getChildAt_I = JNIEnv.GetMethodID (class_ref, "getChildAt", "(I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getChildAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChildAt", "(I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPositionForView (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPositionForView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='getPositionForView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getPositionForView", "(Landroid/view/View;)I", "GetGetPositionForView_Landroid_view_View_Handler")]
		public virtual unsafe int GetPositionForView (global::Android.Views.View p0)
		{
			if (id_getPositionForView_Landroid_view_View_ == IntPtr.Zero)
				id_getPositionForView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getPositionForView", "(Landroid/view/View;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getPositionForView_Landroid_view_View_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionForView", "(Landroid/view/View;)I"), __args);
				return __ret;
			} finally {
			}
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
			global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.AbsListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollBy (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_smoothScrollBy_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AbsListViewWrapper']/method[@name='smoothScrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("smoothScrollBy", "(II)V", "GetSmoothScrollBy_IIHandler")]
		public virtual unsafe void SmoothScrollBy (int p0, int p1)
		{
			if (id_smoothScrollBy_II == IntPtr.Zero)
				id_smoothScrollBy_II = JNIEnv.GetMethodID (class_ref, "smoothScrollBy", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_smoothScrollBy_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smoothScrollBy", "(II)V"), __args);
			} finally {
			}
		}

	}
}
