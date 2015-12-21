using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/ObjectAnimator", DoNotGenerateAcw=true)]
	public sealed partial class ObjectAnimator : global::Com.Nineoldandroids.Animation.ValueAnimator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/ObjectAnimator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectAnimator); }
		}

		internal ObjectAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/constructor[@name='ObjectAnimator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectAnimator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ObjectAnimator)) {
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

		static IntPtr id_getPropertyName;
		static IntPtr id_setPropertyName_Ljava_lang_String_;
		public unsafe string PropertyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='getPropertyName' and count(parameter)=0]"
			[Register ("getPropertyName", "()Ljava/lang/String;", "GetGetPropertyNameHandler")]
			get {
				if (id_getPropertyName == IntPtr.Zero)
					id_getPropertyName = JNIEnv.GetMethodID (class_ref, "getPropertyName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPropertyName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='setPropertyName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPropertyName", "(Ljava/lang/String;)V", "GetSetPropertyName_Ljava_lang_String_Handler")]
			set {
				if (id_setPropertyName_Ljava_lang_String_ == IntPtr.Zero)
					id_setPropertyName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPropertyName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setPropertyName_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getTarget;
		public unsafe global::Java.Lang.Object Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Ljava/lang/Object;", "GetGetTargetHandler")]
			get {
				if (id_getTarget == IntPtr.Zero)
					id_getTarget = JNIEnv.GetMethodID (class_ref, "getTarget", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getTarget), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_ofFloat_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='ofFloat' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='com.nineoldandroids.util.Property&lt;T, java.lang.Float&gt;'] and parameter[3][@type='float...']]"
		[Register ("ofFloat", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;[F)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ObjectAnimator OfFloat (global::Java.Lang.Object p0, global::Com.Nineoldandroids.Util.Property p1, params  float[] p2)
		{
			if (id_ofFloat_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayF == IntPtr.Zero)
				id_ofFloat_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;[F)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_ofFloat_Ljava_lang_Object_Ljava_lang_String_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='ofFloat' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float...']]"
		[Register ("ofFloat", "(Ljava/lang/Object;Ljava/lang/String;[F)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ObjectAnimator OfFloat (global::Java.Lang.Object p0, string p1, params  float[] p2)
		{
			if (id_ofFloat_Ljava_lang_Object_Ljava_lang_String_arrayF == IntPtr.Zero)
				id_ofFloat_Ljava_lang_Object_Ljava_lang_String_arrayF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(Ljava/lang/Object;Ljava/lang/String;[F)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_Ljava_lang_Object_Ljava_lang_String_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_ofInt_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='ofInt' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='com.nineoldandroids.util.Property&lt;T, java.lang.Integer&gt;'] and parameter[3][@type='int...']]"
		[Register ("ofInt", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;[I)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ObjectAnimator OfInt (global::Java.Lang.Object p0, global::Com.Nineoldandroids.Util.Property p1, params  int[] p2)
		{
			if (id_ofInt_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayI == IntPtr.Zero)
				id_ofInt_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;[I)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_ofInt_Ljava_lang_Object_Ljava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='ofInt' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int...']]"
		[Register ("ofInt", "(Ljava/lang/Object;Ljava/lang/String;[I)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ObjectAnimator OfInt (global::Java.Lang.Object p0, string p1, params  int[] p2)
		{
			if (id_ofInt_Ljava_lang_Object_Ljava_lang_String_arrayI == IntPtr.Zero)
				id_ofInt_Ljava_lang_Object_Ljava_lang_String_arrayI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(Ljava/lang/Object;Ljava/lang/String;[I)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_Ljava_lang_Object_Ljava_lang_String_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_ofObject_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='ofObject' and count(parameter)=4 and parameter[1][@type='T'] and parameter[2][@type='com.nineoldandroids.util.Property&lt;T, V&gt;'] and parameter[3][@type='com.nineoldandroids.animation.TypeEvaluator&lt;V&gt;'] and parameter[4][@type='V...']]"
		[Register ("ofObject", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ObjectAnimator OfObject (global::Java.Lang.Object p0, global::Com.Nineoldandroids.Util.Property p1, global::Com.Nineoldandroids.Animation.ITypeEvaluator p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_ofObject_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(Ljava/lang/Object;Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_Ljava_lang_Object_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_ofObject_Ljava_lang_Object_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='ofObject' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.nineoldandroids.animation.TypeEvaluator'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("ofObject", "(Ljava/lang/Object;Ljava/lang/String;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ObjectAnimator OfObject (global::Java.Lang.Object p0, string p1, global::Com.Nineoldandroids.Animation.ITypeEvaluator p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_ofObject_Ljava_lang_Object_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_Ljava_lang_Object_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(Ljava/lang/Object;Ljava/lang/String;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_Ljava_lang_Object_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_ofPropertyValuesHolder_Ljava_lang_Object_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='ofPropertyValuesHolder' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.nineoldandroids.animation.PropertyValuesHolder...']]"
		[Register ("ofPropertyValuesHolder", "(Ljava/lang/Object;[Lcom/nineoldandroids/animation/PropertyValuesHolder;)Lcom/nineoldandroids/animation/ObjectAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ObjectAnimator OfPropertyValuesHolder (global::Java.Lang.Object p0, params global:: Com.Nineoldandroids.Animation.PropertyValuesHolder[] p1)
		{
			if (id_ofPropertyValuesHolder_Ljava_lang_Object_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ == IntPtr.Zero)
				id_ofPropertyValuesHolder_Ljava_lang_Object_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ = JNIEnv.GetStaticMethodID (class_ref, "ofPropertyValuesHolder", "(Ljava/lang/Object;[Lcom/nineoldandroids/animation/PropertyValuesHolder;)Lcom/nineoldandroids/animation/ObjectAnimator;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Nineoldandroids.Animation.ObjectAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ObjectAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofPropertyValuesHolder_Ljava_lang_Object_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_setProperty_Lcom_nineoldandroids_util_Property_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ObjectAnimator']/method[@name='setProperty' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.util.Property']]"
		[Register ("setProperty", "(Lcom/nineoldandroids/util/Property;)V", "")]
		public unsafe void SetProperty (global::Com.Nineoldandroids.Util.Property p0)
		{
			if (id_setProperty_Lcom_nineoldandroids_util_Property_ == IntPtr.Zero)
				id_setProperty_Lcom_nineoldandroids_util_Property_ = JNIEnv.GetMethodID (class_ref, "setProperty", "(Lcom/nineoldandroids/util/Property;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setProperty_Lcom_nineoldandroids_util_Property_, __args);
			} finally {
			}
		}

	}
}
