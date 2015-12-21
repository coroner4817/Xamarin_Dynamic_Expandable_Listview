using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='TimedUndoAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/TimedUndoAdapter", DoNotGenerateAcw=true)]
	public partial class TimedUndoAdapter : global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.SimpleSwipeUndoAdapter {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='TimedUndoAdapter']/field[@name='DEFAULT_TIMEOUT_MS']"
		[Register ("DEFAULT_TIMEOUT_MS")]
		public const long DefaultTimeoutMs = (long) 3000L;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='TimedUndoAdapter.TimeoutRunnable']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/TimedUndoAdapter$TimeoutRunnable", DoNotGenerateAcw=true)]
		public partial class TimeoutRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/TimedUndoAdapter$TimeoutRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TimeoutRunnable); }
			}

			protected TimeoutRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getPosition;
#pragma warning disable 0169
			static Delegate GetGetPositionHandler ()
			{
				if (cb_getPosition == null)
					cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPosition);
				return cb_getPosition;
			}

			static int n_GetPosition (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.TimedUndoAdapter.TimeoutRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.TimedUndoAdapter.TimeoutRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Position;
			}
#pragma warning restore 0169

			static Delegate cb_setPosition_I;
#pragma warning disable 0169
			static Delegate GetSetPosition_IHandler ()
			{
				if (cb_setPosition_I == null)
					cb_setPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPosition_I);
				return cb_setPosition_I;
			}

			static void n_SetPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.TimedUndoAdapter.TimeoutRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.TimedUndoAdapter.TimeoutRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Position = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getPosition;
			static IntPtr id_setPosition_I;
			public virtual unsafe int Position {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='TimedUndoAdapter.TimeoutRunnable']/method[@name='getPosition' and count(parameter)=0]"
				[Register ("getPosition", "()I", "GetGetPositionHandler")]
				get {
					if (id_getPosition == IntPtr.Zero)
						id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getPosition);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()I"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='TimedUndoAdapter.TimeoutRunnable']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setPosition", "(I)V", "GetSetPosition_IHandler")]
				set {
					if (id_setPosition_I == IntPtr.Zero)
						id_setPosition_I = JNIEnv.GetMethodID (class_ref, "setPosition", "(I)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setPosition_I, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(I)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.TimedUndoAdapter.TimeoutRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.TimedUndoAdapter.TimeoutRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='TimedUndoAdapter.TimeoutRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/undo/TimedUndoAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimedUndoAdapter); }
		}

		protected TimedUndoAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_setTimeoutMs_J;
#pragma warning disable 0169
		static Delegate GetSetTimeoutMs_JHandler ()
		{
			if (cb_setTimeoutMs_J == null)
				cb_setTimeoutMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimeoutMs_J);
			return cb_setTimeoutMs_J;
		}

		static void n_SetTimeoutMs_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.TimedUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Undo.TimedUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeoutMs (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeoutMs_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.undo']/class[@name='TimedUndoAdapter']/method[@name='setTimeoutMs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimeoutMs", "(J)V", "GetSetTimeoutMs_JHandler")]
		public virtual unsafe void SetTimeoutMs (long p0)
		{
			if (id_setTimeoutMs_J == IntPtr.Zero)
				id_setTimeoutMs_J = JNIEnv.GetMethodID (class_ref, "setTimeoutMs", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimeoutMs_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeoutMs", "(J)V"), __args);
			} finally {
			}
		}

	}
}
