using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/DynamicListView", DoNotGenerateAcw=true)]
	public partial class DynamicListView : global::Android.Widget.ListView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView.MyOnScrollListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/DynamicListView$MyOnScrollListener", DoNotGenerateAcw=true)]
		public partial class MyOnScrollListener : global::Java.Lang.Object, global::Android.Widget.AbsListView.IOnScrollListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/DynamicListView$MyOnScrollListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyOnScrollListener); }
			}

			protected MyOnScrollListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_addOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_;
#pragma warning disable 0169
			static Delegate GetAddOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_Handler ()
			{
				if (cb_addOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ == null)
					cb_addOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_);
				return cb_addOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_;
			}

			static void n_AddOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView.MyOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView.MyOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AbsListView.IOnScrollListener p0 = (global::Android.Widget.AbsListView.IOnScrollListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView.IOnScrollListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AddOnScrollListener (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView.MyOnScrollListener']/method[@name='addOnScrollListener' and count(parameter)=1 and parameter[1][@type='android.widget.AbsListView.OnScrollListener']]"
			[Register ("addOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V", "GetAddOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_Handler")]
			public virtual unsafe void AddOnScrollListener (global::Android.Widget.AbsListView.IOnScrollListener p0)
			{
				if (id_addOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ == IntPtr.Zero)
					id_addOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_ = JNIEnv.GetMethodID (class_ref, "addOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_addOnScrollListener_Landroid_widget_AbsListView_OnScrollListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onScroll_Landroid_widget_AbsListView_III;
#pragma warning disable 0169
			static Delegate GetOnScroll_Landroid_widget_AbsListView_IIIHandler ()
			{
				if (cb_onScroll_Landroid_widget_AbsListView_III == null)
					cb_onScroll_Landroid_widget_AbsListView_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnScroll_Landroid_widget_AbsListView_III);
				return cb_onScroll_Landroid_widget_AbsListView_III;
			}

			static void n_OnScroll_Landroid_widget_AbsListView_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView.MyOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView.MyOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnScroll (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onScroll_Landroid_widget_AbsListView_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView.MyOnScrollListener']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onScroll", "(Landroid/widget/AbsListView;III)V", "GetOnScroll_Landroid_widget_AbsListView_IIIHandler")]
			public virtual unsafe void OnScroll (global::Android.Widget.AbsListView p0, int p1, int p2, int p3)
			{
				if (id_onScroll_Landroid_widget_AbsListView_III == IntPtr.Zero)
					id_onScroll_Landroid_widget_AbsListView_III = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/widget/AbsListView;III)V");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onScroll_Landroid_widget_AbsListView_III, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/widget/AbsListView;III)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
#pragma warning disable 0169
			static Delegate GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler ()
			{
				if (cb_onScrollStateChanged_Landroid_widget_AbsListView_I == null)
					cb_onScrollStateChanged_Landroid_widget_AbsListView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnScrollStateChanged_Landroid_widget_AbsListView_I);
				return cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
			}

			static void n_OnScrollStateChanged_Landroid_widget_AbsListView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView.MyOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView.MyOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.ScrollState p1 = (global::Android.Widget.ScrollState) native_p1;
				__this.OnScrollStateChanged (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onScrollStateChanged_Landroid_widget_AbsListView_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView.MyOnScrollListener']/method[@name='onScrollStateChanged' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int']]"
			[Register ("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", "GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler")]
			public virtual unsafe void OnScrollStateChanged (global::Android.Widget.AbsListView p0, [global::Android.Runtime.GeneratedEnum] global::Android.Widget.ScrollState p1)
			{
				if (id_onScrollStateChanged_Landroid_widget_AbsListView_I == IntPtr.Zero)
					id_onScrollStateChanged_Landroid_widget_AbsListView_I = JNIEnv.GetMethodID (class_ref, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onScrollStateChanged_Landroid_widget_AbsListView_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/DynamicListView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DynamicListView); }
		}

		protected DynamicListView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/constructor[@name='DynamicListView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe DynamicListView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DynamicListView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/constructor[@name='DynamicListView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe DynamicListView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DynamicListView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/constructor[@name='DynamicListView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DynamicListView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DynamicListView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeVerticalScrollExtent ();
		}
#pragma warning restore 0169

		static IntPtr id_computeVerticalScrollExtent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='computeVerticalScrollExtent' and count(parameter)=0]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeVerticalScrollOffset ();
		}
#pragma warning restore 0169

		static IntPtr id_computeVerticalScrollOffset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='computeVerticalScrollOffset' and count(parameter)=0]"
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeVerticalScrollRange ();
		}
#pragma warning restore 0169

		static IntPtr id_computeVerticalScrollRange;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='computeVerticalScrollRange' and count(parameter)=0]"
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

		static Delegate cb_disableDragAndDrop;
