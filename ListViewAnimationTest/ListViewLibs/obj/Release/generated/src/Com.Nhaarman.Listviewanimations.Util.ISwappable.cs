using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='Swappable']"
	[Register ("com/nhaarman/listviewanimations/util/Swappable", "", "Com.Nhaarman.Listviewanimations.Util.ISwappableInvoker")]
	public partial interface ISwappable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='Swappable']/method[@name='swapItems' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("swapItems", "(II)V", "GetSwapItems_IIHandler:Com.Nhaarman.Listviewanimations.Util.ISwappableInvoker, ListViewLibs")]
		void SwapItems (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/util/Swappable", DoNotGenerateAcw=true)]
	internal class ISwappableInvoker : global::Java.Lang.Object, ISwappable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/util/Swappable");
		IntPtr class_ref;

		public static ISwappable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISwappable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.util.Swappable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISwappableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISwappableInvoker); }
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
			global::Com.Nhaarman.Listviewanimations.Util.ISwappable __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.ISwappable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwapItems (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_swapItems_II;
		public unsafe void SwapItems (int p0, int p1)
		{
			if (id_swapItems_II == IntPtr.Zero)
				id_swapItems_II = JNIEnv.GetMethodID (class_ref, "swapItems", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_swapItems_II, __args);
		}

	}

}
