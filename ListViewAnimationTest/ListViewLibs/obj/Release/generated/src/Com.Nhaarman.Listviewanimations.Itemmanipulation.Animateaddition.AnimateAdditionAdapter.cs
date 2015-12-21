using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/animateaddition/AnimateAdditionAdapter", DoNotGenerateAcw=true)]
	public partial class AnimateAdditionAdapter : global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter.ExpandAnimationListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/animateaddition/AnimateAdditionAdapter$ExpandAnimationListener", DoNotGenerateAcw=true)]
		public partial class ExpandAnimationListener : global::Com.Nineoldandroids.Animation.AnimatorListenerAdapter {

			protected ExpandAnimationListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter.HeightUpdater']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/animateaddition/AnimateAdditionAdapter$HeightUpdater", DoNotGenerateAcw=true)]
		public partial class HeightUpdater : global::Java.Lang.Object, global::Com.Nineoldandroids.Animation.ValueAnimator.IAnimatorUpdateListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/animateaddition/AnimateAdditionAdapter$HeightUpdater", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HeightUpdater); }
			}

			protected HeightUpdater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter.HeightUpdater __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter.HeightUpdater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nineoldandroids.Animation.ValueAnimator p0 = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.Animation.ValueAnimator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationUpdate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationUpdate_Lcom_nineoldandroids_animation_ValueAnimator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter.HeightUpdater']/method[@name='onAnimationUpdate' and count(parameter)=1 and parameter[1][@type='com.nineoldandroids.animation.ValueAnimator']]"
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/animateaddition/AnimateAdditionAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimateAdditionAdapter); }
		}

		protected AnimateAdditionAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/constructor[@name='AnimateAdditionAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		public unsafe AnimateAdditionAdapter (global::Android.Widget.BaseAdapter p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AnimateAdditionAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;)V", __args);
					return;
				}

				if (id_ctor_Landroid_widget_BaseAdapter_ == IntPtr.Zero)
					id_ctor_Landroid_widget_BaseAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_);
			return cb_getAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAdditionalAnimators (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/method[@name='getAdditionalAnimators' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("getAdditionalAnimators", "(Landroid/view/View;Landroid/view/ViewGroup;)[Lcom/nineoldandroids/animation/Animator;", "GetGetAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_Handler")]
		protected virtual unsafe global::Com.Nineoldandroids.Animation.Animator[] GetAdditionalAnimators (global::Android.Views.View p0, global::Android.Views.ViewGroup p1)
		{
			if (id_getAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getAdditionalAnimators", "(Landroid/view/View;Landroid/view/ViewGroup;)[Lcom/nineoldandroids/animation/Animator;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Nineoldandroids.Animation.Animator[] __ret;
				if (GetType () == ThresholdType)
					__ret = (global::Com.Nineoldandroids.Animation.Animator[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAdditionalAnimators_Landroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nineoldandroids.Animation.Animator));
				else
					__ret = (global::Com.Nineoldandroids.Animation.Animator[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdditionalAnimators", "(Landroid/view/View;Landroid/view/ViewGroup;)[Lcom/nineoldandroids/animation/Animator;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nineoldandroids.Animation.Animator));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_insert_arrayLandroid_util_Pair_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLandroid_util_Pair_Handler ()
		{
			if (cb_insert_arrayLandroid_util_Pair_ == null)
				cb_insert_arrayLandroid_util_Pair_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Insert_arrayLandroid_util_Pair_);
			return cb_insert_arrayLandroid_util_Pair_;
		}

		static void n_Insert_arrayLandroid_util_Pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.Pair[] p0 = (global::Android.Util.Pair[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Util.Pair));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_insert_arrayLandroid_util_Pair_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='android.util.Pair&lt;java.lang.Integer, T&gt;...']]"
		[Register ("insert", "([Landroid/util/Pair;)V", "GetInsert_arrayLandroid_util_Pair_Handler")]
		public virtual unsafe void Insert (params global:: Android.Util.Pair[] p0)
		{
			if (id_insert_arrayLandroid_util_Pair_ == IntPtr.Zero)
				id_insert_arrayLandroid_util_Pair_ = JNIEnv.GetMethodID (class_ref, "insert", "([Landroid/util/Pair;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_arrayLandroid_util_Pair_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "([Landroid/util/Pair;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_insert_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInsert_ILjava_lang_Object_Handler ()
		{
			if (cb_insert_ILjava_lang_Object_ == null)
				cb_insert_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Insert_ILjava_lang_Object_);
			return cb_insert_ILjava_lang_Object_;
		}

		static void n_Insert_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_insert_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("insert", "(ILjava/lang/Object;)V", "GetInsert_ILjava_lang_Object_Handler")]
		public virtual unsafe void Insert (int p0, global::Java.Lang.Object p1)
		{
			if (id_insert_ILjava_lang_Object_ == IntPtr.Zero)
				id_insert_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "insert", "(ILjava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(ILjava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_insert_IarrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInsert_IarrayLjava_lang_Object_Handler ()
		{
			if (cb_insert_IarrayLjava_lang_Object_ == null)
				cb_insert_IarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Insert_IarrayLjava_lang_Object_);
			return cb_insert_IarrayLjava_lang_Object_;
		}

		static void n_Insert_IarrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Insert (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_insert_IarrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T...']]"
		[Register ("insert", "(I[Ljava/lang/Object;)V", "GetInsert_IarrayLjava_lang_Object_Handler")]
		public virtual unsafe void Insert (int p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_insert_IarrayLjava_lang_Object_ == IntPtr.Zero)
				id_insert_IarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "insert", "(I[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_IarrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(I[Ljava/lang/Object;)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_insert_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetInsert_Ljava_lang_Iterable_Handler ()
		{
			if (cb_insert_Ljava_lang_Iterable_ == null)
				cb_insert_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Insert_Ljava_lang_Iterable_);
			return cb_insert_Ljava_lang_Iterable_;
		}

		static void n_Insert_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p0 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_insert_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;android.util.Pair&lt;java.lang.Integer, T&gt;&gt;']]"
		[Register ("insert", "(Ljava/lang/Iterable;)V", "GetInsert_Ljava_lang_Iterable_Handler")]
		public virtual unsafe void Insert (global::Java.Lang.IIterable p0)
		{
			if (id_insert_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_insert_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "insert", "(Ljava/lang/Iterable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_Ljava_lang_Iterable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Ljava/lang/Iterable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setInsertionAnimationDuration_J;
#pragma warning disable 0169
		static Delegate GetSetInsertionAnimationDuration_JHandler ()
		{
			if (cb_setInsertionAnimationDuration_J == null)
				cb_setInsertionAnimationDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetInsertionAnimationDuration_J);
			return cb_setInsertionAnimationDuration_J;
		}

		static void n_SetInsertionAnimationDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInsertionAnimationDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInsertionAnimationDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/method[@name='setInsertionAnimationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setInsertionAnimationDuration", "(J)V", "GetSetInsertionAnimationDuration_JHandler")]
		public virtual unsafe void SetInsertionAnimationDuration (long p0)
		{
			if (id_setInsertionAnimationDuration_J == IntPtr.Zero)
				id_setInsertionAnimationDuration_J = JNIEnv.GetMethodID (class_ref, "setInsertionAnimationDuration", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInsertionAnimationDuration_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInsertionAnimationDuration", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setListView_Landroid_widget_ListView_;
#pragma warning disable 0169
		static Delegate GetSetListView_Landroid_widget_ListView_Handler ()
		{
			if (cb_setListView_Landroid_widget_ListView_ == null)
				cb_setListView_Landroid_widget_ListView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListView_Landroid_widget_ListView_);
			return cb_setListView_Landroid_widget_ListView_;
		}

		static void n_SetListView_Landroid_widget_ListView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListView_Landroid_widget_ListView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/method[@name='setListView' and count(parameter)=1 and parameter[1][@type='android.widget.ListView']]"
		[Register ("setListView", "(Landroid/widget/ListView;)V", "GetSetListView_Landroid_widget_ListView_Handler")]
		public virtual unsafe void SetListView (global::Android.Widget.ListView p0)
		{
			if (id_setListView_Landroid_widget_ListView_ == IntPtr.Zero)
				id_setListView_Landroid_widget_ListView_ = JNIEnv.GetMethodID (class_ref, "setListView", "(Landroid/widget/ListView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListView_Landroid_widget_ListView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListView", "(Landroid/widget/ListView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScrolldownAnimationDuration_J;
#pragma warning disable 0169
		static Delegate GetSetScrolldownAnimationDuration_JHandler ()
		{
			if (cb_setScrolldownAnimationDuration_J == null)
				cb_setScrolldownAnimationDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetScrolldownAnimationDuration_J);
			return cb_setScrolldownAnimationDuration_J;
		}

		static void n_SetScrolldownAnimationDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrolldownAnimationDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScrolldownAnimationDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/method[@name='setScrolldownAnimationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setScrolldownAnimationDuration", "(J)V", "GetSetScrolldownAnimationDuration_JHandler")]
		public virtual unsafe void SetScrolldownAnimationDuration (long p0)
		{
			if (id_setScrolldownAnimationDuration_J == IntPtr.Zero)
				id_setScrolldownAnimationDuration_J = JNIEnv.GetMethodID (class_ref, "setScrolldownAnimationDuration", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScrolldownAnimationDuration_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrolldownAnimationDuration", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShouldAnimateDown_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldAnimateDown_ZHandler ()
		{
			if (cb_setShouldAnimateDown_Z == null)
				cb_setShouldAnimateDown_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShouldAnimateDown_Z);
			return cb_setShouldAnimateDown_Z;
		}

		static void n_SetShouldAnimateDown_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldAnimateDown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShouldAnimateDown_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='AnimateAdditionAdapter']/method[@name='setShouldAnimateDown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShouldAnimateDown", "(Z)V", "GetSetShouldAnimateDown_ZHandler")]
		public virtual unsafe void SetShouldAnimateDown (bool p0)
		{
			if (id_setShouldAnimateDown_Z == IntPtr.Zero)
				id_setShouldAnimateDown_Z = JNIEnv.GetMethodID (class_ref, "setShouldAnimateDown", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShouldAnimateDown_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldAnimateDown", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