#pragma warning disable 0169
		static Delegate GetDisableDragAndDropHandler ()
		{
			if (cb_disableDragAndDrop == null)
				cb_disableDragAndDrop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableDragAndDrop);
			return cb_disableDragAndDrop;
		}

		static void n_DisableDragAndDrop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableDragAndDrop ();
		}
#pragma warning restore 0169

		static IntPtr id_disableDragAndDrop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='disableDragAndDrop' and count(parameter)=0]"
		[Register ("disableDragAndDrop", "()V", "GetDisableDragAndDropHandler")]
		public virtual unsafe void DisableDragAndDrop ()
		{
			if (id_disableDragAndDrop == IntPtr.Zero)
				id_disableDragAndDrop = JNIEnv.GetMethodID (class_ref, "disableDragAndDrop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disableDragAndDrop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableDragAndDrop", "()V"));
			} finally {
			}
		}

		static Delegate cb_disableSwipeToDismiss;
#pragma warning disable 0169
		static Delegate GetDisableSwipeToDismissHandler ()
		{
			if (cb_disableSwipeToDismiss == null)
				cb_disableSwipeToDismiss = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableSwipeToDismiss);
			return cb_disableSwipeToDismiss;
		}

		static void n_DisableSwipeToDismiss (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableSwipeToDismiss ();
		}
#pragma warning restore 0169

		static IntPtr id_disableSwipeToDismiss;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='disableSwipeToDismiss' and count(parameter)=0]"
		[Register ("disableSwipeToDismiss", "()V", "GetDisableSwipeToDismissHandler")]
		public virtual unsafe void DisableSwipeToDismiss ()
		{
			if (id_disableSwipeToDismiss == IntPtr.Zero)
				id_disableSwipeToDismiss = JNIEnv.GetMethodID (class_ref, "disableSwipeToDismiss", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disableSwipeToDismiss);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableSwipeToDismiss", "()V"));
			} finally {
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dismiss_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='dismiss' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_enableDragAndDrop;
#pragma warning disable 0169
		static Delegate GetEnableDragAndDropHandler ()
		{
			if (cb_enableDragAndDrop == null)
				cb_enableDragAndDrop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableDragAndDrop);
			return cb_enableDragAndDrop;
		}

		static void n_EnableDragAndDrop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableDragAndDrop ();
		}
#pragma warning restore 0169

		static IntPtr id_enableDragAndDrop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='enableDragAndDrop' and count(parameter)=0]"
		[Register ("enableDragAndDrop", "()V", "GetEnableDragAndDropHandler")]
		public virtual unsafe void EnableDragAndDrop ()
		{
			if (id_enableDragAndDrop == IntPtr.Zero)
				id_enableDragAndDrop = JNIEnv.GetMethodID (class_ref, "enableDragAndDrop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableDragAndDrop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableDragAndDrop", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableSimpleSwipeUndo;
#pragma warning disable 0169
		static Delegate GetEnableSimpleSwipeUndoHandler ()
		{
			if (cb_enableSimpleSwipeUndo == null)
				cb_enableSimpleSwipeUndo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableSimpleSwipeUndo);
			return cb_enableSimpleSwipeUndo;
		}

		static void n_EnableSimpleSwipeUndo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableSimpleSwipeUndo ();
		}
