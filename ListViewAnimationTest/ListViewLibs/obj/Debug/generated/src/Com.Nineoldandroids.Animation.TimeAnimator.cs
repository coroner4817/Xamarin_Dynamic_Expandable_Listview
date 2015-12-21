using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='TimeAnimator']"
	[global::Android.Runtime.Register ("com/nineoldandroids/animation/TimeAnimator", DoNotGenerateAcw=true)]
	public partial class TimeAnimator : global::Com.Nineoldandroids.Animation.ValueAnimator {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nineoldandroids.animation']/interface[@name='TimeAnimator.TimeListener']"
		[Register ("com/nineoldandroids/animation/TimeAnimator$TimeListener", "", "Com.Nineoldandroids.Animation.TimeAnimator/ITimeListenerInvoker")]
		public partial interface ITimeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/interface[@name='TimeAnimator.TimeListener']/method[@name='onTimeUpdate' and count(parameter)=3 and parameter[1][@type='com.nineoldandroids.animation.TimeAnimator'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
			[Register ("onTimeUpdate", "(Lcom/nineoldandroids/animation/TimeAnimator;JJ)V", "GetOnTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJHandler:Com.Nineoldandroids.Animation.TimeAnimator/ITimeListenerInvoker, ListViewLibs")]
			void OnTimeUpdate (global::Com.Nineoldandroids.Animation.TimeAnimator p0, long p1, long p2);

		}

		[global::Android.Runtime.Register ("com/nineoldandroids/animation/TimeAnimator$TimeListener", DoNotGenerateAcw=true)]
		internal class ITimeListenerInvoker : global::Java.Lang.Object, ITimeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nineoldandroids/animation/TimeAnimator$TimeListener");
			IntPtr class_ref;

			public static ITimeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITimeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nineoldandroids.animation.TimeAnimator.TimeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITimeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ITimeListenerInvoker); }
			}

			static Delegate cb_onTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ;
#pragma warning disable 0169
			static Delegate GetOnTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJHandler ()
			{
				if (cb_onTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ == null)
					cb_onTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long>) n_OnTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ);
				return cb_onTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ;
			}

			static void n_OnTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
			{
				global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.TimeAnimator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.TimeAnimator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTimeUpdate (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ;
			public unsafe void OnTimeUpdate (global::Com.Nineoldandroids.Animation.TimeAnimator p0, long p1, long p2)
			{
				if (id_onTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ == IntPtr.Zero)
					id_onTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ = JNIEnv.GetMethodID (class_ref, "onTimeUpdate", "(Lcom/nineoldandroids/animation/TimeAnimator;JJ)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onTimeUpdate_Lcom_nineoldandroids_animation_TimeAnimator_JJ, __args);
			}

		}

		public partial class TimeEventArgs : global::System.EventArgs {

			public TimeEventArgs (global::Com.Nineoldandroids.Animation.TimeAnimator p0, long p1, long p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Nineoldandroids.Animation.TimeAnimator p0;
			public global::Com.Nineoldandroids.Animation.TimeAnimator P0 {
				get { return p0; }
			}

			long p1;
			public long P1 {
				get { return p1; }
			}

			long p2;
			public long P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/nineoldandroids/animation/TimeAnimator_TimeListenerImplementor")]
		internal sealed partial class ITimeListenerImplementor : global::Java.Lang.Object, ITimeListener {

			object sender;

			public ITimeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nineoldandroids/animation/TimeAnimator_TimeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TimeEventArgs> Handler;
#pragma warning restore 0649

			public void OnTimeUpdate (global::Com.Nineoldandroids.Animation.TimeAnimator p0, long p1, long p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new TimeEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (ITimeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/animation/TimeAnimator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeAnimator); }
		}

		protected TimeAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='TimeAnimator']/constructor[@name='TimeAnimator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TimeAnimator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TimeAnimator)) {
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

		static Delegate cb_setTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_;
#pragma warning disable 0169
		static Delegate GetSetTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_Handler ()
		{
			if (cb_setTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_ == null)
				cb_setTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_);
			return cb_setTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_;
		}

		static void n_SetTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nineoldandroids.Animation.TimeAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.TimeAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListener p0 = (global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListener)global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.animation']/class[@name='TimeAnimator']/method[@name='setTimeListener' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.TimeAnimator.TimeListener']]"
		[Register ("setTimeListener", "(Lcom/nineoldandroids/animation/TimeAnimator$TimeListener;)V", "GetSetTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_Handler")]
		public virtual unsafe void SetTimeListener (global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListener p0)
		{
			if (id_setTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_ == IntPtr.Zero)
				id_setTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_ = JNIEnv.GetMethodID (class_ref, "setTimeListener", "(Lcom/nineoldandroids/animation/TimeAnimator$TimeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimeListener_Lcom_nineoldandroids_animation_TimeAnimator_TimeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeListener", "(Lcom/nineoldandroids/animation/TimeAnimator$TimeListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Nineoldandroids.Animation.TimeAnimator.ITimeListener"
		public event EventHandler<global::Com.Nineoldandroids.Animation.TimeAnimator.TimeEventArgs> Time {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListener, global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListenerImplementor>(
						ref weak_implementor_SetTimeListener,
						__CreateITimeListenerImplementor,
						SetTimeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListener, global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListenerImplementor>(
						ref weak_implementor_SetTimeListener,
						global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListenerImplementor.__IsEmpty,
						__v => SetTimeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetTimeListener;

		global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListenerImplementor __CreateITimeListenerImplementor ()
		{
			return new global::Com.Nineoldandroids.Animation.TimeAnimator.ITimeListenerImplementor (this);
		}
#endregion
	}
}
