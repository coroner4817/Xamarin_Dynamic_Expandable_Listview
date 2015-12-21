using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeTouchListener", DoNotGenerateAcw=true)]
	public abstract partial class SwipeTouchListener : global::Java.Lang.Object, global::Android.Views.View.IOnTouchListener, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.ITouchEventHandler {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener.FlingAnimatorListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeTouchListener$FlingAnimatorListener", DoNotGenerateAcw=true)]
		public partial class FlingAnimatorListener : global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter {

			protected FlingAnimatorListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener.RestoreAnimatorListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeTouchListener$RestoreAnimatorListener", DoNotGenerateAcw=true)]
		public partial class RestoreAnimatorListener : global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter {

			protected RestoreAnimatorListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeTouchListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeTouchListener); }
		}

		protected SwipeTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/constructor[@name='SwipeTouchListener' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.util.ListViewWrapper']]"
		[Register (".ctor", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", "")]
		protected unsafe SwipeTouchListener (global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SwipeTouchListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ == IntPtr.Zero)
					id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nhaarman/listviewanimations/util/ListViewWrapper;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_ListViewWrapper_, __args);
			} finally {
			}
		}

		static Delegate cb_getActiveSwipeCount;
#pragma warning disable 0169
		static Delegate GetGetActiveSwipeCountHandler ()
		{
			if (cb_getActiveSwipeCount == null)
				cb_getActiveSwipeCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetActiveSwipeCount);
			return cb_getActiveSwipeCount;
		}

		static int n_GetActiveSwipeCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActiveSwipeCount;
		}
#pragma warning restore 0169

		static IntPtr id_getActiveSwipeCount;
		protected virtual unsafe int ActiveSwipeCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='getActiveSwipeCount' and count(parameter)=0]"
			[Register ("getActiveSwipeCount", "()I", "GetGetActiveSwipeCountHandler")]
			get {
				if (id_getActiveSwipeCount == IntPtr.Zero)
					id_getActiveSwipeCount = JNIEnv.GetMethodID (class_ref, "getActiveSwipeCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getActiveSwipeCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveSwipeCount", "()I"));
				} finally {
				}
			}
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInteracting;
		}
#pragma warning restore 0169

		static IntPtr id_isInteracting;
		public virtual unsafe bool IsInteracting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='isInteracting' and count(parameter)=0]"
			[Register ("isInteracting", "()Z", "GetIsInteractingHandler")]
			get {
				if (id_isInteracting == IntPtr.Zero)
					id_isInteracting = JNIEnv.GetMethodID (class_ref, "isInteracting", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInteracting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInteracting", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSwiping;
#pragma warning disable 0169
		static Delegate GetIsSwipingHandler ()
		{
			if (cb_isSwiping == null)
				cb_isSwiping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSwiping);
			return cb_isSwiping;
		}

		static bool n_IsSwiping (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSwiping;
		}
#pragma warning restore 0169

		static IntPtr id_isSwiping;
		public virtual unsafe bool IsSwiping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='isSwiping' and count(parameter)=0]"
			[Register ("isSwiping", "()Z", "GetIsSwipingHandler")]
			get {
				if (id_isSwiping == IntPtr.Zero)
					id_isSwiping = JNIEnv.GetMethodID (class_ref, "isSwiping", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSwiping);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSwiping", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getListViewWrapper;
#pragma warning disable 0169
		static Delegate GetGetListViewWrapperHandler ()
		{
			if (cb_getListViewWrapper == null)
				cb_getListViewWrapper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListViewWrapper);
			return cb_getListViewWrapper;
		}

		static IntPtr n_GetListViewWrapper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListViewWrapper);
		}
