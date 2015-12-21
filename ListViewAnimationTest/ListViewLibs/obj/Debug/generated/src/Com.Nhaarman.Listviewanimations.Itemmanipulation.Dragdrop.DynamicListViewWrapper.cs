using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DynamicListViewWrapper", DoNotGenerateAcw=true)]
	public partial class DynamicListViewWrapper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DynamicListViewWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DynamicListViewWrapper); }
		}

		protected DynamicListViewWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/constructor[@name='DynamicListViewWrapper' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.DynamicListView']]"
		[Register (".ctor", "(Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;)V", "")]
		public unsafe DynamicListViewWrapper (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DynamicListViewWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_ == IntPtr.Zero)
					id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_, __args);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adapter);
		}
#pragma warning restore 0169

		static IntPtr id_getAdapter;
		public virtual unsafe global::Android.Widget.IListAdapter Adapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='getAdapter' and count(parameter)=0]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChildCount;
		}
#pragma warning restore 0169

		static IntPtr id_getChildCount;
		public virtual unsafe int ChildCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='getChildCount' and count(parameter)=0]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='getCount' and count(parameter)=0]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstVisiblePosition;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstVisiblePosition;
		public virtual unsafe int FirstVisiblePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='getFirstVisiblePosition' and count(parameter)=0]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderViewsCount;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderViewsCount;
		public virtual unsafe int HeaderViewsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='getHeaderViewsCount' and count(parameter)=0]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastVisiblePosition;
		}
#pragma warning restore 0169

		static IntPtr id_getLastVisiblePosition;
		public virtual unsafe int LastVisiblePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='getLastVisiblePosition' and count(parameter)=0]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListView);
		}
#pragma warning restore 0169

		static IntPtr id_getListView;
		public virtual unsafe global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView ListView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='getListView' and count(parameter)=0]"
			[Register ("getListView", "()Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;", "GetGetListViewHandler")]
			get {
				if (id_getListView == IntPtr.Zero)
					id_getListView = JNIEnv.GetMethodID (class_ref, "getListView", "()Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (JNIEnv.CallObjectMethod  (Handle, id_getListView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListView", "()Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_computeVerticalScrollExtent;
#pragma warning disable 0169
		static Delegate GetComputeVerticalScrollExtentHandler ()
		{
			if (cb_computeVerticalScrollExtent == null)
				cb_computeVerticalScrollExtent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ComputeVerticalScrollExtent);
			return cb_computeVerticalScrollExtent;
		}

		static int n_ComputeVerticalScrollExtent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeVerticalScrollExtent ();
		}
#pragma warning restore 0169

		static IntPtr id_computeVerticalScrollExtent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='computeVerticalScrollExtent' and count(parameter)=0]"
		[Register ("computeVerticalScrollExtent", "()I", "GetComputeVerticalScrollExtentHandler")]
		public virtual unsafe int ComputeVerticalScrollExtent ()
		{
			if (id_computeVerticalScrollExtent == IntPtr.Zero)
				id_computeVerticalScrollExtent = JNIEnv.GetMethodID (class_ref, "computeVerticalScrollExtent", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_computeVerticalScrollExtent);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeVerticalScrollExtent", "()I"));
			} finally {
			}
		}

		static Delegate cb_computeVerticalScrollOffset;
#pragma warning disable 0169
		static Delegate GetComputeVerticalScrollOffsetHandler ()
		{
			if (cb_computeVerticalScrollOffset == null)
				cb_computeVerticalScrollOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ComputeVerticalScrollOffset);
			return cb_computeVerticalScrollOffset;
		}

		static int n_ComputeVerticalScrollOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeVerticalScrollOffset ();
		}
#pragma warning restore 0169

		static IntPtr id_computeVerticalScrollOffset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='computeVerticalScrollOffset' and count(parameter)=0]"
		[Register ("computeVerticalScrollOffset", "()I", "GetComputeVerticalScrollOffsetHandler")]
		public virtual unsafe int ComputeVerticalScrollOffset ()
		{
			if (id_computeVerticalScrollOffset == IntPtr.Zero)
				id_computeVerticalScrollOffset = JNIEnv.GetMethodID (class_ref, "computeVerticalScrollOffset", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_computeVerticalScrollOffset);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeVerticalScrollOffset", "()I"));
			} finally {
			}
		}

		static Delegate cb_computeVerticalScrollRange;
#pragma warning disable 0169
		static Delegate GetComputeVerticalScrollRangeHandler ()
		{
			if (cb_computeVerticalScrollRange == null)
				cb_computeVerticalScrollRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ComputeVerticalScrollRange);
			return cb_computeVerticalScrollRange;
		}

		static int n_ComputeVerticalScrollRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeVerticalScrollRange ();
		}
#pragma warning restore 0169

		static IntPtr id_computeVerticalScrollRange;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='computeVerticalScrollRange' and count(parameter)=0]"
		[Register ("computeVerticalScrollRange", "()I", "GetComputeVerticalScrollRangeHandler")]
		public virtual unsafe int ComputeVerticalScrollRange ()
		{
			if (id_computeVerticalScrollRange == IntPtr.Zero)
				id_computeVerticalScrollRange = JNIEnv.GetMethodID (class_ref, "computeVerticalScrollRange", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_computeVerticalScrollRange);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeVerticalScrollRange", "()I"));
			} finally {
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetChildAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getChildAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='getChildAt' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPositionForView (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPositionForView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='getPositionForView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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

		static Delegate cb_pointToPosition_II;
#pragma warning disable 0169
		static Delegate GetPointToPosition_IIHandler ()
		{
			if (cb_pointToPosition_II == null)
				cb_pointToPosition_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_PointToPosition_II);
			return cb_pointToPosition_II;
		}

		static int n_PointToPosition_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PointToPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_pointToPosition_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='pointToPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("pointToPosition", "(II)I", "GetPointToPosition_IIHandler")]
		public virtual unsafe int PointToPosition (int p0, int p1)
		{
			if (id_pointToPosition_II == IntPtr.Zero)
				id_pointToPosition_II = JNIEnv.GetMethodID (class_ref, "pointToPosition", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_pointToPosition_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pointToPosition", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_;
#pragma warning disable 0169
		static Delegate GetSetOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_Handler ()
		{
			if (cb_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ == null)
				cb_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_);
			return cb_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_;
		}

		static void n_SetOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView.IOnScrollListener p0 = (global::Android.Widget.AbsListView.IOnScrollListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView.IOnScrollListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnScrollListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='setOnScrollListener' and count(parameter)=1 and parameter[1][@type='android.widget.AbsListView.OnScrollListener']]"
		[Register ("setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V", "GetSetOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_Handler")]
		public virtual unsafe void SetOnScrollListener (global::Android.Widget.AbsListView.IOnScrollListener p0)
		{
			if (id_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ == IntPtr.Zero)
				id_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ = JNIEnv.GetMethodID (class_ref, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V"), __args);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DynamicListViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollBy (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_smoothScrollBy_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DynamicListViewWrapper']/method[@name='smoothScrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
