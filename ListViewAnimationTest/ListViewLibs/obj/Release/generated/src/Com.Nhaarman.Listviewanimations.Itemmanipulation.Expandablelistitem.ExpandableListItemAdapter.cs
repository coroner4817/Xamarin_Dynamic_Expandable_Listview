using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter", DoNotGenerateAcw=true)]
	public abstract partial class ExpandableListItemAdapter : global::Com.Nhaarman.Listviewanimations.ArrayAdapter, global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapperSetter {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter.ExpandCollapseHelper']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$ExpandCollapseHelper", DoNotGenerateAcw=true)]
		public partial class ExpandCollapseHelper : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$ExpandCollapseHelper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExpandCollapseHelper); }
			}

			protected ExpandCollapseHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_animateCollapsing_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter.ExpandCollapseHelper']/method[@name='animateCollapsing' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("animateCollapsing", "(Landroid/view/View;)V", "")]
			public static unsafe void AnimateCollapsing (global::Android.Views.View p0)
			{
				if (id_animateCollapsing_Landroid_view_View_ == IntPtr.Zero)
					id_animateCollapsing_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "animateCollapsing", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_animateCollapsing_Landroid_view_View_, __args);
				} finally {
				}
			}

			static IntPtr id_animateExpanding_Landroid_view_View_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter.ExpandCollapseHelper']/method[@name='animateExpanding' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.nhaarman.listviewanimations.util.ListViewWrapper']]"
			[Register ("animateExpanding", "(Landroid/view/View;Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", "")]
			public static unsafe void AnimateExpanding (global::Android.Views.View p0, global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p1)
			{
				if (id_animateExpanding_Landroid_view_View_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ == IntPtr.Zero)
					id_animateExpanding_Landroid_view_View_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ = JNIEnv.GetStaticMethodID (class_ref, "animateExpanding", "(Landroid/view/View;Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_animateExpanding_Landroid_view_View_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_, __args);
				} finally {
				}
			}

			static IntPtr id_createHeightAnimator_Landroid_view_View_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter.ExpandCollapseHelper']/method[@name='createHeightAnimator' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("createHeightAnimator", "(Landroid/view/View;II)Lcom/nineoldandroids/animation/ValueAnimator;", "")]
			public static unsafe global::Com.Nineoldandroids.Animation.ValueAnimator CreateHeightAnimator (global::Android.Views.View p0, int p1, int p2)
			{
				if (id_createHeightAnimator_Landroid_view_View_II == IntPtr.Zero)
					id_createHeightAnimator_Landroid_view_View_II = JNIEnv.GetStaticMethodID (class_ref, "createHeightAnimator", "(Landroid/view/View;II)Lcom/nineoldandroids/animation/ValueAnimator;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					global::Com.Nineoldandroids.Animation.ValueAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createHeightAnimator_Landroid_view_View_II, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/interface[@name='ExpandableListItemAdapter.ExpandCollapseListener']"
		[Register ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$ExpandCollapseListener", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter/IExpandCollapseListenerInvoker")]
		public partial interface IExpandCollapseListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/interface[@name='ExpandableListItemAdapter.ExpandCollapseListener']/method[@name='onItemCollapsed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onItemCollapsed", "(I)V", "GetOnItemCollapsed_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter/IExpandCollapseListenerInvoker, ListViewLibs")]
			void OnItemCollapsed (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/interface[@name='ExpandableListItemAdapter.ExpandCollapseListener']/method[@name='onItemExpanded' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onItemExpanded", "(I)V", "GetOnItemExpanded_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter/IExpandCollapseListenerInvoker, ListViewLibs")]
			void OnItemExpanded (int p0);

		}

		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$ExpandCollapseListener", DoNotGenerateAcw=true)]
		internal class IExpandCollapseListenerInvoker : global::Java.Lang.Object, IExpandCollapseListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$ExpandCollapseListener");
			IntPtr class_ref;

			public static IExpandCollapseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IExpandCollapseListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem.ExpandableListItemAdapter.ExpandCollapseListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IExpandCollapseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IExpandCollapseListenerInvoker); }
			}

			static Delegate cb_onItemCollapsed_I;
