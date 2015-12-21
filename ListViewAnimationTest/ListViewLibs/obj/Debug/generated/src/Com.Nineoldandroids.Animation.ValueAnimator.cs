using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/ValueAnimator", DoNotGenerateAcw=true)]
	public partial class ValueAnimator : global::Com.Nineoldandroids.Animation.Animator {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/field[@name='INFINITE']"
		[Register ("INFINITE")]
		public const int Infinite = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/field[@name='RESTART']"
		[Register ("RESTART")]
		public const int Restart = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator.AnimationHandler']"
		[global::Android.Runtime.Register ("com/nineoldandroids/animation/ValueAnimator$AnimationHandler", DoNotGenerateAcw=true)]
		public partial class AnimationHandler : global::Android.OS.Handler {

			protected AnimationHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nineoldandroids.animation']/interface[@name='ValueAnimator.AnimatorUpdateListener']"
		[Register ("com/nineoldandroids/animation/ValueAnimator$AnimatorUpdateListener", "", "Com.Nineoldandroids.Animation.ValueAnimator/IAnimatorUpdateListenerInvoker")]
		public partial interface IAnimatorUpdateListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/interface[@name='ValueAnimator.AnimatorUpdateListener']/method[@name='onAnimationUpdate' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.ValueAnimator']]"
			[Register ("onAnimationUpdate", "(Lcom/nineoldandroids/animation/ValueAnimator;)V", "GetOnAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_Handler:Com.Nineoldandroids.Animation.ValueAnimator/IAnimatorUpdateListenerInvoker, ListViewLibs")]
			void OnAnimationUpdate (global::Com.Nineoldandroids.Animation.ValueAnimator p0);

		}

		[global::Android.Runtime.Register ("com/nineoldandroids/animation/ValueAnimator$AnimatorUpdateListener", DoNotGenerateAcw=true)]
		internal class IAnimatorUpdateListenerInvoker : global::Java.Lang.Object, IAnimatorUpdateListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nineoldandroids/animation/ValueAnimator$AnimatorUpdateListener");
			IntPtr class_ref;

			public static IAnimatorUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAnimatorUpdateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nineoldandroids.animation.ValueAnimator.AnimatorUpdateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAnimatorUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAnimatorUpdateListenerInvoker); }
			}

			static Delegate cb_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_;
#pragma warning disable 0169
			static Delegate GetOnAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_Handler ()
			{
				if (cb_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_ == null)
					cb_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_);
				return cb_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_;
			}

			static void n_OnAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.ValueAnimator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationUpdate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_;
			public unsafe void OnAnimationUpdate (global::Com.Nineoldandroids.Animation.ValueAnimator p0)
			{
				if (id_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_ == IntPtr.Zero)
					id_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_ = JNIEnv.GetMethodID (class_ref, "onAnimationUpdate", "(Lcom/nineoldandroids/animation/ValueAnimator;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_, __args);
			}

		}

		public partial class AnimatorUpdateEventArgs : global::System.EventArgs {

			public AnimatorUpdateEventArgs (global::Com.Nineoldandroids.Animation.ValueAnimator p0)
			{
				this.p0 = p0;
			}

			global::Com.Nineoldandroids.Animation.ValueAnimator p0;
			public global::Com.Nineoldandroids.Animation.ValueAnimator P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/nineoldandroids/animation/ValueAnimator_AnimatorUpdateListenerImplementor")]
		internal sealed partial class IAnimatorUpdateListenerImplementor : global::Java.Lang.Object, IAnimatorUpdateListener {

			object sender;

			public IAnimatorUpdateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nineoldandroids/animation/ValueAnimator_AnimatorUpdateListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AnimatorUpdateEventArgs> Handler;
#pragma warning restore 0649

			public void OnAnimationUpdate (global::Com.Nineoldandroids.Animation.ValueAnimator p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AnimatorUpdateEventArgs (p0));
			}

			internal static bool __IsEmpty (IAnimatorUpdateListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/ValueAnimator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ValueAnimator); }
		}

		protected ValueAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/constructor[@name='ValueAnimator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ValueAnimator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ValueAnimator)) {
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

		static Delegate cb_getAnimatedFraction;
#pragma warning disable 0169
		static Delegate GetGetAnimatedFractionHandler ()
		{
			if (cb_getAnimatedFraction == null)
				cb_getAnimatedFraction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAnimatedFraction);
			return cb_getAnimatedFraction;
		}

		static float n_GetAnimatedFraction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnimatedFraction;
		}
