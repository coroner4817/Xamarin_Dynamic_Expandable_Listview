using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/Keyframe", DoNotGenerateAcw=true)]
	public abstract partial class Keyframe : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.FloatKeyframe']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/Keyframe$FloatKeyframe", DoNotGenerateAcw=true)]
		public partial class FloatKeyframe : global::Com.Nineoldandroids.Animation.Keyframe {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/Keyframe$FloatKeyframe", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FloatKeyframe); }
			}

			protected FloatKeyframe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getFloatValue;
#pragma warning disable 0169
			static Delegate GetGetFloatValueHandler ()
			{
				if (cb_getFloatValue == null)
					cb_getFloatValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFloatValue);
				return cb_getFloatValue;
			}

			static float n_GetFloatValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nineoldandroids.Animation.Keyframe.FloatKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.FloatKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FloatValue;
			}
#pragma warning restore 0169

			static IntPtr id_getFloatValue;
			public virtual unsafe float FloatValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.FloatKeyframe']/method[@name='getFloatValue' and count(parameter)=0]"
				[Register ("getFloatValue", "()F", "GetGetFloatValueHandler")]
				get {
					if (id_getFloatValue == IntPtr.Zero)
						id_getFloatValue = JNIEnv.GetMethodID (class_ref, "getFloatValue", "()F");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallFloatMethod  (Handle, id_getFloatValue);
						else
							return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFloatValue", "()F"));
					} finally {
					}
				}
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
				return cb_getValue;
			}

			static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nineoldandroids.Animation.Keyframe.FloatKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.FloatKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Value);
			}
#pragma warning restore 0169

			static Delegate cb_setValue_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetValue_Ljava_lang_Object_Handler ()
			{
				if (cb_setValue_Ljava_lang_Object_ == null)
					cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_Object_);
				return cb_setValue_Ljava_lang_Object_;
			}

			static void n_SetValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.Keyframe.FloatKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.FloatKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Value = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getValue;
			static IntPtr id_setValue_Ljava_lang_Object_;
			public override unsafe global::Java.Lang.Object Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.FloatKeyframe']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Object;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.FloatKeyframe']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
				[Register ("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler")]
				set {
					if (id_setValue_Ljava_lang_Object_ == IntPtr.Zero)
						id_setValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_Object_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/Object;)V"), __args);
					} finally {
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
				global::Com.Nineoldandroids.Animation.Keyframe.FloatKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.FloatKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Clone ());
			}
#pragma warning restore 0169

			static IntPtr id_clone;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.FloatKeyframe']/method[@name='clone' and count(parameter)=0]"
			[Register ("clone", "()Lcom/nineoldandroids/animation/Keyframe;", "GetCloneHandler")]
			public override unsafe global::Com.Nineoldandroids.Animation.Keyframe Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/nineoldandroids/animation/Keyframe;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/nineoldandroids/animation/Keyframe;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.IntKeyframe']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/Keyframe$IntKeyframe", DoNotGenerateAcw=true)]
		public partial class IntKeyframe : global::Com.Nineoldandroids.Animation.Keyframe {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/Keyframe$IntKeyframe", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IntKeyframe); }
			}

			protected IntKeyframe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getIntValue;
#pragma warning disable 0169
			static Delegate GetGetIntValueHandler ()
			{
				if (cb_getIntValue == null)
					cb_getIntValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIntValue);
				return cb_getIntValue;
			}

			static int n_GetIntValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nineoldandroids.Animation.Keyframe.IntKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.IntKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IntValue;
			}
#pragma warning restore 0169

			static IntPtr id_getIntValue;
			public virtual unsafe int IntValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.IntKeyframe']/method[@name='getIntValue' and count(parameter)=0]"
				[Register ("getIntValue", "()I", "GetGetIntValueHandler")]
				get {
					if (id_getIntValue == IntPtr.Zero)
						id_getIntValue = JNIEnv.GetMethodID (class_ref, "getIntValue", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getIntValue);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntValue", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
				return cb_getValue;
			}

			static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nineoldandroids.Animation.Keyframe.IntKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.IntKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Value);
			}
#pragma warning restore 0169

			static Delegate cb_setValue_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetValue_Ljava_lang_Object_Handler ()
			{
				if (cb_setValue_Ljava_lang_Object_ == null)
					cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_Object_);
				return cb_setValue_Ljava_lang_Object_;
			}

			static void n_SetValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.Keyframe.IntKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.IntKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Value = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getValue;
			static IntPtr id_setValue_Ljava_lang_Object_;
			public override unsafe global::Java.Lang.Object Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.IntKeyframe']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Object;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.IntKeyframe']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
				[Register ("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler")]
				set {
					if (id_setValue_Ljava_lang_Object_ == IntPtr.Zero)
						id_setValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_Object_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/Object;)V"), __args);
					} finally {
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
				global::Com.Nineoldandroids.Animation.Keyframe.IntKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.IntKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Clone ());
			}