#pragma warning restore 0169

		static IntPtr id_getListViewWrapper;
		public virtual unsafe global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper ListViewWrapper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='getListViewWrapper' and count(parameter)=0]"
			[Register ("getListViewWrapper", "()Lcom/nhaarman/listviewanimations/util/ListViewWrapper;", "GetGetListViewWrapperHandler")]
			get {
				if (id_getListViewWrapper == IntPtr.Zero)
					id_getListViewWrapper = JNIEnv.GetMethodID (class_ref, "getListViewWrapper", "()Lcom/nhaarman/listviewanimations/util/ListViewWrapper;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (JNIEnv.CallObjectMethod  (Handle, id_getListViewWrapper), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Util.IListViewWrapper> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListViewWrapper", "()Lcom/nhaarman/listviewanimations/util/ListViewWrapper;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_afterCancelSwipe_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetAfterCancelSwipe_Landroid_view_View_IHandler ()
		{
			if (cb_afterCancelSwipe_Landroid_view_View_I == null)
				cb_afterCancelSwipe_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AfterCancelSwipe_Landroid_view_View_I);
			return cb_afterCancelSwipe_Landroid_view_View_I;
		}

		static void n_AfterCancelSwipe_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AfterCancelSwipe (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_afterCancelSwipe_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='afterCancelSwipe' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("afterCancelSwipe", "(Landroid/view/View;I)V", "GetAfterCancelSwipe_Landroid_view_View_IHandler")]
		protected virtual unsafe void AfterCancelSwipe (global::Android.Views.View p0, int p1)
		{
			if (id_afterCancelSwipe_Landroid_view_View_I == IntPtr.Zero)
				id_afterCancelSwipe_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "afterCancelSwipe", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_afterCancelSwipe_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterCancelSwipe", "(Landroid/view/View;I)V"), __args);
			} finally {
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AfterViewFling (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='afterViewFling' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("afterViewFling", "(Landroid/view/View;I)V", "GetAfterViewFling_Landroid_view_View_IHandler")]
		protected abstract void AfterViewFling (global::Android.Views.View p0, int p1);

		static Delegate cb_beforeViewFling_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetBeforeViewFling_Landroid_view_View_IHandler ()
		{
			if (cb_beforeViewFling_Landroid_view_View_I == null)
				cb_beforeViewFling_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_BeforeViewFling_Landroid_view_View_I);
			return cb_beforeViewFling_Landroid_view_View_I;
		}

		static void n_BeforeViewFling_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BeforeViewFling (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_beforeViewFling_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='beforeViewFling' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("beforeViewFling", "(Landroid/view/View;I)V", "GetBeforeViewFling_Landroid_view_View_IHandler")]
		protected virtual unsafe void BeforeViewFling (global::Android.Views.View p0, int p1)
		{
			if (id_beforeViewFling_Landroid_view_View_I == IntPtr.Zero)
				id_beforeViewFling_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "beforeViewFling", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_beforeViewFling_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beforeViewFling", "(Landroid/view/View;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disableSwipe;
#pragma warning disable 0169
		static Delegate GetDisableSwipeHandler ()
		{
			if (cb_disableSwipe == null)
				cb_disableSwipe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableSwipe);
			return cb_disableSwipe;
		}

		static void n_DisableSwipe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableSwipe ();
		}
#pragma warning restore 0169

		static IntPtr id_disableSwipe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='disableSwipe' and count(parameter)=0]"
		[Register ("disableSwipe", "()V", "GetDisableSwipeHandler")]
		public virtual unsafe void DisableSwipe ()
		{
			if (id_disableSwipe == IntPtr.Zero)
				id_disableSwipe = JNIEnv.GetMethodID (class_ref, "disableSwipe", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disableSwipe);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableSwipe", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableSwipe;
#pragma warning disable 0169
		static Delegate GetEnableSwipeHandler ()
		{
			if (cb_enableSwipe == null)
				cb_enableSwipe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableSwipe);
			return cb_enableSwipe;
		}

		static void n_EnableSwipe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableSwipe ();
		}
#pragma warning restore 0169

		static IntPtr id_enableSwipe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='enableSwipe' and count(parameter)=0]"
		[Register ("enableSwipe", "()V", "GetEnableSwipeHandler")]
		public virtual unsafe void EnableSwipe ()
		{
			if (id_enableSwipe == IntPtr.Zero)
				id_enableSwipe = JNIEnv.GetMethodID (class_ref, "enableSwipe", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableSwipe);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableSwipe", "()V"));
			} finally {
			}
		}

		static Delegate cb_fling_I;