#pragma warning restore 0169

		static IntPtr id_getAnimatedFraction;
		public virtual unsafe float AnimatedFraction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getAnimatedFraction' and count(parameter)=0]"
			[Register ("getAnimatedFraction", "()F", "GetGetAnimatedFractionHandler")]
			get {
				if (id_getAnimatedFraction == IntPtr.Zero)
					id_getAnimatedFraction = JNIEnv.GetMethodID (class_ref, "getAnimatedFraction", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getAnimatedFraction);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnimatedFraction", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getAnimatedValue;
#pragma warning disable 0169
		static Delegate GetGetAnimatedValueHandler ()
		{
			if (cb_getAnimatedValue == null)
				cb_getAnimatedValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnimatedValue);
			return cb_getAnimatedValue;
		}

		static IntPtr n_GetAnimatedValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimatedValue);
		}
#pragma warning restore 0169

		static IntPtr id_getAnimatedValue;
		public virtual unsafe global::Java.Lang.Object AnimatedValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getAnimatedValue' and count(parameter)=0]"
			[Register ("getAnimatedValue", "()Ljava/lang/Object;", "GetGetAnimatedValueHandler")]
			get {
				if (id_getAnimatedValue == IntPtr.Zero)
					id_getAnimatedValue = JNIEnv.GetMethodID (class_ref, "getAnimatedValue", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getAnimatedValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnimatedValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCurrentAnimationsCount;
		public static unsafe int CurrentAnimationsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getCurrentAnimationsCount' and count(parameter)=0]"
			[Register ("getCurrentAnimationsCount", "()I", "GetGetCurrentAnimationsCountHandler")]
			get {
				if (id_getCurrentAnimationsCount == IntPtr.Zero)
					id_getCurrentAnimationsCount = JNIEnv.GetStaticMethodID (class_ref, "getCurrentAnimationsCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getCurrentAnimationsCount);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentPlayTime;
#pragma warning disable 0169
		static Delegate GetGetCurrentPlayTimeHandler ()
		{
			if (cb_getCurrentPlayTime == null)
				cb_getCurrentPlayTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurrentPlayTime);
			return cb_getCurrentPlayTime;
		}

		static long n_GetCurrentPlayTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPlayTime;
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentPlayTime_J;
#pragma warning disable 0169
		static Delegate GetSetCurrentPlayTime_JHandler ()
		{
			if (cb_setCurrentPlayTime_J == null)
				cb_setCurrentPlayTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCurrentPlayTime_J);
			return cb_setCurrentPlayTime_J;
		}

		static void n_SetCurrentPlayTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentPlayTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPlayTime;
		static IntPtr id_setCurrentPlayTime_J;
		public virtual unsafe long CurrentPlayTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getCurrentPlayTime' and count(parameter)=0]"
			[Register ("getCurrentPlayTime", "()J", "GetGetCurrentPlayTimeHandler")]
			get {
				if (id_getCurrentPlayTime == IntPtr.Zero)
					id_getCurrentPlayTime = JNIEnv.GetMethodID (class_ref, "getCurrentPlayTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getCurrentPlayTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPlayTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setCurrentPlayTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCurrentPlayTime", "(J)V", "GetSetCurrentPlayTime_JHandler")]
			set {
				if (id_setCurrentPlayTime_J == IntPtr.Zero)
					id_setCurrentPlayTime_J = JNIEnv.GetMethodID (class_ref, "setCurrentPlayTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCurrentPlayTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentPlayTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public override unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
				} finally {
				}
			}
		}

		static IntPtr id_getFrameDelay;
		static IntPtr id_setFrameDelay_J;
		public static unsafe long FrameDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getFrameDelay' and count(parameter)=0]"
			[Register ("getFrameDelay", "()J", "GetGetFrameDelayHandler")]
			get {
				if (id_getFrameDelay == IntPtr.Zero)
					id_getFrameDelay = JNIEnv.GetStaticMethodID (class_ref, "getFrameDelay", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getFrameDelay);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setFrameDelay' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setFrameDelay", "(J)V", "GetSetFrameDelay_JHandler")]
			set {
				if (id_setFrameDelay_J == IntPtr.Zero)
					id_setFrameDelay_J = JNIEnv.GetStaticMethodID (class_ref, "setFrameDelay", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setFrameDelay_J, __args);
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
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Interpolator);
		}
#pragma warning restore 0169

		static IntPtr id_getInterpolator;
		public virtual unsafe global::Android.Views.Animations.IInterpolator Interpolator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getInterpolator' and count(parameter)=0]"
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
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public override unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRunning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getRepeatCount;
#pragma warning disable 0169
		static Delegate GetGetRepeatCountHandler ()
		{
			if (cb_getRepeatCount == null)
				cb_getRepeatCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRepeatCount);
			return cb_getRepeatCount;
		}

		static int n_GetRepeatCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RepeatCount;
		}
