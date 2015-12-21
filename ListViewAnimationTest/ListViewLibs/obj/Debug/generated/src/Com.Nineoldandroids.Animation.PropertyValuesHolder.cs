using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/PropertyValuesHolder", DoNotGenerateAcw=true)]
	public partial class PropertyValuesHolder : global::Java.Lang.Object, global::Java.Lang.ICloneable {


		static IntPtr mProperty_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/field[@name='mProperty']"
		[Register ("mProperty")]
		protected global::Com.Nineoldandroids.Util.Property MProperty {
			get {
				if (mProperty_jfieldId == IntPtr.Zero)
					mProperty_jfieldId = JNIEnv.GetFieldID (class_ref, "mProperty", "Lcom/nineoldandroids/util/Property;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mProperty_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProperty_jfieldId == IntPtr.Zero)
					mProperty_jfieldId = JNIEnv.GetFieldID (class_ref, "mProperty", "Lcom/nineoldandroids/util/Property;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mProperty_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.FloatPropertyValuesHolder']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/PropertyValuesHolder$FloatPropertyValuesHolder", DoNotGenerateAcw=true)]
		public partial class FloatPropertyValuesHolder : global::Com.Nineoldandroids.Animation.PropertyValuesHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/PropertyValuesHolder$FloatPropertyValuesHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FloatPropertyValuesHolder); }
			}

			protected FloatPropertyValuesHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nineoldandroids_util_Property_arrayF;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.FloatPropertyValuesHolder']/constructor[@name='PropertyValuesHolder.FloatPropertyValuesHolder' and count(parameter)=2 and parameter[1][@type='com.nineoldandroids.util.Property'] and parameter[2][@type='float...']]"
			[Register (".ctor", "(Lcom/nineoldandroids/util/Property;[F)V", "")]
			public unsafe FloatPropertyValuesHolder (global::Com.Nineoldandroids.Util.Property p0, params  float[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (FloatPropertyValuesHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nineoldandroids/util/Property;[F)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nineoldandroids/util/Property;[F)V", __args);
						return;
					}

					if (id_ctor_Lcom_nineoldandroids_util_Property_arrayF == IntPtr.Zero)
						id_ctor_Lcom_nineoldandroids_util_Property_arrayF = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/util/Property;[F)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nineoldandroids_util_Property_arrayF, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nineoldandroids_util_Property_arrayF, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_arrayF;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.FloatPropertyValuesHolder']/constructor[@name='PropertyValuesHolder.FloatPropertyValuesHolder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float...']]"
			[Register (".ctor", "(Ljava/lang/String;[F)V", "")]
			public unsafe FloatPropertyValuesHolder (string p0, params  float[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (FloatPropertyValuesHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[F)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;[F)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_arrayF == IntPtr.Zero)
						id_ctor_Ljava_lang_String_arrayF = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[F)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayF, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_arrayF, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static IntPtr id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_FloatKeyframeSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.FloatPropertyValuesHolder']/constructor[@name='PropertyValuesHolder.FloatPropertyValuesHolder' and count(parameter)=2 and parameter[1][@type='com.nineoldandroids.util.Property'] and parameter[2][@type='com.nineoldandroids.animation.FloatKeyframeSet']]"
			[Register (".ctor", "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/FloatKeyframeSet;)V", "")]
			public unsafe FloatPropertyValuesHolder (global::Com.Nineoldandroids.Util.Property p0, global::Com.Nineoldandroids.Animation.FloatKeyframeSet p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (FloatPropertyValuesHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/FloatKeyframeSet;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/FloatKeyframeSet;)V", __args);
						return;
					}

					if (id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_FloatKeyframeSet_ == IntPtr.Zero)
						id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_FloatKeyframeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/FloatKeyframeSet;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_FloatKeyframeSet_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_FloatKeyframeSet_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_FloatKeyframeSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.FloatPropertyValuesHolder']/constructor[@name='PropertyValuesHolder.FloatPropertyValuesHolder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nineoldandroids.animation.FloatKeyframeSet']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/nineoldandroids/animation/FloatKeyframeSet;)V", "")]
			public unsafe FloatPropertyValuesHolder (string p0, global::Com.Nineoldandroids.Animation.FloatKeyframeSet p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (FloatPropertyValuesHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/nineoldandroids/animation/FloatKeyframeSet;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/nineoldandroids/animation/FloatKeyframeSet;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_FloatKeyframeSet_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_FloatKeyframeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/nineoldandroids/animation/FloatKeyframeSet;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_FloatKeyframeSet_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_FloatKeyframeSet_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.IntPropertyValuesHolder']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/PropertyValuesHolder$IntPropertyValuesHolder", DoNotGenerateAcw=true)]
		public partial class IntPropertyValuesHolder : global::Com.Nineoldandroids.Animation.PropertyValuesHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/PropertyValuesHolder$IntPropertyValuesHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IntPropertyValuesHolder); }
			}

			protected IntPropertyValuesHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nineoldandroids_util_Property_arrayI;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.IntPropertyValuesHolder']/constructor[@name='PropertyValuesHolder.IntPropertyValuesHolder' and count(parameter)=2 and parameter[1][@type='com.nineoldandroids.util.Property'] and parameter[2][@type='int...']]"
			[Register (".ctor", "(Lcom/nineoldandroids/util/Property;[I)V", "")]
			public unsafe IntPropertyValuesHolder (global::Com.Nineoldandroids.Util.Property p0, params  int[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (IntPropertyValuesHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nineoldandroids/util/Property;[I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nineoldandroids/util/Property;[I)V", __args);
						return;
					}

					if (id_ctor_Lcom_nineoldandroids_util_Property_arrayI == IntPtr.Zero)
						id_ctor_Lcom_nineoldandroids_util_Property_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/util/Property;[I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nineoldandroids_util_Property_arrayI, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nineoldandroids_util_Property_arrayI, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_arrayI;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.IntPropertyValuesHolder']/constructor[@name='PropertyValuesHolder.IntPropertyValuesHolder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int...']]"
			[Register (".ctor", "(Ljava/lang/String;[I)V", "")]
			public unsafe IntPropertyValuesHolder (string p0, params  int[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (IntPropertyValuesHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;[I)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_arrayI == IntPtr.Zero)
						id_ctor_Ljava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayI, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_arrayI, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static IntPtr id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_IntKeyframeSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.IntPropertyValuesHolder']/constructor[@name='PropertyValuesHolder.IntPropertyValuesHolder' and count(parameter)=2 and parameter[1][@type='com.nineoldandroids.util.Property'] and parameter[2][@type='com.nineoldandroids.animation.IntKeyframeSet']]"
			[Register (".ctor", "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/IntKeyframeSet;)V", "")]
			public unsafe IntPropertyValuesHolder (global::Com.Nineoldandroids.Util.Property p0, global::Com.Nineoldandroids.Animation.IntKeyframeSet p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (IntPropertyValuesHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/IntKeyframeSet;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/IntKeyframeSet;)V", __args);
						return;
					}

					if (id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_IntKeyframeSet_ == IntPtr.Zero)
						id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_IntKeyframeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/IntKeyframeSet;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_IntKeyframeSet_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_IntKeyframeSet_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_IntKeyframeSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder.IntPropertyValuesHolder']/constructor[@name='PropertyValuesHolder.IntPropertyValuesHolder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nineoldandroids.animation.IntKeyframeSet']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/nineoldandroids/animation/IntKeyframeSet;)V", "")]
			public unsafe IntPropertyValuesHolder (string p0, global::Com.Nineoldandroids.Animation.IntKeyframeSet p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (IntPropertyValuesHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/nineoldandroids/animation/IntKeyframeSet;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/nineoldandroids/animation/IntKeyframeSet;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_IntKeyframeSet_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_IntKeyframeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/nineoldandroids/animation/IntKeyframeSet;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_IntKeyframeSet_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_nineoldandroids_animation_IntKeyframeSet_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/PropertyValuesHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PropertyValuesHolder); }
		}

		protected PropertyValuesHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getPropertyName;
#pragma warning disable 0169
		static Delegate GetGetPropertyNameHandler ()
		{
			if (cb_getPropertyName == null)
				cb_getPropertyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPropertyName);
			return cb_getPropertyName;
		}

		static IntPtr n_GetPropertyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PropertyName);
		}
#pragma warning restore 0169

		static Delegate cb_setPropertyName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPropertyName_Ljava_lang_String_Handler ()
		{
			if (cb_setPropertyName_Ljava_lang_String_ == null)
				cb_setPropertyName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPropertyName_Ljava_lang_String_);
			return cb_setPropertyName_Ljava_lang_String_;
		}

		static void n_SetPropertyName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PropertyName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPropertyName;
		static IntPtr id_setPropertyName_Ljava_lang_String_;
		public virtual unsafe string PropertyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='getPropertyName' and count(parameter)=0]"
			[Register ("getPropertyName", "()Ljava/lang/String;", "GetGetPropertyNameHandler")]
			get {
				if (id_getPropertyName == IntPtr.Zero)
					id_getPropertyName = JNIEnv.GetMethodID (class_ref, "getPropertyName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPropertyName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPropertyName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='setPropertyName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPropertyName", "(Ljava/lang/String;)V", "GetSetPropertyName_Ljava_lang_String_Handler")]
			set {
				if (id_setPropertyName_Ljava_lang_String_ == IntPtr.Zero)
					id_setPropertyName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPropertyName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPropertyName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPropertyName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/nineoldandroids/animation/PropertyValuesHolder;", "GetCloneHandler")]
		public virtual unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/nineoldandroids/animation/PropertyValuesHolder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ofFloat_Lcom_nineoldandroids_util_Property_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='ofFloat' and count(parameter)=2 and parameter[1][@type='com.nineoldandroids.util.Property&lt;?, java.lang.Float&gt;'] and parameter[2][@type='float...']]"
		[Register ("ofFloat", "(Lcom/nineoldandroids/util/Property;[F)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfFloat (global::Com.Nineoldandroids.Util.Property p0, params  float[] p1)
		{
			if (id_ofFloat_Lcom_nineoldandroids_util_Property_arrayF == IntPtr.Zero)
				id_ofFloat_Lcom_nineoldandroids_util_Property_arrayF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(Lcom/nineoldandroids/util/Property;[F)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_Lcom_nineoldandroids_util_Property_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ofFloat_Ljava_lang_String_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='ofFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float...']]"
		[Register ("ofFloat", "(Ljava/lang/String;[F)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfFloat (string p0, params  float[] p1)
		{
			if (id_ofFloat_Ljava_lang_String_arrayF == IntPtr.Zero)
				id_ofFloat_Ljava_lang_String_arrayF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(Ljava/lang/String;[F)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_Ljava_lang_String_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ofInt_Lcom_nineoldandroids_util_Property_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='ofInt' and count(parameter)=2 and parameter[1][@type='com.nineoldandroids.util.Property&lt;?, java.lang.Integer&gt;'] and parameter[2][@type='int...']]"
		[Register ("ofInt", "(Lcom/nineoldandroids/util/Property;[I)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfInt (global::Com.Nineoldandroids.Util.Property p0, params  int[] p1)
		{
			if (id_ofInt_Lcom_nineoldandroids_util_Property_arrayI == IntPtr.Zero)
				id_ofInt_Lcom_nineoldandroids_util_Property_arrayI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(Lcom/nineoldandroids/util/Property;[I)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_Lcom_nineoldandroids_util_Property_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ofInt_Ljava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='ofInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int...']]"
		[Register ("ofInt", "(Ljava/lang/String;[I)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfInt (string p0, params  int[] p1)
		{
			if (id_ofInt_Ljava_lang_String_arrayI == IntPtr.Zero)
				id_ofInt_Ljava_lang_String_arrayI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(Ljava/lang/String;[I)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_Ljava_lang_String_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ofKeyframe_Lcom_nineoldandroids_util_Property_arrayLcom_nineoldandroids_animation_Keyframe_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='ofKeyframe' and count(parameter)=2 and parameter[1][@type='com.nineoldandroids.util.Property'] and parameter[2][@type='com.nineoldandroids.animation.Keyframe...']]"
		[Register ("ofKeyframe", "(Lcom/nineoldandroids/util/Property;[Lcom/nineoldandroids/animation/Keyframe;)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfKeyframe (global::Com.Nineoldandroids.Util.Property p0, params global:: Com.Nineoldandroids.Animation.Keyframe[] p1)
		{
			if (id_ofKeyframe_Lcom_nineoldandroids_util_Property_arrayLcom_nineoldandroids_animation_Keyframe_ == IntPtr.Zero)
				id_ofKeyframe_Lcom_nineoldandroids_util_Property_arrayLcom_nineoldandroids_animation_Keyframe_ = JNIEnv.GetStaticMethodID (class_ref, "ofKeyframe", "(Lcom/nineoldandroids/util/Property;[Lcom/nineoldandroids/animation/Keyframe;)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofKeyframe_Lcom_nineoldandroids_util_Property_arrayLcom_nineoldandroids_animation_Keyframe_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ofKeyframe_Ljava_lang_String_arrayLcom_nineoldandroids_animation_Keyframe_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='ofKeyframe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nineoldandroids.animation.Keyframe...']]"
		[Register ("ofKeyframe", "(Ljava/lang/String;[Lcom/nineoldandroids/animation/Keyframe;)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfKeyframe (string p0, params global:: Com.Nineoldandroids.Animation.Keyframe[] p1)
		{
			if (id_ofKeyframe_Ljava_lang_String_arrayLcom_nineoldandroids_animation_Keyframe_ == IntPtr.Zero)
				id_ofKeyframe_Ljava_lang_String_arrayLcom_nineoldandroids_animation_Keyframe_ = JNIEnv.GetStaticMethodID (class_ref, "ofKeyframe", "(Ljava/lang/String;[Lcom/nineoldandroids/animation/Keyframe;)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofKeyframe_Ljava_lang_String_arrayLcom_nineoldandroids_animation_Keyframe_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ofObject_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='ofObject' and count(parameter)=3 and parameter[1][@type='com.nineoldandroids.util.Property'] and parameter[2][@type='com.nineoldandroids.animation.TypeEvaluator&lt;V&gt;'] and parameter[3][@type='V...']]"
		[Register ("ofObject", "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfObject (global::Com.Nineoldandroids.Util.Property p0, global::Com.Nineoldandroids.Animation.ITypeEvaluator p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_ofObject_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(Lcom/nineoldandroids/util/Property;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_Lcom_nineoldandroids_util_Property_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_ofObject_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='ofObject' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.nineoldandroids.animation.TypeEvaluator'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("ofObject", "(Ljava/lang/String;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/PropertyValuesHolder;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder OfObject (string p0, global::Com.Nineoldandroids.Animation.ITypeEvaluator p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_ofObject_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(Ljava/lang/String;Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Nineoldandroids.Animation.PropertyValuesHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_Ljava_lang_String_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
#pragma warning disable 0169
		static Delegate GetSetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_Handler ()
		{
			if (cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ == null)
				cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_);
			return cb_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
		}

		static void n_SetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.ITypeEvaluator p0 = (global::Com.Nineoldandroids.Animation.ITypeEvaluator)global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ITypeEvaluator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEvaluator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='setEvaluator' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.TypeEvaluator']]"
		[Register ("setEvaluator", "(Lcom/nineoldandroids/animation/TypeEvaluator;)V", "GetSetEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_Handler")]
		public virtual unsafe void SetEvaluator (global::Com.Nineoldandroids.Animation.ITypeEvaluator p0)
		{
			if (id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ == IntPtr.Zero)
				id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_ = JNIEnv.GetMethodID (class_ref, "setEvaluator", "(Lcom/nineoldandroids/animation/TypeEvaluator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEvaluator", "(Lcom/nineoldandroids/animation/TypeEvaluator;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFloatValues_arrayF;
#pragma warning disable 0169
		static Delegate GetSetFloatValues_arrayFHandler ()
		{
			if (cb_setFloatValues_arrayF == null)
				cb_setFloatValues_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFloatValues_arrayF);
			return cb_setFloatValues_arrayF;
		}

		static void n_SetFloatValues_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetFloatValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFloatValues_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='setFloatValues' and count(parameter)=1 and parameter[1][@type='float...']]"
		[Register ("setFloatValues", "([F)V", "GetSetFloatValues_arrayFHandler")]
		public virtual unsafe void SetFloatValues (params  float[] p0)
		{
			if (id_setFloatValues_arrayF == IntPtr.Zero)
				id_setFloatValues_arrayF = JNIEnv.GetMethodID (class_ref, "setFloatValues", "([F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFloatValues_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatValues", "([F)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setIntValues_arrayI;
#pragma warning disable 0169
		static Delegate GetSetIntValues_arrayIHandler ()
		{
			if (cb_setIntValues_arrayI == null)
				cb_setIntValues_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntValues_arrayI);
			return cb_setIntValues_arrayI;
		}

		static void n_SetIntValues_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetIntValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIntValues_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='setIntValues' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setIntValues", "([I)V", "GetSetIntValues_arrayIHandler")]
		public virtual unsafe void SetIntValues (params  int[] p0)
		{
			if (id_setIntValues_arrayI == IntPtr.Zero)
				id_setIntValues_arrayI = JNIEnv.GetMethodID (class_ref, "setIntValues", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIntValues_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntValues", "([I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_;
#pragma warning disable 0169
		static Delegate GetSetKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_Handler ()
		{
			if (cb_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ == null)
				cb_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_);
			return cb_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_;
		}

		static void n_SetKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.Keyframe[] p0 = (global::Com.Nineoldandroids.Animation.Keyframe[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Nineoldandroids.Animation.Keyframe));
			__this.SetKeyframes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='setKeyframes' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.Keyframe...']]"
		[Register ("setKeyframes", "([Lcom/nineoldandroids/animation/Keyframe;)V", "GetSetKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_Handler")]
		public virtual unsafe void SetKeyframes (params global:: Com.Nineoldandroids.Animation.Keyframe[] p0)
		{
			if (id_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ == IntPtr.Zero)
				id_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_ = JNIEnv.GetMethodID (class_ref, "setKeyframes", "([Lcom/nineoldandroids/animation/Keyframe;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setKeyframes_arrayLcom_nineoldandroids_animation_Keyframe_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeyframes", "([Lcom/nineoldandroids/animation/Keyframe;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setObjectValues_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetObjectValues_arrayLjava_lang_Object_Handler ()
		{
			if (cb_setObjectValues_arrayLjava_lang_Object_ == null)
				cb_setObjectValues_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObjectValues_arrayLjava_lang_Object_);
			return cb_setObjectValues_arrayLjava_lang_Object_;
		}

		static void n_SetObjectValues_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.SetObjectValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setObjectValues_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='setObjectValues' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("setObjectValues", "([Ljava/lang/Object;)V", "GetSetObjectValues_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void SetObjectValues (params global:: Java.Lang.Object[] p0)
		{
			if (id_setObjectValues_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_setObjectValues_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setObjectValues", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setObjectValues_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setObjectValues", "([Ljava/lang/Object;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setProperty_Lcom_nineoldandroids_util_Property_;
#pragma warning disable 0169
		static Delegate GetSetProperty_Lcom_nineoldandroids_util_Property_Handler ()
		{
			if (cb_setProperty_Lcom_nineoldandroids_util_Property_ == null)
				cb_setProperty_Lcom_nineoldandroids_util_Property_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProperty_Lcom_nineoldandroids_util_Property_);
			return cb_setProperty_Lcom_nineoldandroids_util_Property_;
		}

		static void n_SetProperty_Lcom_nineoldandroids_util_Property_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.PropertyValuesHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Util.Property p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Util.Property> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetProperty (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setProperty_Lcom_nineoldandroids_util_Property_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='PropertyValuesHolder']/method[@name='setProperty' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.util.Property']]"
		[Register ("setProperty", "(Lcom/nineoldandroids/util/Property;)V", "GetSetProperty_Lcom_nineoldandroids_util_Property_Handler")]
		public virtual unsafe void SetProperty (global::Com.Nineoldandroids.Util.Property p0)
		{
			if (id_setProperty_Lcom_nineoldandroids_util_Property_ == IntPtr.Zero)
				id_setProperty_Lcom_nineoldandroids_util_Property_ = JNIEnv.GetMethodID (class_ref, "setProperty", "(Lcom/nineoldandroids/util/Property;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setProperty_Lcom_nineoldandroids_util_Property_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProperty", "(Lcom/nineoldandroids/util/Property;)V"), __args);
			} finally {
			}
		}

	}
}
