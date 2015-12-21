using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='Insertable']"
	[Register ("com/nhaarman/listviewanimations/util/Insertable", "", "Com.Nhaarman.Listviewanimations.Util.IInsertableInvoker")]
	public partial interface IInsertable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/interface[@name='Insertable']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("add", "(ILjava/lang/Object;)V", "GetAdd_ILjava_lang_Object_Handler:Com.Nhaarman.Listviewanimations.Util.IInsertableInvoker, ListViewLibs")]
		void Add (int p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/util/Insertable", DoNotGenerateAcw=true)]
	internal class IInsertableInvoker : global::Java.Lang.Object, IInsertable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/util/Insertable");
		IntPtr class_ref;

		public static IInsertable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInsertable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.util.Insertable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInsertableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInsertableInvoker); }
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
			global::Com.Nhaarman.Listviewanimations.Util.IInsertable __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IInsertable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_add_ILjava_lang_Object_;
		public unsafe void Add (int p0, global::Java.Lang.Object p1)
		{
			if (id_add_ILjava_lang_Object_ == IntPtr.Zero)
				id_add_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(ILjava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_add_ILjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