#pragma warning restore 0169

		static Delegate cb_setRepeatCount_I;
#pragma warning disable 0169
		static Delegate GetSetRepeatCount_IHandler ()
		{
			if (cb_setRepeatCount_I == null)
				cb_setRepeatCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRepeatCount_I);
			return cb_setRepeatCount_I;
		}

		static void n_SetRepeatCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RepeatCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRepeatCount;
		static IntPtr id_setRepeatCount_I;
		public virtual unsafe int RepeatCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getRepeatCount' and count(parameter)=0]"
			[Register ("getRepeatCount", "()I", "GetGetRepeatCountHandler")]
			get {
				if (id_getRepeatCount == IntPtr.Zero)
					id_getRepeatCount = JNIEnv.GetMethodID (class_ref, "getRepeatCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRepeatCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRepeatCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setRepeatCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRepeatCount", "(I)V", "GetSetRepeatCount_IHandler")]
			set {
				if (id_setRepeatCount_I == IntPtr.Zero)
					id_setRepeatCount_I = JNIEnv.GetMethodID (class_ref, "setRepeatCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRepeatCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRepeatCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRepeatMode;
#pragma warning disable 0169
		static Delegate GetGetRepeatModeHandler ()
		{
			if (cb_getRepeatMode == null)
				cb_getRepeatMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRepeatMode);
			return cb_getRepeatMode;
		}

		static int n_GetRepeatMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RepeatMode;
		}
#pragma warning restore 0169

		static Delegate cb_setRepeatMode_I;
#pragma warning disable 0169
		static Delegate GetSetRepeatMode_IHandler ()
		{
			if (cb_setRepeatMode_I == null)
				cb_setRepeatMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRepeatMode_I);
			return cb_setRepeatMode_I;
		}

		static void n_SetRepeatMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RepeatMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRepeatMode;
		static IntPtr id_setRepeatMode_I;
		public virtual unsafe int RepeatMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getRepeatMode' and count(parameter)=0]"
			[Register ("getRepeatMode", "()I", "GetGetRepeatModeHandler")]
			get {
				if (id_getRepeatMode == IntPtr.Zero)
					id_getRepeatMode = JNIEnv.GetMethodID (class_ref, "getRepeatMode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRepeatMode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRepeatMode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setRepeatMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRepeatMode", "(I)V", "GetSetRepeatMode_IHandler")]
			set {
				if (id_setRepeatMode_I == IntPtr.Zero)
					id_setRepeatMode_I = JNIEnv.GetMethodID (class_ref, "setRepeatMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRepeatMode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRepeatMode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStartDelay;
#pragma warning disable 0169
		static Delegate GetGetStartDelayHandler ()
		{
			if (cb_getStartDelay == null)
				cb_getStartDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartDelay);
			return cb_getStartDelay;
		}

		static long n_GetStartDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartDelay;
		}
#pragma warning restore 0169

		static Delegate cb_setStartDelay_J;
