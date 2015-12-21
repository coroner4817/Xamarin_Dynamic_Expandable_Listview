using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/BaseAdapterDecorator", DoNotGenerateAcw=true)]
	public abstract partial class BaseAdapterDecorator : global::Android.Widget.BaseAdapter, global::Android.Widget.ISectionIndexer, global::Com.Nhaarman.Listviewanimations.Util.IInsertable, global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapperSetter, global::Com.Nhaarman.Listviewanimations.Util.ISwappable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/BaseAdapterDecorator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseAdapterDecorator); }
		}

		protected BaseAdapterDecorator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/constructor[@name='BaseAdapterDecorator' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		protected unsafe BaseAdapterDecorator (global::Android.Widget.BaseAdapter p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseAdapterDecorator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_BaseAdapter_ == IntPtr.Zero)
					id_ctor_Landroid_widget_BaseAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_, __args);
			} finally {
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
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getCount' and count(parameter)=0]"
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

		static Delegate cb_getDecoratedBaseAdapter;
#pragma warning disable 0169
		static Delegate GetGetDecoratedBaseAdapterHandler ()
		{
			if (cb_getDecoratedBaseAdapter == null)
				cb_getDecoratedBaseAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecoratedBaseAdapter);
			return cb_getDecoratedBaseAdapter;
		}

		static IntPtr n_GetDecoratedBaseAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DecoratedBaseAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getDecoratedBaseAdapter;
		public virtual unsafe global::Android.Widget.BaseAdapter DecoratedBaseAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getDecoratedBaseAdapter' and count(parameter)=0]"
			[Register ("getDecoratedBaseAdapter", "()Landroid/widget/BaseAdapter;", "GetGetDecoratedBaseAdapterHandler")]
			get {
				if (id_getDecoratedBaseAdapter == IntPtr.Zero)
					id_getDecoratedBaseAdapter = JNIEnv.GetMethodID (class_ref, "getDecoratedBaseAdapter", "()Landroid/widget/BaseAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (JNIEnv.CallObjectMethod  (Handle, id_getDecoratedBaseAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecoratedBaseAdapter", "()Landroid/widget/BaseAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getListViewWrapper;
#pragma warning disable 0169
		static Delegate GetGetListViewWrapperHandler ()
		{
			if (cb_getListViewWrapper == null)
				cb_getListViewWrapper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListViewWrapper);
			return cb_getListViewWrapper;
		}

		static IntPtr n_GetListViewWrapper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListViewWrapper);
		}
