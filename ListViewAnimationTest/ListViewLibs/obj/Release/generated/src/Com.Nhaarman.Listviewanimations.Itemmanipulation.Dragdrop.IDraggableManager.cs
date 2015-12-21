using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/interface[@name='DraggableManager']"
	[Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DraggableManager", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManagerInvoker")]
	public partial interface IDraggableManager : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/interface[@name='DraggableManager']/method[@name='isDraggable' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("isDraggable", "(Landroid/view/View;IFF)Z", "GetIsDraggable_Landroid_view_View_IFFHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManagerInvoker, ListViewLibs")]
		bool IsDraggable (global::Android.Views.View p0, int p1, float p2, float p3);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DraggableManager", DoNotGenerateAcw=true)]
	internal class IDraggableManagerInvoker : global::Java.Lang.Object, IDraggableManager {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DraggableManager");
		IntPtr class_ref;

		public static IDraggableManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDraggableManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.dragdrop.DraggableManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDraggableManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDraggableManagerInvoker); }
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDraggable (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isDraggable_Landroid_view_View_IFF;
		public unsafe bool IsDraggable (global::Android.Views.View p0, int p1, float p2, float p3)
		{
			if (id_isDraggable_Landroid_view_View_IFF == IntPtr.Zero)
				id_isDraggable_Landroid_view_View_IFF = JNIEnv.GetMethodID (class_ref, "isDraggable", "(Landroid/view/View;IFF)Z");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_isDraggable_Landroid_view_View_IFF, __args);
			return __ret;
		}

	}

}