#pragma warning disable 0169
			static Delegate GetOnItemCollapsed_IHandler ()
			{
				if (cb_onItemCollapsed_I == null)
					cb_onItemCollapsed_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnItemCollapsed_I);
				return cb_onItemCollapsed_I;
			}

			static void n_OnItemCollapsed_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnItemCollapsed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onItemCollapsed_I;
			public unsafe void OnItemCollapsed (int p0)
			{
				if (id_onItemCollapsed_I == IntPtr.Zero)
					id_onItemCollapsed_I = JNIEnv.GetMethodID (class_ref, "onItemCollapsed", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onItemCollapsed_I, __args);
			}

			static Delegate cb_onItemExpanded_I;
#pragma warning disable 0169
			static Delegate GetOnItemExpanded_IHandler ()
			{
				if (cb_onItemExpanded_I == null)
					cb_onItemExpanded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnItemExpanded_I);
				return cb_onItemExpanded_I;
			}

			static void n_OnItemExpanded_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnItemExpanded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onItemExpanded_I;
			public unsafe void OnItemExpanded (int p0)
			{
				if (id_onItemExpanded_I == IntPtr.Zero)
					id_onItemExpanded_I = JNIEnv.GetMethodID (class_ref, "onItemExpanded", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onItemExpanded_I, __args);
			}

		}

		public partial class ItemCollapsedEventArgs : global::System.EventArgs {

			public ItemCollapsedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		public partial class ItemExpandedEventArgs : global::System.EventArgs {

			public ItemExpandedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter_ExpandCollapseListenerImplementor")]
		internal sealed partial class IExpandCollapseListenerImplementor : global::Java.Lang.Object, IExpandCollapseListener {

			object sender;

			public IExpandCollapseListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter_ExpandCollapseListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ItemCollapsedEventArgs> OnItemCollapsedHandler;
#pragma warning restore 0649

			public void OnItemCollapsed (int p0)
			{
				var __h = OnItemCollapsedHandler;
				if (__h != null)
					__h (sender, new ItemCollapsedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ItemExpandedEventArgs> OnItemExpandedHandler;
#pragma warning restore 0649

			public void OnItemExpanded (int p0)
			{
				var __h = OnItemExpandedHandler;
				if (__h != null)
					__h (sender, new ItemExpandedEventArgs (p0));
			}

			internal static bool __IsEmpty (IExpandCollapseListenerImplementor value)
			{
				return value.OnItemCollapsedHandler == null && value.OnItemExpandedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter.RootView']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$RootView", DoNotGenerateAcw=true)]
		public partial class RootView : global::Android.Widget.LinearLayout {

			protected RootView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter.TitleViewOnClickListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$TitleViewOnClickListener", DoNotGenerateAcw=true)]
		public partial class TitleViewOnClickListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$TitleViewOnClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TitleViewOnClickListener); }
			}

			protected TitleViewOnClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.TitleViewOnClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.TitleViewOnClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onClick_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter.TitleViewOnClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter.ViewHolder']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$ViewHolder", DoNotGenerateAcw=true)]
		public partial class ViewHolder : global::Java.Lang.Object {

			protected ViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExpandableListItemAdapter); }
		}

		protected ExpandableListItemAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_IIILjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/constructor[@name='ExpandableListItemAdapter' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.List&lt;T&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;IIILjava/util/List;)V", "")]
		protected unsafe ExpandableListItemAdapter (global::Android.Content.Context p0, int p1, int p2, int p3, global::System.Collections.IList p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = global::Android.Runtime.JavaList.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (GetType () != typeof (ExpandableListItemAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;IIILjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;IIILjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_IIILjava_util_List_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_IIILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;IIILjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_IIILjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_IIILjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/constructor[@name='ExpandableListItemAdapter' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;III)V", "")]
		protected unsafe ExpandableListItemAdapter (global::Android.Content.Context p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (ExpandableListItemAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;III)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_III == IntPtr.Zero)
					id_ctor_Landroid_content_Context_III = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_III, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/constructor[@name='ExpandableListItemAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;T&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;)V", "")]
		protected unsafe ExpandableListItemAdapter (global::Android.Content.Context p0, global::System.Collections.IList p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (ExpandableListItemAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/constructor[@name='ExpandableListItemAdapter' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		protected unsafe ExpandableListItemAdapter (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ExpandableListItemAdapter)) {
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

		static Delegate cb_collapse_I;
#pragma warning disable 0169
		static Delegate GetCollapse_IHandler ()
		{
			if (cb_collapse_I == null)
				cb_collapse_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Collapse_I);
			return cb_collapse_I;
		}

		static void n_Collapse_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Collapse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_collapse_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='collapse' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("collapse", "(I)V", "GetCollapse_IHandler")]
		public virtual unsafe void Collapse (int p0)
		{
			if (id_collapse_I == IntPtr.Zero)
				id_collapse_I = JNIEnv.GetMethodID (class_ref, "collapse", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_collapse_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collapse", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_expand_I;
#pragma warning disable 0169
		static Delegate GetExpand_IHandler ()
		{
			if (cb_expand_I == null)
				cb_expand_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Expand_I);
			return cb_expand_I;
		}

		static void n_Expand_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Expand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_expand_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='expand' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("expand", "(I)V", "GetExpand_IHandler")]
		public virtual unsafe void Expand (int p0)
		{
			if (id_expand_I == IntPtr.Zero)
				id_expand_I = JNIEnv.GetMethodID (class_ref, "expand", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_expand_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "expand", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getContentView_I;
#pragma warning disable 0169
		static Delegate GetGetContentView_IHandler ()
		{
			if (cb_getContentView_I == null)
				cb_getContentView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetContentView_I);
			return cb_getContentView_I;
		}

		static IntPtr n_GetContentView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetContentView (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getContentView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='getContentView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getContentView", "(I)Landroid/view/View;", "GetGetContentView_IHandler")]
		public virtual unsafe global::Android.Views.View GetContentView (int p0)
		{
			if (id_getContentView_I == IntPtr.Zero)
				id_getContentView_I = JNIEnv.GetMethodID (class_ref, "getContentView", "(I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getContentView_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentView", "(I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getContentView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetContentView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getContentView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getContentView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetContentView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getContentView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetContentView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetContentView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='getContentView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getContentView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetContentView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public abstract global::Android.Views.View GetContentView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2);

		static Delegate cb_getTitleView_I;
#pragma warning disable 0169
		static Delegate GetGetTitleView_IHandler ()
		{
			if (cb_getTitleView_I == null)
				cb_getTitleView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTitleView_I);
			return cb_getTitleView_I;
		}

		static IntPtr n_GetTitleView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTitleView (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getTitleView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='getTitleView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTitleView", "(I)Landroid/view/View;", "GetGetTitleView_IHandler")]
		public virtual unsafe global::Android.Views.View GetTitleView (int p0)
		{
			if (id_getTitleView_I == IntPtr.Zero)
				id_getTitleView_I = JNIEnv.GetMethodID (class_ref, "getTitleView", "(I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getTitleView_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitleView", "(I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTitleView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetTitleView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getTitleView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getTitleView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetTitleView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getTitleView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetTitleView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTitleView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='getTitleView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getTitleView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetTitleView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public abstract global::Android.Views.View GetTitleView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2);

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isExpanded_I;
#pragma warning disable 0169
		static Delegate GetIsExpanded_IHandler ()
		{
			if (cb_isExpanded_I == null)
				cb_isExpanded_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsExpanded_I);
			return cb_isExpanded_I;
		}

		static bool n_IsExpanded_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpanded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isExpanded_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='isExpanded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isExpanded", "(I)Z", "GetIsExpanded_IHandler")]
		public virtual unsafe bool IsExpanded (int p0)
		{
			if (id_isExpanded_I == IntPtr.Zero)
				id_isExpanded_I = JNIEnv.GetMethodID (class_ref, "isExpanded", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isExpanded_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExpanded", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setActionViewResId_I;
#pragma warning disable 0169
		static Delegate GetSetActionViewResId_IHandler ()
		{
			if (cb_setActionViewResId_I == null)
				cb_setActionViewResId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetActionViewResId_I);
			return cb_setActionViewResId_I;
		}

		static void n_SetActionViewResId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetActionViewResId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActionViewResId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='setActionViewResId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setActionViewResId", "(I)V", "GetSetActionViewResId_IHandler")]
		public virtual unsafe void SetActionViewResId (int p0)
		{
			if (id_setActionViewResId_I == IntPtr.Zero)
				id_setActionViewResId_I = JNIEnv.GetMethodID (class_ref, "setActionViewResId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setActionViewResId_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionViewResId", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_;
#pragma warning disable 0169
		static Delegate GetSetExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_Handler ()
		{
			if (cb_setExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_ == null)
				cb_setExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_);
			return cb_setExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_;
		}

		static void n_SetExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExpandCollapseListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='setExpandCollapseListener' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem.ExpandableListItemAdapter.ExpandCollapseListener']]"
		[Register ("setExpandCollapseListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$ExpandCollapseListener;)V", "GetSetExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_Handler")]
		public virtual unsafe void SetExpandCollapseListener (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener p0)
		{
			if (id_setExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_ == IntPtr.Zero)
				id_setExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_ = JNIEnv.GetMethodID (class_ref, "setExpandCollapseListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$ExpandCollapseListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExpandCollapseListener_Lcom_nhaarman_listviewanimations_itemmanipulation_expandablelistitem_ExpandableListItemAdapter_ExpandCollapseListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpandCollapseListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter$ExpandCollapseListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLimit_I;
#pragma warning disable 0169
		static Delegate GetSetLimit_IHandler ()
		{
			if (cb_setLimit_I == null)
				cb_setLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLimit_I);
			return cb_setLimit_I;
		}

		static void n_SetLimit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLimit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='setLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLimit", "(I)V", "GetSetLimit_IHandler")]
		public virtual unsafe void SetLimit (int p0)
		{
			if (id_setLimit_I == IntPtr.Zero)
				id_setLimit_I = JNIEnv.GetMethodID (class_ref, "setLimit", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLimit_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLimit", "(I)V"), __args);
			} finally {
			}
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0 = (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListViewWrapper (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='setListViewWrapper' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.util.ListViewWrapper']]"
		[Register ("setListViewWrapper", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", "GetSetListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Handler")]
		public virtual unsafe void SetListViewWrapper (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0)
		{
			if (id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ == IntPtr.Zero)
				id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ = JNIEnv.GetMethodID (class_ref, "setListViewWrapper", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListViewWrapper", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toggle_I;
#pragma warning disable 0169
		static Delegate GetToggle_IHandler ()
		{
			if (cb_toggle_I == null)
				cb_toggle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Toggle_I);
			return cb_toggle_I;
		}

		static void n_Toggle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Toggle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toggle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='toggle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toggle", "(I)V", "GetToggle_IHandler")]
		public virtual unsafe void Toggle (int p0)
		{
			if (id_toggle_I == IntPtr.Zero)
				id_toggle_I = JNIEnv.GetMethodID (class_ref, "toggle", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_toggle_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggle", "(I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener"
		public event EventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.ItemCollapsedEventArgs> ItemCollapsed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListenerImplementor>(
						ref weak_implementor_SetExpandCollapseListener,
						__CreateIExpandCollapseListenerImplementor,
						SetExpandCollapseListener,
						__h => __h.OnItemCollapsedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListenerImplementor>(
						ref weak_implementor_SetExpandCollapseListener,
						global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListenerImplementor.__IsEmpty,
						__v => SetExpandCollapseListener (null),
						__h => __h.OnItemCollapsedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.ItemExpandedEventArgs> ItemExpanded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListenerImplementor>(
						ref weak_implementor_SetExpandCollapseListener,
						__CreateIExpandCollapseListenerImplementor,
						SetExpandCollapseListener,
						__h => __h.OnItemExpandedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListener, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListenerImplementor>(
						ref weak_implementor_SetExpandCollapseListener,
						global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListenerImplementor.__IsEmpty,
						__v => SetExpandCollapseListener (null),
						__h => __h.OnItemExpandedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetExpandCollapseListener;

		global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListenerImplementor __CreateIExpandCollapseListenerImplementor ()
		{
			return new global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Expandablelistitem.ExpandableListItemAdapter.IExpandCollapseListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/expandablelistitem/ExpandableListItemAdapter", DoNotGenerateAcw=true)]
	internal partial class ExpandableListItemAdapterInvoker : ExpandableListItemAdapter {

		public ExpandableListItemAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExpandableListItemAdapterInvoker); }
		}

		static IntPtr id_getContentView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='getContentView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getContentView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetContentView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetContentView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getContentView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getContentView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getContentView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getContentView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTitleView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.expandablelistitem']/class[@name='ExpandableListItemAdapter']/method[@name='getTitleView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getTitleView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetTitleView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetTitleView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getTitleView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getTitleView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getTitleView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getTitleView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