#pragma warning restore 0169

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
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0 = (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ListViewWrapper = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getListViewWrapper;
		static IntPtr id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_;
		public virtual unsafe global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper ListViewWrapper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getListViewWrapper' and count(parameter)=0]"
			[Register ("getListViewWrapper", "()Lcom/nhaarman/listviewanimations/util/ListViewWrapper;", "GetGetListViewWrapperHandler")]
			get {
				if (id_getListViewWrapper == IntPtr.Zero)
					id_getListViewWrapper = JNIEnv.GetMethodID (class_ref, "getListViewWrapper", "()Lcom/nhaarman/listviewanimations/util/ListViewWrapper;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (JNIEnv.CallObjectMethod  (Handle, id_getListViewWrapper), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListViewWrapper", "()Lcom/nhaarman/listviewanimations/util/ListViewWrapper;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='setListViewWrapper' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.util.ListViewWrapper']]"
			[Register ("setListViewWrapper", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", "GetSetListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Handler")]
			set {
				if (id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ == IntPtr.Zero)
					id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ = JNIEnv.GetMethodID (class_ref, "setListViewWrapper", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setListViewWrapper_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListViewWrapper", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRootAdapter;
#pragma warning disable 0169
		static Delegate GetGetRootAdapterHandler ()
		{
			if (cb_getRootAdapter == null)
				cb_getRootAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRootAdapter);
			return cb_getRootAdapter;
		}

		static IntPtr n_GetRootAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RootAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getRootAdapter;
		protected virtual unsafe global::Android.Widget.BaseAdapter RootAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getRootAdapter' and count(parameter)=0]"
			[Register ("getRootAdapter", "()Landroid/widget/BaseAdapter;", "GetGetRootAdapterHandler")]
			get {
				if (id_getRootAdapter == IntPtr.Zero)
					id_getRootAdapter = JNIEnv.GetMethodID (class_ref, "getRootAdapter", "()Landroid/widget/BaseAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (JNIEnv.CallObjectMethod  (Handle, id_getRootAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRootAdapter", "()Landroid/widget/BaseAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_ILjava_lang_Object_Handler ()
		{
			if (cb_add_ILjava_lang_Object_ == null)
				cb_add_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Add_ILjava_lang_Object_);
			return cb_add_ILjava_lang_Object_;
		}

		static void n_Add_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("add", "(ILjava/lang/Object;)V", "GetAdd_ILjava_lang_Object_Handler")]
		public virtual unsafe void Add (int p0, global::Java.Lang.Object p1)
		{
			if (id_add_ILjava_lang_Object_ == IntPtr.Zero)
				id_add_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(ILjava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public override unsafe global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public override unsafe long GetItemId (int p0)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getItemId_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_getPositionForSection_I;
#pragma warning disable 0169
		static Delegate GetGetPositionForSection_IHandler ()
		{
			if (cb_getPositionForSection_I == null)
				cb_getPositionForSection_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPositionForSection_I);
			return cb_getPositionForSection_I;
		}

		static int n_GetPositionForSection_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPositionForSection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPositionForSection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getPositionForSection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPositionForSection", "(I)I", "GetGetPositionForSection_IHandler")]
		public virtual unsafe int GetPositionForSection (int p0)
		{
			if (id_getPositionForSection_I == IntPtr.Zero)
				id_getPositionForSection_I = JNIEnv.GetMethodID (class_ref, "getPositionForSection", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPositionForSection_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionForSection", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getSectionForPosition_I;
#pragma warning disable 0169
		static Delegate GetGetSectionForPosition_IHandler ()
		{
			if (cb_getSectionForPosition_I == null)
				cb_getSectionForPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetSectionForPosition_I);
			return cb_getSectionForPosition_I;
		}

		static int n_GetSectionForPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSectionForPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getSectionForPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getSectionForPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSectionForPosition", "(I)I", "GetGetSectionForPosition_IHandler")]
		public virtual unsafe int GetSectionForPosition (int p0)
		{
			if (id_getSectionForPosition_I == IntPtr.Zero)
				id_getSectionForPosition_I = JNIEnv.GetMethodID (class_ref, "getSectionForPosition", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSectionForPosition_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSectionForPosition", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getSections;
#pragma warning disable 0169
		static Delegate GetGetSectionsHandler ()
		{
			if (cb_getSections == null)
				cb_getSections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSections);
			return cb_getSections;
		}

		static IntPtr n_GetSections (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSections ());
		}
#pragma warning restore 0169

		static IntPtr id_getSections;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getSections' and count(parameter)=0]"
		[Register ("getSections", "()[Ljava/lang/Object;", "GetGetSectionsHandler")]
		public virtual unsafe global::Java.Lang.Object[] GetSections ()
		{
			if (id_getSections == IntPtr.Zero)
				id_getSections = JNIEnv.GetMethodID (class_ref, "getSections", "()[Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getSections), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
				else
					return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSections", "()[Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

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
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
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

		static Delegate cb_notifyDataSetChanged_Z;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChanged_ZHandler ()
		{
			if (cb_notifyDataSetChanged_Z == null)
				cb_notifyDataSetChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_NotifyDataSetChanged_Z);
			return cb_notifyDataSetChanged_Z;
		}

		static void n_NotifyDataSetChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='notifyDataSetChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("notifyDataSetChanged", "(Z)V", "GetNotifyDataSetChanged_ZHandler")]
		public virtual unsafe void NotifyDataSetChanged (bool p0)
		{
			if (id_notifyDataSetChanged_Z == IntPtr.Zero)
				id_notifyDataSetChanged_Z = JNIEnv.GetMethodID (class_ref, "notifyDataSetChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyDataSetChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDataSetChanged", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAbsListView_Landroid_widget_AbsListView_;
#pragma warning disable 0169
		static Delegate GetSetAbsListView_Landroid_widget_AbsListView_Handler ()
		{
			if (cb_setAbsListView_Landroid_widget_AbsListView_ == null)
				cb_setAbsListView_Landroid_widget_AbsListView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAbsListView_Landroid_widget_AbsListView_);
			return cb_setAbsListView_Landroid_widget_AbsListView_;
		}

		static void n_SetAbsListView_Landroid_widget_AbsListView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAbsListView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAbsListView_Landroid_widget_AbsListView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='setAbsListView' and count(parameter)=1 and parameter[1][@type='android.widget.AbsListView']]"
		[Register ("setAbsListView", "(Landroid/widget/AbsListView;)V", "GetSetAbsListView_Landroid_widget_AbsListView_Handler")]
		public virtual unsafe void SetAbsListView (global::Android.Widget.AbsListView p0)
		{
			if (id_setAbsListView_Landroid_widget_AbsListView_ == IntPtr.Zero)
				id_setAbsListView_Landroid_widget_AbsListView_ = JNIEnv.GetMethodID (class_ref, "setAbsListView", "(Landroid/widget/AbsListView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAbsListView_Landroid_widget_AbsListView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAbsListView", "(Landroid/widget/AbsListView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_swapItems_II;
#pragma warning disable 0169
		static Delegate GetSwapItems_IIHandler ()
		{
			if (cb_swapItems_II == null)
				cb_swapItems_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SwapItems_II);
			return cb_swapItems_II;
		}

		static void n_SwapItems_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwapItems (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_swapItems_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='swapItems' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("swapItems", "(II)V", "GetSwapItems_IIHandler")]
		public virtual unsafe void SwapItems (int p0, int p1)
		{
			if (id_swapItems_II == IntPtr.Zero)
				id_swapItems_II = JNIEnv.GetMethodID (class_ref, "swapItems", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_swapItems_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swapItems", "(II)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/BaseAdapterDecorator", DoNotGenerateAcw=true)]
	internal partial class BaseAdapterDecoratorInvoker : BaseAdapterDecorator, global::Com.Nhaarman.Listviewanimations.Util.IInsertable {

		public BaseAdapterDecoratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseAdapterDecoratorInvoker); }
		}

	}

}