#pragma warning restore 0169

		static IntPtr id_enableSimpleSwipeUndo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='enableSimpleSwipeUndo' and count(parameter)=0]"
		[Register ("enableSimpleSwipeUndo", "()V", "GetEnableSimpleSwipeUndoHandler")]
		public virtual unsafe void EnableSimpleSwipeUndo ()
		{
			if (id_enableSimpleSwipeUndo == IntPtr.Zero)
				id_enableSimpleSwipeUndo = JNIEnv.GetMethodID (class_ref, "enableSimpleSwipeUndo", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableSimpleSwipeUndo);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableSimpleSwipeUndo", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_;
#pragma warning disable 0169
		static Delegate GetEnableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_Handler ()
		{
			if (cb_enableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ == null)
				cb_enableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EnableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_);
			return cb_enableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_;
		}

		static void n_EnableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IOnDismissCallback p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IOnDismissCallback)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IOnDismissCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnableSwipeToDismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='enableSwipeToDismiss' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.OnDismissCallback']]"
		[Register ("enableSwipeToDismiss", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", "GetEnableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_Handler")]
		public virtual unsafe void EnableSwipeToDismiss (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IOnDismissCallback p0)
		{
			if (id_enableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ == IntPtr.Zero)
				id_enableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ = JNIEnv.GetMethodID (class_ref, "enableSwipeToDismiss", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableSwipeToDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableSwipeToDismiss", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_enableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_;
#pragma warning disable 0169
		static Delegate GetEnableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_Handler ()
		{
			if (cb_enableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ == null)
				cb_enableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EnableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_);
			return cb_enableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_;
		}

		static void n_EnableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnableSwipeUndo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='enableSwipeUndo' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo.UndoCallback']]"
		[Register ("enableSwipeUndo", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V", "GetEnableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_Handler")]
		public virtual unsafe void EnableSwipeUndo (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.IUndoCallback p0)
		{
			if (id_enableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ == IntPtr.Zero)
				id_enableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_ = JNIEnv.GetMethodID (class_ref, "enableSwipeUndo", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableSwipeUndo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_undo_UndoCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableSwipeUndo", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/UndoCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fling_I;
#pragma warning disable 0169
		static Delegate GetFling_IHandler ()
		{
			if (cb_fling_I == null)
				cb_fling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Fling_I);
			return cb_fling_I;
		}

		static void n_Fling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Fling (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='fling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fling", "(I)V", "GetFling_IHandler")]
		public virtual unsafe void Fling (int p0)
		{
			if (id_fling_I == IntPtr.Zero)
				id_fling_I = JNIEnv.GetMethodID (class_ref, "fling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fling_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fling", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_insert_arrayLandroid_util_Pair_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLandroid_util_Pair_Handler ()
		{
			if (cb_insert_arrayLandroid_util_Pair_ == null)
				cb_insert_arrayLandroid_util_Pair_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Insert_arrayLandroid_util_Pair_);
			return cb_insert_arrayLandroid_util_Pair_;
		}

		static void n_Insert_arrayLandroid_util_Pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.Pair[] p0 = (global::Android.Util.Pair[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Util.Pair));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_insert_arrayLandroid_util_Pair_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='android.util.Pair&lt;java.lang.Integer, T&gt;...']]"
		[Register ("insert", "([Landroid/util/Pair;)V", "GetInsert_arrayLandroid_util_Pair_Handler")]
		public virtual unsafe void Insert (params global:: Android.Util.Pair[] p0)
		{
			if (id_insert_arrayLandroid_util_Pair_ == IntPtr.Zero)
				id_insert_arrayLandroid_util_Pair_ = JNIEnv.GetMethodID (class_ref, "insert", "([Landroid/util/Pair;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_arrayLandroid_util_Pair_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "([Landroid/util/Pair;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_insert_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInsert_ILjava_lang_Object_Handler ()
		{
			if (cb_insert_ILjava_lang_Object_ == null)
				cb_insert_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Insert_ILjava_lang_Object_);
			return cb_insert_ILjava_lang_Object_;
		}

		static void n_Insert_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_insert_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("insert", "(ILjava/lang/Object;)V", "GetInsert_ILjava_lang_Object_Handler")]
		public virtual unsafe void Insert (int p0, global::Java.Lang.Object p1)
		{
			if (id_insert_ILjava_lang_Object_ == IntPtr.Zero)
				id_insert_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "insert", "(ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(ILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_insert_IarrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInsert_IarrayLjava_lang_Object_Handler ()
		{
			if (cb_insert_IarrayLjava_lang_Object_ == null)
				cb_insert_IarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Insert_IarrayLjava_lang_Object_);
			return cb_insert_IarrayLjava_lang_Object_;
		}

		static void n_Insert_IarrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Insert (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_insert_IarrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("insert", "(I[Ljava/lang/Object;)V", "GetInsert_IarrayLjava_lang_Object_Handler")]
		public virtual unsafe void Insert (int p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_insert_IarrayLjava_lang_Object_ == IntPtr.Zero)
				id_insert_IarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "insert", "(I[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_IarrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(I[Ljava/lang/Object;)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_insert_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetInsert_Ljava_lang_Iterable_Handler ()
		{
			if (cb_insert_Ljava_lang_Iterable_ == null)
				cb_insert_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Insert_Ljava_lang_Iterable_);
			return cb_insert_Ljava_lang_Iterable_;
		}

		static void n_Insert_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p0 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_insert_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;android.util.Pair&lt;java.lang.Integer, T&gt;&gt;']]"
		[Register ("insert", "(Ljava/lang/Iterable;)V", "GetInsert_Ljava_lang_Iterable_Handler")]
		public virtual unsafe void Insert (global::Java.Lang.IIterable p0)
		{
			if (id_insert_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_insert_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "insert", "(Ljava/lang/Iterable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_Ljava_lang_Iterable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Ljava/lang/Iterable;)V"), __args);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDismissableManager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='setDismissableManager' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.DismissableManager']]"
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

		static Delegate cb_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_;
#pragma warning disable 0169
		static Delegate GetSetDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_Handler ()
		{
			if (cb_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ == null)
				cb_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_);
			return cb_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_;
		}

		static void n_SetDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDraggableManager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='setDraggableManager' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.dragdrop.DraggableManager']]"
		[Register ("setDraggableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/DraggableManager;)V", "GetSetDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_Handler")]
		public virtual unsafe void SetDraggableManager (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager p0)
		{
			if (id_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ == IntPtr.Zero)
				id_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ = JNIEnv.GetMethodID (class_ref, "setDraggableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/DraggableManager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDraggableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/DraggableManager;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMinimumAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetMinimumAlpha_FHandler ()
		{
			if (cb_setMinimumAlpha_F == null)
				cb_setMinimumAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinimumAlpha_F);
			return cb_setMinimumAlpha_F;
		}

		static void n_SetMinimumAlpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinimumAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMinimumAlpha_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='setMinimumAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMinimumAlpha", "(F)V", "GetSetMinimumAlpha_FHandler")]
		public virtual unsafe void SetMinimumAlpha (float p0)
		{
			if (id_setMinimumAlpha_F == IntPtr.Zero)
				id_setMinimumAlpha_F = JNIEnv.GetMethodID (class_ref, "setMinimumAlpha", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMinimumAlpha_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinimumAlpha", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_Handler ()
		{
			if (cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ == null)
				cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_);
			return cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_;
		}

		static void n_SetOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemMovedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='setOnItemMovedListener' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.dragdrop.OnItemMovedListener']]"
		[Register ("setOnItemMovedListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListener;)V", "GetSetOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_Handler")]
		public virtual unsafe void SetOnItemMovedListener (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener p0)
		{
			if (id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ == IntPtr.Zero)
				id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemMovedListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemMovedListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScrollSpeed_F;
#pragma warning disable 0169
		static Delegate GetSetScrollSpeed_FHandler ()
		{
			if (cb_setScrollSpeed_F == null)
				cb_setScrollSpeed_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScrollSpeed_F);
			return cb_setScrollSpeed_F;
		}

		static void n_SetScrollSpeed_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrollSpeed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScrollSpeed_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='setScrollSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setScrollSpeed", "(F)V", "GetSetScrollSpeed_FHandler")]
		public virtual unsafe void SetScrollSpeed (float p0)
		{
			if (id_setScrollSpeed_F == IntPtr.Zero)
				id_setScrollSpeed_F = JNIEnv.GetMethodID (class_ref, "setScrollSpeed", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScrollSpeed_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrollSpeed", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSwipeTouchChild_I;
#pragma warning disable 0169
		static Delegate GetSetSwipeTouchChild_IHandler ()
		{
			if (cb_setSwipeTouchChild_I == null)
				cb_setSwipeTouchChild_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSwipeTouchChild_I);
			return cb_setSwipeTouchChild_I;
		}

		static void n_SetSwipeTouchChild_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSwipeTouchChild (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSwipeTouchChild_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='setSwipeTouchChild' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSwipeTouchChild", "(I)V", "GetSetSwipeTouchChild_IHandler")]
		public virtual unsafe void SetSwipeTouchChild (int p0)
		{
			if (id_setSwipeTouchChild_I == IntPtr.Zero)
				id_setSwipeTouchChild_I = JNIEnv.GetMethodID (class_ref, "setSwipeTouchChild", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSwipeTouchChild_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSwipeTouchChild", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startDragging_I;
#pragma warning disable 0169
		static Delegate GetStartDragging_IHandler ()
		{
			if (cb_startDragging_I == null)
				cb_startDragging_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_StartDragging_I);
			return cb_startDragging_I;
		}

		static void n_StartDragging_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDragging (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startDragging_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='startDragging' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("startDragging", "(I)V", "GetStartDragging_IHandler")]
		public virtual unsafe void StartDragging (int p0)
		{
			if (id_startDragging_I == IntPtr.Zero)
				id_startDragging_I = JNIEnv.GetMethodID (class_ref, "startDragging", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startDragging_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDragging", "(I)V"), __args);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Undo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_undo_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='DynamicListView']/method[@name='undo' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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

#region "Event implementation for Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener"
		public event EventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.ItemMovedEventArgs> ItemMoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor>(
						ref weak_implementor_SetOnItemMovedListener,
						__CreateIOnItemMovedListenerImplementor,
						SetOnItemMovedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor>(
						ref weak_implementor_SetOnItemMovedListener,
						global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor.__IsEmpty,
						__v => SetOnItemMovedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnItemMovedListener;

		global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor __CreateIOnItemMovedListenerImplementor ()
		{
			return new global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor (this);
		}
#endregion
	}
}
