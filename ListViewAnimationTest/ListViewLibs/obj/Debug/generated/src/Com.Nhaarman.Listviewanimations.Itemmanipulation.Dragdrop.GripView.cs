using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/GripView", DoNotGenerateAcw=true)]
	public partial class GripView : global::Android.Views.View {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']/field[@name='DEFAULT_COLUMN_COUNT']"
		[Register ("DEFAULT_COLUMN_COUNT")]
		public const int DefaultColumnCount = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']/field[@name='DEFAULT_DOT_COLOR']"
		[Register ("DEFAULT_DOT_COLOR")]
		public const int DefaultDotColor = (int) 17170432;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']/field[@name='DEFAULT_DOT_SIZE_RADIUS_DP']"
		[Register ("DEFAULT_DOT_SIZE_RADIUS_DP")]
		public const float DefaultDotSizeRadiusDp = (float) 2.000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/GripView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GripView); }
		}

		protected GripView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']/constructor[@name='GripView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe GripView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (GripView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']/constructor[@name='GripView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe GripView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GripView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']/constructor[@name='GripView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GripView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GripView)) {
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

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.GripView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.GripView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
		public virtual unsafe void SetColor (int p0)
		{
			if (id_setColor_I == IntPtr.Zero)
				id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColumnCount_I;
#pragma warning disable 0169
		static Delegate GetSetColumnCount_IHandler ()
		{
			if (cb_setColumnCount_I == null)
				cb_setColumnCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColumnCount_I);
			return cb_setColumnCount_I;
		}

		static void n_SetColumnCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.GripView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.GripView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColumnCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColumnCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']/method[@name='setColumnCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColumnCount", "(I)V", "GetSetColumnCount_IHandler")]
		public virtual unsafe void SetColumnCount (int p0)
		{
			if (id_setColumnCount_I == IntPtr.Zero)
				id_setColumnCount_I = JNIEnv.GetMethodID (class_ref, "setColumnCount", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColumnCount_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColumnCount", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDotSizeRadiusPx_F;
#pragma warning disable 0169
		static Delegate GetSetDotSizeRadiusPx_FHandler ()
		{
			if (cb_setDotSizeRadiusPx_F == null)
				cb_setDotSizeRadiusPx_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDotSizeRadiusPx_F);
			return cb_setDotSizeRadiusPx_F;
		}

		static void n_SetDotSizeRadiusPx_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.GripView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.GripView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDotSizeRadiusPx (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDotSizeRadiusPx_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='GripView']/method[@name='setDotSizeRadiusPx' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDotSizeRadiusPx", "(F)V", "GetSetDotSizeRadiusPx_FHandler")]
		public virtual unsafe void SetDotSizeRadiusPx (float p0)
		{
			if (id_setDotSizeRadiusPx_F == IntPtr.Zero)
				id_setDotSizeRadiusPx_F = JNIEnv.GetMethodID (class_ref, "setDotSizeRadiusPx", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDotSizeRadiusPx_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDotSizeRadiusPx", "(F)V"), __args);
			} finally {
			}
		}

	}
}
