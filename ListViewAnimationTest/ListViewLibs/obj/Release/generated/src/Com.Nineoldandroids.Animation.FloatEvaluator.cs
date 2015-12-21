using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='FloatEvaluator']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/FloatEvaluator", DoNotGenerateAcw=true)]
	public partial class FloatEvaluator : global::Java.Lang.Object, global::Com.Nineoldandroids.Animation.ITypeEvaluator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/FloatEvaluator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FloatEvaluator); }
		}

		protected FloatEvaluator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='FloatEvaluator']/constructor[@name='FloatEvaluator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FloatEvaluator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FloatEvaluator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_evaluate_FLjava_lang_Number_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetEvaluate_FLjava_lang_Number_Ljava_lang_Number_Handler ()
		{
			if (cb_evaluate_FLjava_lang_Number_Ljava_lang_Number_ == null)
				cb_evaluate_FLjava_lang_Number_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr>) n_Evaluate_FLjava_lang_Number_Ljava_lang_Number_);
			return cb_evaluate_FLjava_lang_Number_Ljava_lang_Number_;
		}

		static IntPtr n_Evaluate_FLjava_lang_Number_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nineoldandroids.Animation.FloatEvaluator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.FloatEvaluator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Evaluate (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_evaluate_FLjava_lang_Number_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='FloatEvaluator']/method[@name='evaluate' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='java.lang.Number'] and parameter[3][@type='java.lang.Number']]"
		[Register ("evaluate", "(FLjava/lang/Number;Ljava/lang/Number;)Ljava/lang/Float;", "GetEvaluate_FLjava_lang_Number_Ljava_lang_Number_Handler")]
		public virtual unsafe global::Java.Lang.Float Evaluate (float p0, global::Java.Lang.Number p1, global::Java.Lang.Number p2)
		{
			if (id_evaluate_FLjava_lang_Number_Ljava_lang_Number_ == IntPtr.Zero)
				id_evaluate_FLjava_lang_Number_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "evaluate", "(FLjava/lang/Number;Ljava/lang/Number;)Ljava/lang/Float;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Lang.Float __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallObjectMethod  (Handle, id_evaluate_FLjava_lang_Number_Ljava_lang_Number_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "evaluate", "(FLjava/lang/Number;Ljava/lang/Number;)Ljava/lang/Float;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Nineoldandroids.Animation.ITypeEvaluator
		global::Java.Lang.Object global::Com.Nineoldandroids.Animation.ITypeEvaluator.Evaluate (float p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Evaluate (p0, global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Number>(p1), global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Number>(p2)));
		}

	}
}
