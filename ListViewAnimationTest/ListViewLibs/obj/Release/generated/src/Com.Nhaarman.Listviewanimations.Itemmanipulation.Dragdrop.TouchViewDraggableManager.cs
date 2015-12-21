using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='TouchViewDraggableManager']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/TouchViewDraggableManager", DoNotGenerateAcw=true)]
	public partial class TouchViewDraggableManager : global::Java.Lang.Object, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/TouchViewDraggableManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TouchViewDraggableManager); }
		}

		protected TouchViewDraggableManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='TouchViewDraggableManager']/constructor[@name='TouchViewDraggableManager' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe TouchViewDraggableManager (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TouchViewDraggableManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_isDraggable_Landroid_view_View_IFF;
#pragma warning disable 0169
		static Delegate GetIsDraggable_Landroid_view_View_IFFHandler ()
		{
			if (cb_isDraggable_Landroid_view_View_IFF == null)
				cb_isDraggable_Landroid_view_View_IFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float, float, bool>) n_IsDraggable_Landroid_view_View_IFF);
			return cb_isDraggable_Landroid_view_View_IFF;
		}

		static bool n_IsDraggable_Landroid_view_View_IFF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2, float p3)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.TouchViewDraggableManager __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.TouchViewDraggableManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDraggable (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isDraggable_Landroid_view_View_IFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='TouchViewDraggableManager']/method[@name='isDraggable' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("isDraggable", "(Landroid/view/View;IFF)Z", "GetIsDraggable_Landroid_view_View_IFFHandler")]
		public virtual unsafe bool IsDraggable (global::Android.Views.View p0, int p1, float p2, float p3)
		{
			if (id_isDraggable_Landroid_view_View_IFF == IntPtr.Zero)
				id_isDraggable_Landroid_view_View_IFF = JNIEnv.GetMethodID (class_ref, "isDraggable", "(Landroid/view/View;IFF)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isDraggable_Landroid_view_View_IFF, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDraggable", "(Landroid/view/View;IFF)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