#pragma warning restore 0169

			static IntPtr id_clone;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.IntKeyframe']/method[@name='clone' and count(parameter)=0]"
			[Register ("clone", "()Lcom/nineoldandroids/animation/Keyframe;", "GetCloneHandler")]
			public override unsafe global::Com.Nineoldandroids.Animation.Keyframe Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/nineoldandroids/animation/Keyframe;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/nineoldandroids/animation/Keyframe;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.ObjectKeyframe']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/Keyframe$ObjectKeyframe", DoNotGenerateAcw=true)]
		public partial class ObjectKeyframe : global::Com.Nineoldandroids.Animation.Keyframe {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nineoldandroids/animation/Keyframe$ObjectKeyframe", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ObjectKeyframe); }
			}

			protected ObjectKeyframe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
				return cb_getValue;
			}

			static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nineoldandroids.Animation.Keyframe.ObjectKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.ObjectKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Value);
			}
#pragma warning restore 0169

			static Delegate cb_setValue_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetValue_Ljava_lang_Object_Handler ()
			{
				if (cb_setValue_Ljava_lang_Object_ == null)
					cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_Object_);
				return cb_setValue_Ljava_lang_Object_;
			}

			static void n_SetValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.Keyframe.ObjectKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.ObjectKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Value = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getValue;
			static IntPtr id_setValue_Ljava_lang_Object_;
			public override unsafe global::Java.Lang.Object Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.ObjectKeyframe']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Object;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.ObjectKeyframe']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
				[Register ("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler")]
				set {
					if (id_setValue_Ljava_lang_Object_ == IntPtr.Zero)
						id_setValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_Object_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/Object;)V"), __args);
					} finally {
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
				global::Com.Nineoldandroids.Animation.Keyframe.ObjectKeyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe.ObjectKeyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Clone ());
			}
#pragma warning restore 0169

			static IntPtr id_clone;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe.ObjectKeyframe']/method[@name='clone' and count(parameter)=0]"
			[Register ("clone", "()Lcom/nineoldandroids/animation/Keyframe;", "GetCloneHandler")]
			public override unsafe global::Com.Nineoldandroids.Animation.Keyframe Clone ()
			{
				if (id_clone == IntPtr.Zero)
					id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/nineoldandroids/animation/Keyframe;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/nineoldandroids/animation/Keyframe;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/Keyframe", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Keyframe); }
		}

		protected Keyframe (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/constructor[@name='Keyframe' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Keyframe ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Keyframe)) {
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

		static Delegate cb_getFraction;
#pragma warning disable 0169
		static Delegate GetGetFractionHandler ()
		{
			if (cb_getFraction == null)
				cb_getFraction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFraction);
			return cb_getFraction;
		}

		static float n_GetFraction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Keyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Fraction;
		}
#pragma warning restore 0169

		static Delegate cb_setFraction_F;
#pragma warning disable 0169
		static Delegate GetSetFraction_FHandler ()
		{
			if (cb_setFraction_F == null)
				cb_setFraction_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFraction_F);
			return cb_setFraction_F;
		}

		static void n_SetFraction_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nineoldandroids.Animation.Keyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Fraction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFraction;
		static IntPtr id_setFraction_F;
		public virtual unsafe float Fraction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='getFraction' and count(parameter)=0]"
			[Register ("getFraction", "()F", "GetGetFractionHandler")]
			get {
				if (id_getFraction == IntPtr.Zero)
					id_getFraction = JNIEnv.GetMethodID (class_ref, "getFraction", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getFraction);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFraction", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='setFraction' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFraction", "(F)V", "GetSetFraction_FHandler")]
			set {
				if (id_setFraction_F == IntPtr.Zero)
					id_setFraction_F = JNIEnv.GetMethodID (class_ref, "setFraction", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFraction_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFraction", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_hasValue;
#pragma warning disable 0169
		static Delegate GetHasValueHandler ()
		{
			if (cb_hasValue == null)
				cb_hasValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasValue);
			return cb_hasValue;
		}

		static bool n_HasValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Keyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasValue;
		}
