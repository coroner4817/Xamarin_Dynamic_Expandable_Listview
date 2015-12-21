using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AdapterViewUtil']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/util/AdapterViewUtil", DoNotGenerateAcw=true)]
	public partial class AdapterViewUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/util/AdapterViewUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdapterViewUtil); }
		}

		protected AdapterViewUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getPositionForView_Landroid_widget_AbsListView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AdapterViewUtil']/method[@name='getPositionForView' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='android.view.View']]"
		[Register ("getPositionForView", "(Landroid/widget/AbsListView;Landroid/view/View;)I", "")]
		public static unsafe int GetPositionForView (global::Android.Widget.AbsListView p0, global::Android.Views.View p1)
		{
			if (id_getPositionForView_Landroid_widget_AbsListView_Landroid_view_View_ == IntPtr.Zero)
				id_getPositionForView_Landroid_widget_AbsListView_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getPositionForView", "(Landroid/widget/AbsListView;Landroid/view/View;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getPositionForView_Landroid_widget_AbsListView_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPositionForView_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AdapterViewUtil']/method[@name='getPositionForView' and count(parameter)=2 and parameter[1][@type='com.nhaarman.listviewanimations.util.ListViewWrapper'] and parameter[2][@type='android.view.View']]"
		[Register ("getPositionForView", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Landroid/view/View;)I", "")]
		public static unsafe int GetPositionForView (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0, global::Android.Views.View p1)
		{
			if (id_getPositionForView_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Landroid_view_View_ == IntPtr.Zero)
				id_getPositionForView_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getPositionForView", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Landroid/view/View;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getPositionForView_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getViewForPosition_Landroid_widget_AbsListView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AdapterViewUtil']/method[@name='getViewForPosition' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int']]"
		[Register ("getViewForPosition", "(Landroid/widget/AbsListView;I)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View GetViewForPosition (global::Android.Widget.AbsListView p0, int p1)
		{
			if (id_getViewForPosition_Landroid_widget_AbsListView_I == IntPtr.Zero)
				id_getViewForPosition_Landroid_widget_AbsListView_I = JNIEnv.GetStaticMethodID (class_ref, "getViewForPosition", "(Landroid/widget/AbsListView;I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getViewForPosition_Landroid_widget_AbsListView_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getViewForPosition_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AdapterViewUtil']/method[@name='getViewForPosition' and count(parameter)=2 and parameter[1][@type='com.nhaarman.listviewanimations.util.ListViewWrapper'] and parameter[2][@type='int']]"
		[Register ("getViewForPosition", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;I)Landroid/view/View;", "")]
		public static unsafe global::Android.Views.View GetViewForPosition (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0, int p1)
		{
			if (id_getViewForPosition_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_I == IntPtr.Zero)
				id_getViewForPosition_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_I = JNIEnv.GetStaticMethodID (class_ref, "getViewForPosition", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getViewForPosition_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
