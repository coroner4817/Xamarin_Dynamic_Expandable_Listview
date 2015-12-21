using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AnimatorUtil']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/util/AnimatorUtil", DoNotGenerateAcw=true)]
	public partial class AnimatorUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/util/AnimatorUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorUtil); }
		}

		protected AnimatorUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_concatAnimators_arrayLcom_nineoldandroids_animation_Animator_arrayLcom_nineoldandroids_animation_Animator_Lcom_nineoldandroids_animation_Animator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AnimatorUtil']/method[@name='concatAnimators' and count(parameter)=3 and parameter[1][@type='com.nineoldandroids.animation.Animator[]'] and parameter[2][@type='com.nineoldandroids.animation.Animator[]'] and parameter[3][@type='com.nineoldandroids.animation.Animator']]"
		[Register ("concatAnimators", "([Lcom/nineoldandroids/animation/Animator;[Lcom/nineoldandroids/animation/Animator;Lcom/nineoldandroids/animation/Animator;)[Lcom/nineoldandroids/animation/Animator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.Animator[] ConcatAnimators (global::Com.Nineoldandroids.Animation.Animator[] p0, global::Com.Nineoldandroids.Animation.Animator[] p1, global::Com.Nineoldandroids.Animation.Animator p2)
		{
			if (id_concatAnimators_arrayLcom_nineoldandroids_animation_Animator_arrayLcom_nineoldandroids_animation_Animator_Lcom_nineoldandroids_animation_Animator_ == IntPtr.Zero)
				id_concatAnimators_arrayLcom_nineoldandroids_animation_Animator_arrayLcom_nineoldandroids_animation_Animator_Lcom_nineoldandroids_animation_Animator_ = JNIEnv.GetStaticMethodID (class_ref, "concatAnimators", "([Lcom/nineoldandroids/animation/Animator;[Lcom/nineoldandroids/animation/Animator;Lcom/nineoldandroids/animation/Animator;)[Lcom/nineoldandroids/animation/Animator;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Nineoldandroids.Animation.Animator[] __ret = (global::Com.Nineoldandroids.Animation.Animator[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatAnimators_arrayLcom_nineoldandroids_animation_Animator_arrayLcom_nineoldandroids_animation_Animator_Lcom_nineoldandroids_animation_Animator_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nineoldandroids.Animation.Animator));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
