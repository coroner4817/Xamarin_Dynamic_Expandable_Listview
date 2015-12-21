using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener", DoNotGenerateAcw=true)]
	public partial class SwipeDismissTouchListener : global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener.DismissAnimatorListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener$DismissAnimatorListener", DoNotGenerateAcw=true)]
		public partial class DismissAnimatorListener : global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter {

			protected DismissAnimatorListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener.DismissAnimatorUpdateListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener$DismissAnimatorUpdateListener", DoNotGenerateAcw=true)]
		public partial class DismissAnimatorUpdateListener : global::Java.Lang.Object, global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener$DismissAnimatorUpdateListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DismissAnimatorUpdateListener); }
			}

			protected DismissAnimatorUpdateListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener.DismissAnimatorUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener.DismissAnimatorUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.ValueAnimator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationUpdate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener.DismissAnimatorUpdateListener']/method[@name='onAnimationUpdate' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.ValueAnimator']]"
			[Register ("onAnimationUpdate", "(Lcom/nineoldandroids/animation/ValueAnimator;)V", "GetOnAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_Handler")]
			public virtual unsafe void OnAnimationUpdate (global::Com.Nineoldandroids.Animation.ValueAnimator p0)
			{
				if (id_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_ == IntPtr.Zero)
					id_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_ = JNIEnv.GetMethodID (class_ref, "onAnimationUpdate", "(Lcom/nineoldandroids/animation/ValueAnimator;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationUpdate", "(Lcom/nineoldandroids/animation/ValueAnimator;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener.RestoreScrollRunnable']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener$RestoreScrollRunnable", DoNotGenerateAcw=true)]
		public partial class RestoreScrollRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener$RestoreScrollRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RestoreScrollRunnable); }
			}

			protected RestoreScrollRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener.RestoreScrollRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener.RestoreScrollRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener.RestoreScrollRunnable']/method[@name='run' and count(parameter)=0]"
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
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissTouchListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeDismissTouchListener); }
		}

		protected SwipeDismissTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/constructor[@name='SwipeDismissTouchListener' and count(parameter)=2 and parameter[1][@type='com.nhaarman.listviewanimations.util.ListViewWrapper'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.OnDismissCallback']]"
		[Register (".ctor", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", "")]
		public unsafe SwipeDismissTouchListener (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IOnDismissCallback p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SwipeDismissTouchListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ == IntPtr.Zero)
					id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/OnDismissCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_OnDismissCallback_, __args);
			} finally {
			}
		}

		static Delegate cb_getActiveDismissCount;
#pragma warning disable 0169
		static Delegate GetGetActiveDismissCountHandler ()
		{
			if (cb_getActiveDismissCount == null)
				cb_getActiveDismissCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetActiveDismissCount);
			return cb_getActiveDismissCount;
		}

		static int n_GetActiveDismissCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActiveDismissCount;
		}
#pragma warning restore 0169

		static IntPtr id_getActiveDismissCount;
		protected virtual unsafe int ActiveDismissCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='getActiveDismissCount' and count(parameter)=0]"
			[Register ("getActiveDismissCount", "()I", "GetGetActiveDismissCountHandler")]
			get {
				if (id_getActiveDismissCount == IntPtr.Zero)
					id_getActiveDismissCount = JNIEnv.GetMethodID (class_ref, "getActiveDismissCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getActiveDismissCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveDismissCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDismissAnimationTime;
#pragma warning disable 0169
		static Delegate GetGetDismissAnimationTimeHandler ()
		{
			if (cb_getDismissAnimationTime == null)
				cb_getDismissAnimationTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDismissAnimationTime);
			return cb_getDismissAnimationTime;
		}

		static long n_GetDismissAnimationTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DismissAnimationTime;
		}