#pragma warning disable 0169
		static Delegate GetSetStartDelay_JHandler ()
		{
			if (cb_setStartDelay_J == null)
				cb_setStartDelay_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetStartDelay_J);
			return cb_setStartDelay_J;
		}

		static void n_SetStartDelay_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDelay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStartDelay;
		static IntPtr id_setStartDelay_J;
		public override unsafe long StartDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getStartDelay' and count(parameter)=0]"
			[Register ("getStartDelay", "()J", "GetGetStartDelayHandler")]
			get {
				if (id_getStartDelay == IntPtr.Zero)
					id_getStartDelay = JNIEnv.GetMethodID (class_ref, "getStartDelay", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getStartDelay);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartDelay", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setStartDelay' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setStartDelay", "(J)V", "GetSetStartDelay_JHandler")]
			set {
				if (id_setStartDelay_J == IntPtr.Zero)
					id_setStartDelay_J = JNIEnv.GetMethodID (class_ref, "setStartDelay", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStartDelay_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartDelay", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_;
#pragma warning disable 0169
		static Delegate GetAddUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_Handler ()
		{
			if (cb_addUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ == null)
				cb_addUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_);
			return cb_addUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_;
		}

		static void n_AddUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener p0 = (global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddUpdateListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='addUpdateListener' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.ValueAnimator.AnimatorUpdateListener']]"
		[Register ("addUpdateListener", "(Lcom/nineoldandroids/animation/ValueAnimator$AnimatorUpdateListener;)V", "GetAddUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_Handler")]
		public virtual unsafe void AddUpdateListener (global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener p0)
		{
			if (id_addUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ == IntPtr.Zero)
				id_addUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ = JNIEnv.GetMethodID (class_ref, "addUpdateListener", "(Lcom/nineoldandroids/animation/ValueAnimator$AnimatorUpdateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addUpdateListener", "(Lcom/nineoldandroids/animation/ValueAnimator$AnimatorUpdateListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_clearAllAnimations;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='clearAllAnimations' and count(parameter)=0]"
		[Register ("clearAllAnimations", "()V", "")]
		public static unsafe void ClearAllAnimations ()
		{
			if (id_clearAllAnimations == IntPtr.Zero)
				id_clearAllAnimations = JNIEnv.GetStaticMethodID (class_ref, "clearAllAnimations", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearAllAnimations);
			} finally {
			}
		}

		static Delegate cb_getAnimatedValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAnimatedValue_Ljava_lang_String_Handler ()
		{
			if (cb_getAnimatedValue_Ljava_lang_String_ == null)
				cb_getAnimatedValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAnimatedValue_Ljava_lang_String_);
			return cb_getAnimatedValue_Ljava_lang_String_;
		}

		static IntPtr n_GetAnimatedValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAnimatedValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAnimatedValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getAnimatedValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAnimatedValue", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetAnimatedValue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetAnimatedValue (string p0)
		{
			if (id_getAnimatedValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getAnimatedValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAnimatedValue", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getAnimatedValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnimatedValue", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getValues;
#pragma warning disable 0169
		static Delegate GetGetValuesHandler ()
		{
			if (cb_getValues == null)
				cb_getValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValues);
			return cb_getValues;
		}

		static IntPtr n_GetValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='getValues' and count(parameter)=0]"
		[Register ("getValues", "()[Lcom/nineoldandroids/animation/PropertyValuesHolder;", "GetGetValuesHandler")]
		public virtual unsafe global::Com.Nineoldandroids.Animation.PropertyValuesHolder[] GetValues ()
		{
			if (id_getValues == IntPtr.Zero)
				id_getValues = JNIEnv.GetMethodID (class_ref, "getValues", "()[Lcom/nineoldandroids/animation/PropertyValuesHolder;");
			try {

				if (GetType () == ThresholdType)
					return (global::Com.Nineoldandroids.Animation.PropertyValuesHolder[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getValues), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nineoldandroids.Animation.PropertyValuesHolder));
				else
					return (global::Com.Nineoldandroids.Animation.PropertyValuesHolder[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValues", "()[Lcom/nineoldandroids/animation/PropertyValuesHolder;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nineoldandroids.Animation.PropertyValuesHolder));
			} finally {
			}
		}

		static IntPtr id_ofFloat_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='ofFloat' and count(parameter)=1 and parameter[1][@type='float...']]"
		[Register ("ofFloat", "([F)Lcom/nineoldandroids/animation/ValueAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ValueAnimator OfFloat (params  float[] p0)
		{
			if (id_ofFloat_arrayF == IntPtr.Zero)
				id_ofFloat_arrayF = JNIEnv.GetStaticMethodID (class_ref, "ofFloat", "([F)Lcom/nineoldandroids/animation/ValueAnimator;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Nineoldandroids.Animation.ValueAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofFloat_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ofInt_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='ofInt' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("ofInt", "([I)Lcom/nineoldandroids/animation/ValueAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ValueAnimator OfInt (params  int[] p0)
		{
			if (id_ofInt_arrayI == IntPtr.Zero)
				id_ofInt_arrayI = JNIEnv.GetStaticMethodID (class_ref, "ofInt", "([I)Lcom/nineoldandroids/animation/ValueAnimator;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Nineoldandroids.Animation.ValueAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofInt_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ofObject_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='ofObject' and count(parameter)=2 and parameter[1][@type='com.nineoldandroids.animation.TypeEvaluator'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("ofObject", "(Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ValueAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ValueAnimator OfObject (global::Com.Nineoldandroids.Animation.ITypeEvaluator p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_ofObject_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_ofObject_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "ofObject", "(Lcom/nineoldandroids/animation/TypeEvaluator;[Ljava/lang/Object;)Lcom/nineoldandroids/animation/ValueAnimator;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Nineoldandroids.Animation.ValueAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofObject_Lcom_nineoldandroids_animation_TypeEvaluator_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ofPropertyValuesHolder_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='ofPropertyValuesHolder' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.PropertyValuesHolder...']]"
		[Register ("ofPropertyValuesHolder", "([Lcom/nineoldandroids/animation/PropertyValuesHolder;)Lcom/nineoldandroids/animation/ValueAnimator;", "")]
		public static unsafe global::Com.Nineoldandroids.Animation.ValueAnimator OfPropertyValuesHolder (params global:: Com.Nineoldandroids.Animation.PropertyValuesHolder[] p0)
		{
			if (id_ofPropertyValuesHolder_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ == IntPtr.Zero)
				id_ofPropertyValuesHolder_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ = JNIEnv.GetStaticMethodID (class_ref, "ofPropertyValuesHolder", "([Lcom/nineoldandroids/animation/PropertyValuesHolder;)Lcom/nineoldandroids/animation/ValueAnimator;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Nineoldandroids.Animation.ValueAnimator __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofPropertyValuesHolder_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_removeAllUpdateListeners;
#pragma warning disable 0169
		static Delegate GetRemoveAllUpdateListenersHandler ()
		{
			if (cb_removeAllUpdateListeners == null)
				cb_removeAllUpdateListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllUpdateListeners);
			return cb_removeAllUpdateListeners;
		}

		static void n_RemoveAllUpdateListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllUpdateListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllUpdateListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='removeAllUpdateListeners' and count(parameter)=0]"
		[Register ("removeAllUpdateListeners", "()V", "GetRemoveAllUpdateListenersHandler")]
		public virtual unsafe void RemoveAllUpdateListeners ()
		{
			if (id_removeAllUpdateListeners == IntPtr.Zero)
				id_removeAllUpdateListeners = JNIEnv.GetMethodID (class_ref, "removeAllUpdateListeners", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeAllUpdateListeners);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllUpdateListeners", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_;
#pragma warning disable 0169
		static Delegate GetRemoveUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_Handler ()
		{
			if (cb_removeUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ == null)
				cb_removeUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_);
			return cb_removeUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_;
		}

		static void n_RemoveUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener p0 = (global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveUpdateListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='removeUpdateListener' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.ValueAnimator.AnimatorUpdateListener']]"
		[Register ("removeUpdateListener", "(Lcom/nineoldandroids/animation/ValueAnimator$AnimatorUpdateListener;)V", "GetRemoveUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_Handler")]
		public virtual unsafe void RemoveUpdateListener (global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener p0)
		{
			if (id_removeUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ == IntPtr.Zero)
				id_removeUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_ = JNIEnv.GetMethodID (class_ref, "removeUpdateListener", "(Lcom/nineoldandroids/animation/ValueAnimator$AnimatorUpdateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeUpdateListener_Lcom_nineoldandroids_animation_ValueAnimator_AnimatorUpdateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeUpdateListener", "(Lcom/nineoldandroids/animation/ValueAnimator$AnimatorUpdateListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_reverse;
#pragma warning disable 0169
		static Delegate GetReverseHandler ()
		{
			if (cb_reverse == null)
				cb_reverse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reverse);
			return cb_reverse;
		}

		static void n_Reverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reverse ();
		}
#pragma warning restore 0169

		static IntPtr id_reverse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='reverse' and count(parameter)=0]"
		[Register ("reverse", "()V", "GetReverseHandler")]
		public virtual unsafe void Reverse ()
		{
			if (id_reverse == IntPtr.Zero)
				id_reverse = JNIEnv.GetMethodID (class_ref, "reverse", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reverse);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reverse", "()V"));
			} finally {
			}
		}

		static Delegate cb_setDuration_J;
#pragma warning disable 0169
		static Delegate GetSetDuration_JHandler ()
		{
			if (cb_setDuration_J == null)
				cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDuration_J);
			return cb_setDuration_J;
		}

		static IntPtr n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDuration (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)Lcom/nineoldandroids/animation/Animator;", "GetSetDuration_JHandler")]
		public override unsafe global::Com.Nineoldandroids.Animation.Animator SetDuration (long p0)
		{
			if (id_setDuration_J == IntPtr.Zero)
				id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)Lcom/nineoldandroids/animation/Animator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallObjectMethod  (Handle, id_setDuration_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.Animator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(J)Lcom/nineoldandroids/animation/Animator;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.ITypeEvaluator p0 = (global::Com.Nineoldandroids.Animation.ITypeEvaluator)global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ITypeEvaluator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEvaluator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEvaluator_Lcom_nineoldandroids_animation_TypeEvaluator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setEvaluator' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.TypeEvaluator']]"
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
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetFloatValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFloatValues_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setFloatValues' and count(parameter)=1 and parameter[1][@type='float...']]"
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
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetIntValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIntValues_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setIntValues' and count(parameter)=1 and parameter[1][@type='int...']]"
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
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInterpolator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public override unsafe void SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			if (id_setInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
				id_setInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInterpolator_Landroid_view_animation_Interpolator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V"), __args);
			} finally {
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
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.SetObjectValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setObjectValues_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setObjectValues' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
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

		static Delegate cb_setValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_;
#pragma warning disable 0169
		static Delegate GetSetValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_Handler ()
		{
			if (cb_setValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ == null)
				cb_setValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_);
			return cb_setValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_;
		}

		static void n_SetValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.ValueAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.PropertyValuesHolder[] p0 = (global::Com.Nineoldandroids.Animation.PropertyValuesHolder[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Nineoldandroids.Animation.PropertyValuesHolder));
			__this.SetValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='ValueAnimator']/method[@name='setValues' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.PropertyValuesHolder...']]"
		[Register ("setValues", "([Lcom/nineoldandroids/animation/PropertyValuesHolder;)V", "GetSetValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_Handler")]
		public virtual unsafe void SetValues (params global:: Com.Nineoldandroids.Animation.PropertyValuesHolder[] p0)
		{
			if (id_setValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ == IntPtr.Zero)
				id_setValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_ = JNIEnv.GetMethodID (class_ref, "setValues", "([Lcom/nineoldandroids/animation/PropertyValuesHolder;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setValues_arrayLcom_nineoldandroids_animation_PropertyValuesHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValues", "([Lcom/nineoldandroids/animation/PropertyValuesHolder;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

#region "Event implementation for Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener"
		public event EventHandler<global::Com.Nineoldandroids.Animation.ValueAnimator.AnimatorUpdateEventArgs> Update {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener, global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						__CreateIAnimatorUpdateListenerImplementor,
						AddUpdateListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener, global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListenerImplementor>(
						ref weak_implementor_AddUpdateListener,
						global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListenerImplementor.__IsEmpty,
						RemoveUpdateListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddUpdateListener;

		global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListenerImplementor __CreateIAnimatorUpdateListenerImplementor ()
		{
			return new global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListenerImplementor (this);
		}
#endregion
	}
}
