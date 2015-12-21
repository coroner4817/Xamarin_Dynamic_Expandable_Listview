using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorInflater']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/AnimatorInflater", DoNotGenerateAcw=true)]
	public partial class AnimatorInflater : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/AnimatorInflater", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorInflater); }
		}

		protected AnimatorInflater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorInflater']/constructor[@name='AnimatorInflater' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimatorInflater ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AnimatorInflater)) {
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

		static IntPtr id_loadAnimator_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='AnimatorInflater']/method[@name='loadAnimator' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("loadAnimator", "(Landroid/content/Context;I)Lcom/nineoldandroids/animation/Animator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.Animator LoadAnimator (global::Android.Content.Context p0, int p1)
		{
			if (id_loadAnimator_Landroid_content_Context_I == IntPtr.Zero)
				id_loadAnimator_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "loadAnimator", "(Landroid/content/Context;I)Lcom/nineoldandroids/animation/Animator;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Nineoldandroids.Animation.Animator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadAnimator_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
