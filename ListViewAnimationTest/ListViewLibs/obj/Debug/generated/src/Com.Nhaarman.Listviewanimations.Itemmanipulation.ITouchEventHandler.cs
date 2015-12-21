using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='TouchEventHandler']"
	[Register ("com/nhaarman/listviewanimations/itemmanipulation/TouchEventHandler", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.ITouchEventHandlerInvoker")]
	public partial interface ITouchEventHandler : IJavaObject {

		bool IsInteracting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='TouchEventHandler']/method[@name='isInteracting' and count(parameter)=0]"
			[Register ("isInteracting", "()Z", "GetIsInteractingHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.ITouchEventHandlerInvoker, ListViewLibs")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='TouchEventHandler']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler:Com.Nhaarman.Listviewanimations.Itemmanipulation.ITouchEventHandlerInvoker, ListViewLibs")]
		bool OnTouchEvent (global::Android.Views.MotionEvent p0);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/TouchEventHandler", DoNotGenerateAcw=true)]
	internal class ITouchEventHandlerInvoker : global::Java.Lang.Object, ITouchEventHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/TouchEventHandler");
		IntPtr class_ref;

		public static ITouchEventHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITouchEventHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.TouchEventHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITouchEventHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITouchEventHandlerInvoker); }
		}

		static Delegate cb_isInteracting;
#pragma warning disable 0169
		static Delegate GetIsInteractingHandler ()
		{
			if (cb_isInteracting == null)
				cb_isInteracting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInteracting);
			return cb_isInteracting;
		}

		static bool n_IsInteracting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.ITouchEventHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.ITouchEventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInteracting;
		}
#pragma warning restore 0169

		IntPtr id_isInteracting;
		public unsafe bool IsInteracting {
			get {
				if (id_isInteracting == IntPtr.Zero)
					id_isInteracting = JNIEnv.GetMethodID (class_ref, "isInteracting", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isInteracting);
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.ITouchEventHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.ITouchEventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		public unsafe bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, __args);
			return __ret;
		}

	}

}
