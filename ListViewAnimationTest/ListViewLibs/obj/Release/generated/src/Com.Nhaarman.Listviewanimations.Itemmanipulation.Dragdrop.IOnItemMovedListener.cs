using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/interface[@name='OnItemMovedListener']"
	[Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListener", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerInvoker")]
	public partial interface IOnItemMovedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/interface[@name='OnItemMovedListener']/method[@name='onItemMoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onItemMoved", "(II)V", "GetOnItemMoved_IIHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerInvoker, ListViewLibs")]
		void OnItemMoved (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListener", DoNotGenerateAcw=true)]
	internal class IOnItemMovedListenerInvoker : global::Java.Lang.Object, IOnItemMovedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListener");
		IntPtr class_ref;

		public static IOnItemMovedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnItemMovedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.dragdrop.OnItemMovedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnItemMovedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnItemMovedListenerInvoker); }
		}

		static Delegate cb_onItemMoved_II;
#pragma warning disable 0169
		static Delegate GetOnItemMoved_IIHandler ()
		{
			if (cb_onItemMoved_II == null)
				cb_onItemMoved_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnItemMoved_II);
			return cb_onItemMoved_II;
		}

		static void n_OnItemMoved_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnItemMoved (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onItemMoved_II;
		public unsafe void OnItemMoved (int p0, int p1)
		{
			if (id_onItemMoved_II == IntPtr.Zero)
				id_onItemMoved_II = JNIEnv.GetMethodID (class_ref, "onItemMoved", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onItemMoved_II, __args);
		}

	}

	public partial class ItemMovedEventArgs : global::System.EventArgs {

		public ItemMovedEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListenerImplementor")]
	internal sealed partial class IOnItemMovedListenerImplementor : global::Java.Lang.Object, IOnItemMovedListener {

		object sender;

		public IOnItemMovedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ItemMovedEventArgs> Handler;
#pragma warning restore 0649

		public void OnItemMoved (int p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ItemMovedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnItemMovedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