#pragma warning restore 0169

		static IntPtr id_hasValue;
		public virtual unsafe bool HasValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='hasValue' and count(parameter)=0]"
			[Register ("hasValue", "()Z", "GetHasValueHandler")]
			get {
				if (id_hasValue == IntPtr.Zero)
					id_hasValue = JNIEnv.GetMethodID (class_ref, "hasValue", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasValue);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasValue", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getInterpolator;
#pragma warning disable 0169
		static Delegate GetGetInterpolatorHandler ()
		{
			if (cb_getInterpolator == null)
				cb_getInterpolator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterpolator);
			return cb_getInterpolator;
		}

		static IntPtr n_GetInterpolator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Keyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Interpolator);
		}
#pragma warning restore 0169

		static Delegate cb_setInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setInterpolator_Landroid_view_animation_Interpolator_;
		}

		static void n_SetInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.Keyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Interpolator = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInterpolator;
		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		public virtual unsafe global::Android.Views.Animations.IInterpolator Interpolator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='getInterpolator' and count(parameter)=0]"
			[Register ("getInterpolator", "()Landroid/view/animation/Interpolator;", "GetGetInterpolatorHandler")]
			get {
				if (id_getInterpolator == IntPtr.Zero)
					id_getInterpolator = JNIEnv.GetMethodID (class_ref, "getInterpolator", "()Landroid/view/animation/Interpolator;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (JNIEnv.CallObjectMethod  (Handle, id_getInterpolator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterpolator", "()Landroid/view/animation/Interpolator;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
			[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
			set {
				if (id_setInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
					id_setInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setInterpolator_Landroid_view_animation_Interpolator_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Keyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Java.Lang.Class Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/Class;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/Class;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.Keyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_Object_Handler ()
		{
			if (cb_setValue_Ljava_lang_Object_ == null)
				cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_Object_);
			return cb_setValue_Ljava_lang_Object_;
		}

		static void n_SetValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.Keyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler")] set;
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
			global::Com.Nineoldandroids.Animation.Keyframe __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/nineoldandroids/animation/Keyframe;", "GetCloneHandler")]
		public abstract global::Com.Nineoldandroids.Animation.Keyframe Clone ();

		static IntPtr id_ofFloat_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='ofFloat' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("ofFloat", "(F)Lcom/nineoldandroids/animation/Keyframe;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.Keyframe OfFloat (float p0)
		{
			if (id_ofFloat_F == IntPtr.Zero)
				id_ofFloat_F = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(F)Lcom/nineoldandroids/animation/Keyframe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ofFloat_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='ofFloat' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("ofFloat", "(FF)Lcom/nineoldandroids/animation/Keyframe;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.Keyframe OfFloat (float p0, float p1)
		{
			if (id_ofFloat_FF == IntPtr.Zero)
				id_ofFloat_FF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "(FF)Lcom/nineoldandroids/animation/Keyframe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_FF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ofInt_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='ofInt' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("ofInt", "(F)Lcom/nineoldandroids/animation/Keyframe;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.Keyframe OfInt (float p0)
		{
			if (id_ofInt_F == IntPtr.Zero)
				id_ofInt_F = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(F)Lcom/nineoldandroids/animation/Keyframe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ofInt_FI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='ofInt' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("ofInt", "(FI)Lcom/nineoldandroids/animation/Keyframe;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.Keyframe OfInt (float p0, int p1)
		{
			if (id_ofInt_FI == IntPtr.Zero)
				id_ofInt_FI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "(FI)Lcom/nineoldandroids/animation/Keyframe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_FI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ofObject_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='ofObject' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("ofObject", "(F)Lcom/nineoldandroids/animation/Keyframe;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.Keyframe OfObject (float p0)
		{
			if (id_ofObject_F == IntPtr.Zero)
				id_ofObject_F = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(F)Lcom/nineoldandroids/animation/Keyframe;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ofObject_FLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='ofObject' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='java.lang.Object']]"
		[Register ("ofObject", "(FLjava/lang/Object;)Lcom/nineoldandroids/animation/Keyframe;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.Keyframe OfObject (float p0, global::Java.Lang.Object p1)
		{
			if (id_ofObject_FLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_FLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(FLjava/lang/Object;)Lcom/nineoldandroids/animation/Keyframe;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Nineoldandroids.Animation.Keyframe __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_FLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/nineoldandroids/animation/Keyframe", DoNotGenerateAcw=true)]
	internal partial class KeyframeInvoker : Keyframe {

		public KeyframeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyframeInvoker); }
		}

		static IntPtr id_getValue;
		static IntPtr id_setValue_Ljava_lang_Object_;
		public override unsafe global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler")]
			set {
				if (id_setValue_Ljava_lang_Object_ == IntPtr.Zero)
					id_setValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_Object_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='Keyframe']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/nineoldandroids/animation/Keyframe;", "GetCloneHandler")]
		public override unsafe global::Com.Nineoldandroids.Animation.Keyframe Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/nineoldandroids/animation/Keyframe;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Keyframe> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