#pragma warning restore 0169

		static IntPtr id_getDismissAnimationTime;
		public virtual unsafe long DismissAnimationTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='getDismissAnimationTime' and count(parameter)=0]"
			[Register ("getDismissAnimationTime", "()J", "GetGetDismissAnimationTimeHandler")]
			get {
				if (id_getDismissAnimationTime == IntPtr.Zero)
					id_getDismissAnimationTime = JNIEnv.GetMethodID (class_ref, "getDismissAnimationTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getDismissAnimationTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDismissAnimationTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_afterViewFling_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetAfterViewFling_Landroid_view_View_IHandler ()
		{
			if (cb_afterViewFling_Landroid_view_View_I == null)
				cb_afterViewFling_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AfterViewFling_Landroid_view_View_I);
			return cb_afterViewFling_Landroid_view_View_I;
		}

		static void n_AfterViewFling_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AfterViewFling (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_afterViewFling_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='afterViewFling' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("afterViewFling", "(Landroid/view/View;I)V", "GetAfterViewFling_Landroid_view_View_IHandler")]
		protected override unsafe void AfterViewFling (global::Android.Views.View p0, int p1)
		{
			if (id_afterViewFling_Landroid_view_View_I == IntPtr.Zero)
				id_afterViewFling_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "afterViewFling", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_afterViewFling_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterViewFling", "(Landroid/view/View;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_directDismiss_I;
#pragma warning disable 0169
		static Delegate GetDirectDismiss_IHandler ()
		{
			if (cb_directDismiss_I == null)
				cb_directDismiss_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DirectDismiss_I);
			return cb_directDismiss_I;
		}

		static void n_DirectDismiss_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DirectDismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_directDismiss_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='directDismiss' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("directDismiss", "(I)V", "GetDirectDismiss_IHandler")]
		protected virtual unsafe void DirectDismiss (int p0)
		{
			if (id_directDismiss_I == IntPtr.Zero)
				id_directDismiss_I = JNIEnv.GetMethodID (class_ref, "directDismiss", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_directDismiss_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "directDismiss", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_dismiss_I;
#pragma warning disable 0169
		static Delegate GetDismiss_IHandler ()
		{
			if (cb_dismiss_I == null)
				cb_dismiss_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Dismiss_I);
			return cb_dismiss_I;
		}

		static void n_Dismiss_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dismiss_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='dismiss' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("dismiss", "(I)V", "GetDismiss_IHandler")]
		public virtual unsafe void Dismiss (int p0)
		{
			if (id_dismiss_I == IntPtr.Zero)
				id_dismiss_I = JNIEnv.GetMethodID (class_ref, "dismiss", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dismiss_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dismiss", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_finalizeDismiss;
#pragma warning disable 0169
		static Delegate GetFinalizeDismissHandler ()
		{
			if (cb_finalizeDismiss == null)
				cb_finalizeDismiss = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinalizeDismiss);
			return cb_finalizeDismiss;
		}

		static void n_FinalizeDismiss (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinalizeDismiss ();
		}
#pragma warning restore 0169

		static IntPtr id_finalizeDismiss;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='finalizeDismiss' and count(parameter)=0]"
		[Register ("finalizeDismiss", "()V", "GetFinalizeDismissHandler")]
		protected virtual unsafe void FinalizeDismiss ()
		{
			if (id_finalizeDismiss == IntPtr.Zero)
				id_finalizeDismiss = JNIEnv.GetMethodID (class_ref, "finalizeDismiss", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_finalizeDismiss);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalizeDismiss", "()V"));
			} finally {
			}
		}

		static Delegate cb_notifyCallback_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetNotifyCallback_Ljava_util_List_Handler ()
		{
			if (cb_notifyCallback_Ljava_util_List_ == null)
				cb_notifyCallback_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyCallback_Ljava_util_List_);
			return cb_notifyCallback_Ljava_util_List_;
		}

		static void n_NotifyCallback_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyCallback_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='notifyCallback' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("notifyCallback", "(Ljava/util/List;)V", "GetNotifyCallback_Ljava_util_List_Handler")]
		protected virtual unsafe void NotifyCallback (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
		{
			if (id_notifyCallback_Ljava_util_List_ == IntPtr.Zero)
				id_notifyCallback_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "notifyCallback", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyCallback_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyCallback", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_performDismiss_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetPerformDismiss_Landroid_view_View_IHandler ()
		{
			if (cb_performDismiss_Landroid_view_View_I == null)
				cb_performDismiss_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_PerformDismiss_Landroid_view_View_I);
			return cb_performDismiss_Landroid_view_View_I;
		}

		static void n_PerformDismiss_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PerformDismiss (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_performDismiss_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='performDismiss' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("performDismiss", "(Landroid/view/View;I)V", "GetPerformDismiss_Landroid_view_View_IHandler")]
		protected virtual unsafe void PerformDismiss (global::Android.Views.View p0, int p1)
		{
			if (id_performDismiss_Landroid_view_View_I == IntPtr.Zero)
				id_performDismiss_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "performDismiss", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_performDismiss_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performDismiss", "(Landroid/view/View;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_restoreViewPresentations_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetRestoreViewPresentations_Ljava_lang_Iterable_Handler ()
		{
			if (cb_restoreViewPresentations_Ljava_lang_Iterable_ == null)
				cb_restoreViewPresentations_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RestoreViewPresentations_Ljava_lang_Iterable_);
			return cb_restoreViewPresentations_Ljava_lang_Iterable_;
		}

		static void n_RestoreViewPresentations_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p0 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestoreViewPresentations (p0);
		}
#pragma warning restore 0169

		static IntPtr id_restoreViewPresentations_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='restoreViewPresentations' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;android.view.View&gt;']]"
		[Register ("restoreViewPresentations", "(Ljava/lang/Iterable;)V", "GetRestoreViewPresentations_Ljava_lang_Iterable_Handler")]
		protected virtual unsafe void RestoreViewPresentations (global::Java.Lang.IIterable p0)
		{
			if (id_restoreViewPresentations_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_restoreViewPresentations_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "restoreViewPresentations", "(Ljava/lang/Iterable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_restoreViewPresentations_Ljava_lang_Iterable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreViewPresentations", "(Ljava/lang/Iterable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_willLeaveDataSetOnFling_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetWillLeaveDataSetOnFling_Landroid_view_View_IHandler ()
		{
			if (cb_willLeaveDataSetOnFling_Landroid_view_View_I == null)
				cb_willLeaveDataSetOnFling_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_WillLeaveDataSetOnFling_Landroid_view_View_I);
			return cb_willLeaveDataSetOnFling_Landroid_view_View_I;
		}

		static bool n_WillLeaveDataSetOnFling_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.WillLeaveDataSetOnFling (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_willLeaveDataSetOnFling_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissTouchListener']/method[@name='willLeaveDataSetOnFling' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("willLeaveDataSetOnFling", "(Landroid/view/View;I)Z", "GetWillLeaveDataSetOnFling_Landroid_view_View_IHandler")]
		protected override unsafe bool WillLeaveDataSetOnFling (global::Android.Views.View p0, int p1)
		{
			if (id_willLeaveDataSetOnFling_Landroid_view_View_I == IntPtr.Zero)
				id_willLeaveDataSetOnFling_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "willLeaveDataSetOnFling", "(Landroid/view/View;I)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_willLeaveDataSetOnFling_Landroid_view_View_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "willLeaveDataSetOnFling", "(Landroid/view/View;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
