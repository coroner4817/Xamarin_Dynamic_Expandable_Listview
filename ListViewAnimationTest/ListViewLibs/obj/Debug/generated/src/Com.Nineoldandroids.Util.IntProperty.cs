using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.util']/class[@name='IntProperty']"
	[global::Android.Runtime.Register ("com/nineoldandroids/util/IntProperty", DoNotGenerateAcw=true)]
	public abstract partial class IntProperty : global::Com.Nineoldandroids.Util.Property {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/util/IntProperty", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IntProperty); }
		}

		protected IntProperty (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.util']/class[@name='IntProperty']/constructor[@name='IntProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe IntProperty (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (IntProperty)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_set_Ljava_lang_Object_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.util']/class[@name='IntProperty']/method[@name='set' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("set", "(Ljava/lang/Object;Ljava/lang/Integer;)V", "")]
		public unsafe void Set (global::Java.Lang.Object p0, global::Java.Lang.Integer p1)
		{
			if (id_set_Ljava_lang_Object_Ljava_lang_Integer_ == IntPtr.Zero)
				id_set_Ljava_lang_Object_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/Object;Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_Object_Ljava_lang_Integer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setValue_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_Object_IHandler ()
		{
			if (cb_setValue_Ljava_lang_Object_I == null)
				cb_setValue_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetValue_Ljava_lang_Object_I);
			return cb_setValue_Ljava_lang_Object_I;
		}

		static void n_SetValue_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nineoldandroids.Util.IntProperty __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.IntProperty> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.util']/class[@name='IntProperty']/method[@name='setValue' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='int']]"
		[Register ("setValue", "(Ljava/lang/Object;I)V", "GetSetValue_Ljava_lang_Object_IHandler")]
		public abstract void SetValue (global::Java.Lang.Object p0, int p1);

	}

	[global::Android.Runtime.Register ("com/nineoldandroids/util/IntProperty", DoNotGenerateAcw=true)]
	internal partial class IntPropertyInvoker : IntProperty {

		public IntPropertyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (IntPropertyInvoker); }
		}

		static IntPtr id_setValue_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.util']/class[@name='IntProperty']/method[@name='setValue' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='int']]"
		[Register ("setValue", "(Ljava/lang/Object;I)V", "GetSetValue_Ljava_lang_Object_IHandler")]
		public override unsafe void SetValue (global::Java.Lang.Object p0, int p1)
		{
			if (id_setValue_Ljava_lang_Object_I == IntPtr.Zero)
				id_setValue_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;I)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_Object_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_get_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.util']/class[@name='Property']/method[@name='get' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public override unsafe global::Java.Lang.Object Get (global::Java.Lang.Object p0)
		{
			if (id_get_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