#pragma warning disable 0169
		static Delegate GetFling_IHandler ()
		{
			if (cb_fling_I == null)
				cb_fling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Fling_I);
			return cb_fling_I;
		}

		static void n_Fling_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Fling (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fling_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='fling' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fling", "(I)V", "GetFling_IHandler")]
		public virtual unsafe void Fling (int p0)
		{
			if (id_fling_I == IntPtr.Zero)
				id_fling_I = JNIEnv.GetMethodID (class_ref, "fling", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_fling_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fling", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getSwipeView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetSwipeView_Landroid_view_View_Handler ()
		{
			if (cb_getSwipeView_Landroid_view_View_ == null)
				cb_getSwipeView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSwipeView_Landroid_view_View_);
			return cb_getSwipeView_Landroid_view_View_;
		}

		static IntPtr n_GetSwipeView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSwipeView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSwipeView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='getSwipeView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getSwipeView", "(Landroid/view/View;)Landroid/view/View;", "GetGetSwipeView_Landroid_view_View_Handler")]
		protected virtual unsafe global::Android.Views.View GetSwipeView (global::Android.Views.View p0)
		{
			if (id_getSwipeView_Landroid_view_View_ == IntPtr.Zero)
				id_getSwipeView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getSwipeView", "(Landroid/view/View;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getSwipeView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSwipeView", "(Landroid/view/View;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public virtual unsafe void NotifyDataSetChanged ()
		{
			if (id_notifyDataSetChanged == IntPtr.Zero)
				id_notifyDataSetChanged = JNIEnv.GetMethodID (class_ref, "notifyDataSetChanged", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_notifyDataSetChanged);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDataSetChanged", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCancelSwipe_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnCancelSwipe_Landroid_view_View_IHandler ()
		{
			if (cb_onCancelSwipe_Landroid_view_View_I == null)
				cb_onCancelSwipe_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnCancelSwipe_Landroid_view_View_I);
			return cb_onCancelSwipe_Landroid_view_View_I;
		}

		static void n_OnCancelSwipe_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelSwipe (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onCancelSwipe_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='onCancelSwipe' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onCancelSwipe", "(Landroid/view/View;I)V", "GetOnCancelSwipe_Landroid_view_View_IHandler")]
		protected virtual unsafe void OnCancelSwipe (global::Android.Views.View p0, int p1)
		{
			if (id_onCancelSwipe_Landroid_view_View_I == IntPtr.Zero)
				id_onCancelSwipe_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onCancelSwipe", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCancelSwipe_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancelSwipe", "(Landroid/view/View;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStartSwipe_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnStartSwipe_Landroid_view_View_IHandler ()
		{
			if (cb_onStartSwipe_Landroid_view_View_I == null)
				cb_onStartSwipe_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnStartSwipe_Landroid_view_View_I);
			return cb_onStartSwipe_Landroid_view_View_I;
		}

		static void n_OnStartSwipe_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStartSwipe (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onStartSwipe_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='onStartSwipe' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onStartSwipe", "(Landroid/view/View;I)V", "GetOnStartSwipe_Landroid_view_View_IHandler")]
		protected virtual unsafe void OnStartSwipe (global::Android.Views.View p0, int p1)
		{
			if (id_onStartSwipe_Landroid_view_View_I == IntPtr.Zero)
				id_onStartSwipe_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onStartSwipe", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStartSwipe_Landroid_view_View_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStartSwipe", "(Landroid/view/View;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
		{
			if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_restoreViewPresentation_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRestoreViewPresentation_Landroid_view_View_Handler ()
		{
			if (cb_restoreViewPresentation_Landroid_view_View_ == null)
				cb_restoreViewPresentation_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RestoreViewPresentation_Landroid_view_View_);
			return cb_restoreViewPresentation_Landroid_view_View_;
		}

		static void n_RestoreViewPresentation_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestoreViewPresentation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_restoreViewPresentation_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='restoreViewPresentation' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("restoreViewPresentation", "(Landroid/view/View;)V", "GetRestoreViewPresentation_Landroid_view_View_Handler")]
		protected virtual unsafe void RestoreViewPresentation (global::Android.Views.View p0)
		{
			if (id_restoreViewPresentation_Landroid_view_View_ == IntPtr.Zero)
				id_restoreViewPresentation_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "restoreViewPresentation", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_restoreViewPresentation_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreViewPresentation", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
#pragma warning disable 0169
		static Delegate GetSetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_Handler ()
		{
			if (cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ == null)
				cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_);
			return cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
		}

		static void n_SetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDismissableManager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='setDismissableManager' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.DismissableManager']]"
		[Register ("setDismissableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager;)V", "GetSetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_Handler")]
		public virtual unsafe void SetDismissableManager (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager p0)
		{
			if (id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ == IntPtr.Zero)
				id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ = JNIEnv.GetMethodID (class_ref, "setDismissableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDismissableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMinimumAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetMinimumAlpha_FHandler ()
		{
			if (cb_setMinimumAlpha_F == null)
				cb_setMinimumAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinimumAlpha_F);
			return cb_setMinimumAlpha_F;
		}

		static void n_SetMinimumAlpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinimumAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMinimumAlpha_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='setMinimumAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMinimumAlpha", "(F)V", "GetSetMinimumAlpha_FHandler")]
		public virtual unsafe void SetMinimumAlpha (float p0)
		{
			if (id_setMinimumAlpha_F == IntPtr.Zero)
				id_setMinimumAlpha_F = JNIEnv.GetMethodID (class_ref, "setMinimumAlpha", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMinimumAlpha_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinimumAlpha", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setParentIsHorizontalScrollContainer;
#pragma warning disable 0169
		static Delegate GetSetParentIsHorizontalScrollContainerHandler ()
		{
			if (cb_setParentIsHorizontalScrollContainer == null)
				cb_setParentIsHorizontalScrollContainer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetParentIsHorizontalScrollContainer);
			return cb_setParentIsHorizontalScrollContainer;
		}

		static void n_SetParentIsHorizontalScrollContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetParentIsHorizontalScrollContainer ();
		}
#pragma warning restore 0169

		static IntPtr id_setParentIsHorizontalScrollContainer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='setParentIsHorizontalScrollContainer' and count(parameter)=0]"
		[Register ("setParentIsHorizontalScrollContainer", "()V", "GetSetParentIsHorizontalScrollContainerHandler")]
		public virtual unsafe void SetParentIsHorizontalScrollContainer ()
		{
			if (id_setParentIsHorizontalScrollContainer == IntPtr.Zero)
				id_setParentIsHorizontalScrollContainer = JNIEnv.GetMethodID (class_ref, "setParentIsHorizontalScrollContainer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setParentIsHorizontalScrollContainer);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParentIsHorizontalScrollContainer", "()V"));
			} finally {
			}
		}

		static Delegate cb_setTouchChild_I;
#pragma warning disable 0169
		static Delegate GetSetTouchChild_IHandler ()
		{
			if (cb_setTouchChild_I == null)
				cb_setTouchChild_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTouchChild_I);
			return cb_setTouchChild_I;
		}

		static void n_SetTouchChild_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTouchChild (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTouchChild_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='setTouchChild' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTouchChild", "(I)V", "GetSetTouchChild_IHandler")]
		public virtual unsafe void SetTouchChild (int p0)
		{
			if (id_setTouchChild_I == IntPtr.Zero)
				id_setTouchChild_I = JNIEnv.GetMethodID (class_ref, "setTouchChild", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTouchChild_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTouchChild", "(I)V"), __args);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.WillLeaveDataSetOnFling (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='willLeaveDataSetOnFling' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("willLeaveDataSetOnFling", "(Landroid/view/View;I)Z", "GetWillLeaveDataSetOnFling_Landroid_view_View_IHandler")]
		protected abstract bool WillLeaveDataSetOnFling (global::Android.Views.View p0, int p1);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeTouchListener", DoNotGenerateAcw=true)]
	internal partial class SwipeTouchListenerInvoker : SwipeTouchListener {

		public SwipeTouchListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeTouchListenerInvoker); }
		}

		static IntPtr id_afterViewFling_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='afterViewFling' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("afterViewFling", "(Landroid/view/View;I)V", "GetAfterViewFling_Landroid_view_View_IHandler")]
		protected override unsafe void AfterViewFling (global::Android.Views.View p0, int p1)
		{
			if (id_afterViewFling_Landroid_view_View_I == IntPtr.Zero)
				id_afterViewFling_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "afterViewFling", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_afterViewFling_Landroid_view_View_I, __args);
			} finally {
			}
		}

		static IntPtr id_willLeaveDataSetOnFling_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeTouchListener']/method[@name='willLeaveDataSetOnFling' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("willLeaveDataSetOnFling", "(Landroid/view/View;I)Z", "GetWillLeaveDataSetOnFling_Landroid_view_View_IHandler")]
		protected override unsafe bool WillLeaveDataSetOnFling (global::Android.Views.View p0, int p1)
		{
			if (id_willLeaveDataSetOnFling_Landroid_view_View_I == IntPtr.Zero)
				id_willLeaveDataSetOnFling_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "willLeaveDataSetOnFling", "(Landroid/view/View;I)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_willLeaveDataSetOnFling_Landroid_view_View_I, __args);
				return __ret;
			} finally {
			}
		}

	}

}
